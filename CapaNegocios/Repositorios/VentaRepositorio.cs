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
    //TODO: Esta clase es para mapear los datos del reporte de ventas por fecha ya que estuve teniendo problemas si lo hacia directamente con la entidad Ventas
    public class VentaReporteDto
    {
        public int VentaID { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ITBIS { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public string NombreCliente { get; set; }
        public string TipoCliente { get; set; }
    }

    public class VentaRepositorio
    {
        //TODO: Guardar venta completa con sus detalles
        public async Task<int> GuardarVentaAsync(Ventas venta, int? clienteID = null)
        {
            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int ventaId = 0;

                        //TODO: Insertar encabezado de venta CON ClienteID
                        string queryVenta = @"INSERT INTO Ventas 
                        (UsuarioID, ClienteID, Subtotal, ITBIS, Descuento, Total, MetodoPago, Estado, FechaVenta)
                        VALUES (@UsuarioID, @ClienteID, @Subtotal, @ITBIS, @Descuento, @Total, @MetodoPago, @Estado, @FechaVenta);
                        SELECT CAST(SCOPE_IDENTITY() AS INT)";

                        using (var comando = new SqlCommand(queryVenta, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@UsuarioID", venta.UsuarioID);
                            comando.Parameters.AddWithValue("@ClienteID", clienteID.HasValue ? (object)clienteID.Value : DBNull.Value);
                            comando.Parameters.AddWithValue("@Subtotal", venta.Subtotal);
                            comando.Parameters.AddWithValue("@ITBIS", venta.ITBIS);
                            comando.Parameters.AddWithValue("@Descuento", venta.Descuento);
                            comando.Parameters.AddWithValue("@Total", venta.Total);
                            comando.Parameters.AddWithValue("@MetodoPago", venta.MetodoPago);
                            comando.Parameters.AddWithValue("@Estado", "Completada");
                            comando.Parameters.AddWithValue("@FechaVenta", venta.Fecha);

                            ventaId = (int)await comando.ExecuteScalarAsync();
                        }

                        //TODO: Insertar detalles
                        string queryDetalle = @"INSERT INTO DetalleVenta 
                        (VentaID, ProductoID, PrecioVentaUnitario, Cantidad, Subtotal, ITBIS, Total)
                        VALUES (@VentaID, @ProductoID, @PrecioUnitario, @Cantidad, @Subtotal, @ITBIS, @Total)";

                        foreach (var item in venta.Items)
                        {
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

                        transaccion.Commit();
                        return ventaId;
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        //TODO: Obtener ventas por fecha, esto para implementarlo en form reporte de ventas
        public async Task<List<VentaReporteDto>> ObtenerVentasPorFechaAsync(DateTime fecha)
        {
            var ventas = new List<VentaReporteDto>();

            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                //TODO: Consulta para obtener ventas con LEFT JOIN a Clientes
                string query = @"SELECT 
                  v.VentaID,
                  v.FechaVenta,
                  v.MetodoPago,
                  v.Subtotal,
                  v.ITBIS,
                  v.Descuento,
                  v.Total,
                  ISNULL(c.Nombre, 'Cliente General') AS NombreCliente,
                  ISNULL(c.TipoCliente, 'General') AS TipoCliente
                  FROM Ventas v
                  LEFT JOIN Clientes c ON v.ClienteID = c.ClienteID
                  WHERE CAST(v.FechaVenta AS DATE) = CAST(@Fecha AS DATE)
                  AND v.Estado = 'Completada'
                  ORDER BY v.FechaVenta DESC";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", fecha);

                    using (var reader = await comando.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            ventas.Add(new VentaReporteDto
                            {
                                VentaID = reader.GetInt32(0),
                                Fecha = reader.GetDateTime(1),
                                MetodoPago = reader.GetString(2),
                                Subtotal = reader.GetDecimal(3),
                                ITBIS = reader.GetDecimal(4),
                                Descuento = reader.GetDecimal(5),
                                Total = reader.GetDecimal(6),
                                NombreCliente = reader.GetString(7),
                                TipoCliente = reader.GetString(8)
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
