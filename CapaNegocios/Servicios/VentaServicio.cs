using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios.Entidades;
using CapaNegocios.Eventos;
using CapaNegocios.Exepciones;
using CapaNegocios.Repositorios;

namespace CapaNegocios.Servicios
{
    public class VentaService
    {
        //TODO: Aqui va la implementacion del servicio de ventas
        private readonly VentaRepositorio ventaRepo;
        private readonly InventarioService inventarioService;

        //TODO: Queue para ventas pendientes
        private Queue<Ventas> ventasPendientes;

        //TODO: Eventos para notificaciones
        public event EventHandler<ProductoAgregadoEventArgs> ProductoAgregado;
        public event EventHandler<VentaCompletadaEventArgs> VentaCompletada;

        //TODO: DELEGADO Func para calcular descuentos
        public Func<decimal, Cliente, decimal> CalcularDescuento { get; set; }

        //TODO: Constructor para inyectar dependencias
        public VentaService(InventarioService inventarioService)
        {
            ventaRepo = new VentaRepositorio();
            this.inventarioService = inventarioService;
            ventasPendientes = new Queue<Ventas>();

            //TODO: Inicializar delegado con logica de descuento por defecto
            CalcularDescuento = (subtotal, cliente) =>
            {
                if (cliente == null) return 0;
                return subtotal * cliente.PorcentajeDescuento;
            };
        }

        //TODO: Agregar producto al carrito
        public async Task AgregarProductoAsync(Ventas venta, string codigo, int cantidad)
        {
            //TODO: Buscar producto de forma asincrona
            var producto = await inventarioService.BuscarPorCodigoAsync(codigo);

            //TODO: Validar stock disponible
            inventarioService.ValidarStock(producto, cantidad);

            //TODO: Verificar si el producto ya esta en el carrito
            var itemExistente = venta.Items.FirstOrDefault(i => i.Producto.Codigo == codigo);

            if (itemExistente != null)
            {
                //TODO: Si ya existe se aumenta la cantidad
                itemExistente.Cantidad += cantidad;
            }
            else
            {
                //TODO: Crear nuevo item
                var nuevoItem = new ItemVenta
                {
                    Producto = producto,
                    Cantidad = cantidad
                };

                venta.Items.Add(nuevoItem);
            }

            //TODO: Disparar evento ProductoAgregado para que la UI se actualice
            OnProductoAgregado(new ProductoAgregadoEventArgs(producto, cantidad, venta.Total));
        }

        //TODO: Procesar venta con Tty-Catc, Finally y Rollback
        public async Task<int> ProcesarVentaAsync(Ventas venta, decimal montoPagado, Cliente cliente = null)
        {
            //TODO: Calcular descuento usando el delegado Func
            if (cliente != null)
            {
                venta.Descuento = CalcularDescuento(venta.Subtotal, cliente);
            }

            //TODO: Validar que el monto sea suficiente
            if (montoPagado < venta.Total)
            {
                throw new MontoInsuficienteException(montoPagado, venta.Total);
            }

            //TODO: Lista para trackear cambios, para rollback en caso de error
            var productosActualizados = new List<(int ProductoID, int Cantidad)>();

            try
            {
                //TODO: Actualizar stock de cada producto
                foreach (var item in venta.Items)
                {
                    await inventarioService.ActualizarStockAsync(
                        item.Producto.ProductoID,
                        item.Cantidad
                    );

                    productosActualizados.Add((item.Producto.ProductoID, item.Cantidad));
                }

                //TODO: Guardar venta en base de datos
                int ventaId = await ventaRepo.GuardarVentaAsync(venta);
                venta.VentaID = ventaId;

                //TODO: Disparar evento VentaCompletada
                OnVentaCompletada(new VentaCompletadaEventArgs(venta, montoPagado));

                return ventaId;
            }
            catch (Exception)
            {
                //TODO: Restaurar stock de todos los productos actualizados
                foreach (var (productoId, cantidad) in productosActualizados)
                {
                    await inventarioService.RestaurarStockAsync(productoId, cantidad);
                }

                //TODO: Re-lanzar la excepción
                throw;
            }
            finally
            {
                //TODO: Limpiar recursos, etc
            }
        }

        //TODO: Encolar venta pendiente, aqui hacemos uso del Queue
        public void EncolarVentaPendiente(Ventas venta)
        {
            ventasPendientes.Enqueue(venta);
        }

        //TODO: Procesar siguiente venta pendiente
        public Ventas ObtenerSiguienteVentaPendiente()
        {
            return ventasPendientes.Count > 0 ? ventasPendientes.Dequeue() : null;
        }

        //TODO: Validar tarjeta de credito de forma asíncrona
        public async Task<bool> ValidarTarjetaAsync(string numeroTarjeta)
        {
            //TODO: Simular validacion externa asincrona para cumplir el requisito
            await Task.Delay(1000);

            //TODO: Validacion simple
            return numeroTarjeta.Length >= 16;
        }

        //TODO: Obtener ventas del día
        public async Task<List<Ventas>> ObtenerVentasDelDiaAsync(DateTime fecha)
        {
            return await ventaRepo.ObtenerVentasPorFechaAsync(fecha);
        }

        //TODO: Obtener estadísticas con PLINQ
        public async Task<Dictionary<string, object>> ObtenerEstadisticasDelDiaAsync(DateTime fecha)
        {
            var estadisticas = await ventaRepo.ObtenerEstadisticasDelDiaAsync(fecha);
            return estadisticas;
        }

        //TODO: Generar reporte usando PLINQ para calculos paralelos
        public async Task<Dictionary<string, decimal>> GenerarReporteParaleloAsync(DateTime fecha)
        {
            var ventas = await ObtenerVentasDelDiaAsync(fecha);

            //TODO: Usar PLINQ para calculos paralelos
            var totalVentas = ventas.AsParallel().Sum(v => v.Total);
            var totalITBIS = ventas.AsParallel().Sum(v => v.ITBIS);
            var totalSubtotal = ventas.AsParallel().Sum(v => v.Subtotal);
            var ventasEfectivo = ventas.AsParallel()
                .Where(v => v.MetodoPago == "Efectivo")
                .Sum(v => v.Total);

            return new Dictionary<string, decimal>
            {
                ["TotalVentas"] = totalVentas,
                ["TotalITBIS"] = totalITBIS,
                ["TotalSubtotal"] = totalSubtotal,
                ["VentasEfectivo"] = ventasEfectivo
            };
        }

        //TODO: Metodos para disparar eventos
        protected virtual void OnProductoAgregado(ProductoAgregadoEventArgs e)
        {
            ProductoAgregado?.Invoke(this, e);
        }

        protected virtual void OnVentaCompletada(VentaCompletadaEventArgs e)
        {
            VentaCompletada?.Invoke(this, e);
        }
    }
}
