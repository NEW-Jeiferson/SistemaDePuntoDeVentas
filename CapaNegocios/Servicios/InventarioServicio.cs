using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios.Entidades;
using CapaNegocios.Exepciones;
using CapaNegocios.Eventos;
using CapaNegocios.Repositorios;

namespace CapaNegocios.Servicios
{
    public class InventarioService
    {
        //TODO: Diccionario para almacenar productos en memoria
        private Dictionary<string, Producto> inventario;
        //TODO: Usar repositorio de productos para operaciones BD
        private readonly ProductoRepositorio productoRepo;

        //TODO: Evento para inventario bajo
        public event EventHandler<InventarioBajoEventArgs> InventarioBajo;

        //TODO: Constructor encargado de inicializar repositorio e inventario
        public InventarioService()
        {
            inventario = new Dictionary<string, Producto>();
            productoRepo = new ProductoRepositorio();
        }

        //TODO: Cargar inventario desde BD usando Task.WhenAll
        public async Task CargarInventarioAsync()
        {
            var productos = await productoRepo.ObtenerTodosAsync();

            //TODO: Simular carga paralela de múltiples productos con Task.WhenAll para cargar varios productos al mismo tiempo
            var tareasValidacion = productos.Select(p => ValidarProductoAsync(p));
            var productosValidados = await Task.WhenAll(tareasValidacion);

            //TODO: Llenar el Dictionary
            inventario.Clear();
            foreach (var producto in productosValidados)
            {
                inventario[producto.Codigo] = producto;

                //TODO: Verificar inventario bajo y disparar evento
                if (producto.InventarioBajo)
                {
                    OnInventarioBajo(new InventarioBajoEventArgs(producto));
                }
            }
        }

        //TODO: Metodo async que simula validacion de producto
        private async Task<Producto> ValidarProductoAsync(Producto producto)
        {
            //TODO: Simular operacion asíncrona para consulta de validacion y tal
            await Task.Delay(5); //Aqui simulamos una pequeña demora para que sea async 
            return producto;
        }

        //TODO: Buscar producto por codigo con validacion
        public async Task<Producto> BuscarPorCodigoAsync(string codigo)
        {
            //TODO: Busca en memoria primero
            if (inventario.ContainsKey(codigo))
            {
                return inventario[codigo];
            }

            //TODO: Si no se encuentra en memoria, busca en la BD
            var producto = await productoRepo.BuscarPorCodigoAsync(codigo);

            if (producto == null)
            {
                throw new CodigoInvalidoException(codigo);
            }

            //TODO: Agregar al inventario en memoria
            inventario[codigo] = producto;

            //TODO: Verificar si esta bajo en stock
            if (producto.InventarioBajo)
            {
                OnInventarioBajo(new InventarioBajoEventArgs(producto));
            }

            return producto;
        }

        //TODO: Validar disponibilidad de stock
        public void ValidarStock(Producto producto, int cantidadSolicitada)
        {
            if (producto.Stock < cantidadSolicitada)
            {
                throw new ProductoAgotadoException(
                    producto.Codigo,
                    cantidadSolicitada,
                    producto.Stock
                );
            }
        }

        //TODO: Actualizar stock despues de una venta
        public async Task ActualizarStockAsync(int productoId, int cantidad)
        {
            await productoRepo.ActualizarStockAsync(productoId, cantidad);

            //TODO: Actualizar en memoria tambien, utilizamos FirstOrDefault para encontrar el producto por ID en el diccionario
            var producto = inventario.Values.FirstOrDefault(p => p.ProductoID == productoId);
            if (producto != null)
            {
                producto.Stock -= cantidad;

                //TODO: Verificar si quedo bajo en inventario
                if (producto.InventarioBajo)
                {
                    OnInventarioBajo(new InventarioBajoEventArgs(producto));
                }
            }
        }

        //TODO: Restauramos el stock para usar rollback de venta
        public async Task RestaurarStockAsync(int productoId, int cantidad)
        {
            await productoRepo.RestaurarStockAsync(productoId, cantidad);

            //TODO: Actualizar en memoria
            var producto = inventario.Values.FirstOrDefault(p => p.ProductoID == productoId);
            if (producto != null)
            {
                producto.Stock += cantidad;
            }
        }

        //TODO: Obtener productos con stock bajo
        public async Task<List<Producto>> ObtenerProductosStockBajoAsync()
        {
            return await productoRepo.ObtenerProductosStockBajoAsync();
        }

        //TODO: Buscar productos por nombre
        public async Task<List<Producto>> BuscarPorNombreAsync(string nombre)
        {
            return await productoRepo.BuscarPorNombreAsync(nombre);
        }

        //TODO: Obtener todos los productos
        public List<Producto> ObtenerTodos()
        {
            return inventario.Values.ToList();
        }

        //TODO: Metodo protegido para disparar evento
        protected virtual void OnInventarioBajo(InventarioBajoEventArgs e)
        {
            InventarioBajo?.Invoke(this, e);
        }
    }
}
