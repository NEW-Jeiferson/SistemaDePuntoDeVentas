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
    public class VentaRepositorio
    {
        //TODO: Guardar venta completa con sus detalles
        public async Task<int> GuardarVentaAsync(Ventas venta)
        {
            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                //TODO: Iniciar transacción para garantizar integridad
                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int ventaId = 0;

                        //TODO: Insertar encabezado de venta
                        string queryVenta = @"INSERT INTO Ventas 
                            (UsuarioID, ClienteID, Subtotal, ITBIS, Descuento, Total, MetodoPago, Estado, FechaVenta)
                            VALUES (@UsuarioID, @ClienteID, @Subtotal, @ITBIS, @Descuento, @Total, @MetodoPago, @Estado, @FechaVenta);
                            SELECT CAST(SCOPE_IDENTITY() AS INT)";

                        //TODO: Obtener el ID generado de la venta
                        using (var comando = new SqlCommand(queryVenta, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@UsuarioID", venta.UsuarioID);
                            comando.Parameters.AddWithValue("@ClienteID", (object)venta.Cliente ?? DBNull.Value);
                            comando.Parameters.AddWithValue("@Subtotal", venta.Subtotal);
                            comando.Parameters.AddWithValue("@ITBIS", venta.ITBIS);
                            comando.Parameters.AddWithValue("@Descuento", venta.Descuento);
                            comando.Parameters.AddWithValue("@Total", venta.Total);
                            comando.Parameters.AddWithValue("@MetodoPago", venta.MetodoPago);
                            comando.Parameters.AddWithValue("@Estado", "Completada");
                            comando.Parameters.AddWithValue("@FechaVenta", venta.Fecha);

                            ventaId = (int)await comando.ExecuteScalarAsync();
                        }

                        //TODO: Insertar detalles de venta
                        string queryDetalle = @"INSERT INTO DetalleVenta 
                            (VentaID, ProductoID, PrecioVentaUnitario, Cantidad, Subtotal, ITBIS, Total)
                            VALUES (@VentaID, @ProductoID, @PrecioUnitario, @Cantidad, @Subtotal, @ITBIS, @Total)";

                        //TODO: Foreach para cada item en la venta
                        foreach (var item in venta.Items)
                        {
                            //TODO: Insertar cada detalle de venta
                            using (var comando = new SqlCommand(queryDetalle, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@VentaID", ventaId);
                                comando.Parameters.AddWithValue("@ProductoID", item.Producto.ProductoID);
                                comando.Parameters.AddWithValue("@PrecioUnitario", item.PrecioUnitario);
                                comando.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                                comando.Parameters.AddWithValue("@Subtotal", item.Subtotal);
                                comando.Parameters.AddWithValue("@ITBIS", item.ITBIS);
                                comando.Parameters.AddWithValue("@Total", item.Total);

                                await comando.ExecuteNonQueryAsync();
                            }
                        }

                        //TODO: Confirmar transacción
                        transaccion.Commit();
                        return ventaId;
                    }
                    catch
                    {
                        //TODO: Revertir cambios en caso de error
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        //TODO: Obtener ventas por fecha, esto para implementarlo en form reporte de ventas
        public async Task<List<Ventas>> ObtenerVentasPorFechaAsync(DateTime fecha)
        {
            var ventas = new List<Ventas>();

            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"SELECT VentaID, UsuarioID, Subtotal, ITBIS, 
                                Descuento, Total, MetodoPago, FechaVenta
                                FROM Ventas
                                WHERE CAST(FechaVenta AS DATE) = CAST(@Fecha AS DATE)
                                ORDER BY FechaVenta DESC";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", fecha);

                    using (var reader = await comando.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            ventas.Add(new Ventas
                            {
                                VentaID = reader.GetInt32(0),
                                UsuarioID = reader.GetInt32(1),
                                Descuento = reader.GetDecimal(4),
                                MetodoPago = reader.GetString(6),
                                Fecha = reader.GetDateTime(7),
                                Items = new List<ItemVenta>()
                            });
                        }
                    }
                }
            }

            return ventas;
        }

        //TODO: Obtener estadísticas del día de las ventas
        public async Task<Dictionary<string, object>> ObtenerEstadisticasDelDiaAsync(DateTime fecha)
        {
            var estadisticas = new Dictionary<string, object>();

            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"SELECT 
                    COUNT(*) AS CantidadVentas,
                    ISNULL(SUM(Subtotal), 0) AS SubtotalGeneral,
                    ISNULL(SUM(ITBIS), 0) AS ITBISGeneral,
                    ISNULL(SUM(Total), 0) AS TotalGeneral
                    FROM Ventas
                    WHERE CAST(FechaVenta AS DATE) = CAST(@Fecha AS DATE)
                    AND Estado = 'Completada'";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", fecha);

                    using (var reader = await comando.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            estadisticas["CantidadVentas"] = reader.GetInt32(0);
                            estadisticas["SubtotalGeneral"] = reader.GetDecimal(1);
                            estadisticas["ITBISGeneral"] = reader.GetDecimal(2);
                            estadisticas["TotalGeneral"] = reader.GetDecimal(3);
                        }
                    }
                }
            }

            return estadisticas;
        }
    }
}
