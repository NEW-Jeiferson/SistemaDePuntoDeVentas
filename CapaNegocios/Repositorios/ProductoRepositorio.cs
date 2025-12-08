using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocios.Entidades;
using Microsoft.Data.SqlClient;

namespace CapaNegocios.Repositorios
{
    public class ProductoRepositorio
    {
        //TODO: Obtener todos los productos de forma asíncrona
        public async Task<List<Producto>> ObtenerTodosAsync()
        {
            var productos = new List<Producto>();

            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"SELECT ProductoID, Codigo, Nombre, Precio, Stock, 
                                StockMinimo, Costo FROM Productos ORDER BY Nombre";

                using (var comando = new SqlCommand(query, conexion))
                using (var reader = await comando.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        productos.Add(new Producto
                        {
                            ProductoID = reader.GetInt32(0),
                            Codigo = reader.GetString(1),
                            Nombre = reader.GetString(2),
                            Precio = reader.GetDecimal(3),
                            Stock = reader.GetInt32(4),
                            StockMinimo = reader.GetInt32(5),
                            Costo = reader.GetDecimal(6)
                        });
                    }
                }
            }

            return productos;
        }

        //TODO: Buscar producto por código de forma asíncrona
        public async Task<Producto> BuscarPorCodigoAsync(string codigo)
        {
            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"SELECT ProductoID, Codigo, Nombre, Precio, Stock, 
                                StockMinimo, Costo FROM Productos WHERE Codigo = @Codigo";

                //TODO: Usar parámetros para evitar SQL Injection
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Codigo", codigo);

                    using (var reader = await comando.ExecuteReaderAsync())
                    {
                        //TODO: Si se encuentra el producto, retornarlo
                        if (await reader.ReadAsync())
                        {
                            return new Producto
                            {
                                ProductoID = reader.GetInt32(0),
                                Codigo = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                Precio = reader.GetDecimal(3),
                                Stock = reader.GetInt32(4),
                                StockMinimo = reader.GetInt32(5),
                                Costo = reader.GetDecimal(6)
                            };
                        }
                    }
                }
            }

            return null;
        }

        //TODO: Buscar productos por nombre
        public async Task<List<Producto>> BuscarPorNombreAsync(string nombre)
        {
            var productos = new List<Producto>();

            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"SELECT ProductoID, Codigo, Nombre, Precio, Stock, 
                                StockMinimo, Costo FROM Productos 
                                WHERE Nombre LIKE @Nombre 
                                ORDER BY Nombre";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", $"%{nombre}%");

                    using (var reader = await comando.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            productos.Add(new Producto
                            {
                                ProductoID = reader.GetInt32(0),
                                Codigo = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                Precio = reader.GetDecimal(3),
                                Stock = reader.GetInt32(4),
                                StockMinimo = reader.GetInt32(5),
                                Costo = reader.GetDecimal(6)
                            });
                        }
                    }
                }
            }

            return productos;
        }

        //TODO: Actualizar stock después de una venta
        public async Task<bool> ActualizarStockAsync(int productoId, int cantidadVendida)
        {
            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"UPDATE Productos 
                                SET Stock = Stock - @Cantidad 
                                WHERE ProductoID = @ProductoID AND Stock >= @Cantidad";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@ProductoID", productoId);
                    comando.Parameters.AddWithValue("@Cantidad", cantidadVendida);

                    int filasAfectadas = await comando.ExecuteNonQueryAsync();
                    return filasAfectadas > 0;
                }
            }
        }

        //TODO: Restaurar stock en caso de devolución esto para rollback en algun caso de error 
        public async Task<bool> RestaurarStockAsync(int productoId, int cantidad)
        {
            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"UPDATE Productos 
                                SET Stock = Stock + @Cantidad 
                                WHERE ProductoID = @ProductoID";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@ProductoID", productoId);
                    comando.Parameters.AddWithValue("@Cantidad", cantidad);

                    int filasAfectadas = await comando.ExecuteNonQueryAsync();
                    return filasAfectadas > 0;
                }
            }
        }

        //TODO: Obtener productos con stock bajo
        public async Task<List<Producto>> ObtenerProductosStockBajoAsync()
        {
            var productos = new List<Producto>();

            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"SELECT ProductoID, Codigo, Nombre, Precio, Stock, 
                                StockMinimo, Costo FROM Productos 
                                WHERE Stock <= StockMinimo 
                                ORDER BY Stock ASC";

                using (var comando = new SqlCommand(query, conexion))
                using (var reader = await comando.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        productos.Add(new Producto
                        {
                            ProductoID = reader.GetInt32(0),
                            Codigo = reader.GetString(1),
                            Nombre = reader.GetString(2),
                            Precio = reader.GetDecimal(3),
                            Stock = reader.GetInt32(4),
                            StockMinimo = reader.GetInt32(5),
                            Costo = reader.GetDecimal(6)
                        });
                    }
                }
            }

            return productos;
        }
    }
}
