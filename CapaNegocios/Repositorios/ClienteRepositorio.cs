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
    public class ClienteRepositorio
    {
        //TODO: Buscar cliente por RNC de forma asincrona
        public async Task<Cliente> BuscarPorRNCAsync(string rnc)
        {
            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"SELECT ClienteID, Nombre, Telefono, TipoCliente, RNC 
                                FROM Clientes WHERE RNC = @RNC";

                //TODO: Usar parametros para evitar SQL Injection
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@RNC", rnc);

                    using (var reader = await comando.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new Cliente
                            {
                                ClienteID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Telefono = reader.IsDBNull(2) ? null : reader.GetString(2),
                                TipoCliente = reader.GetString(3),
                                RNC = reader.IsDBNull(4) ? null : reader.GetString(4)
                            };
                        }
                    }
                }
            }

            return null;
        }

        //TODO: Guardar nuevo cliente
        public async Task<int> GuardarClienteAsync(Cliente cliente)
        {
            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"INSERT INTO Clientes (Nombre, Telefono, TipoCliente, RNC)
                                VALUES (@Nombre, @Telefono, @TipoCliente, @RNC);
                                SELECT CAST(SCOPE_IDENTITY() AS INT)";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@Telefono", (object)cliente.Telefono ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@TipoCliente", cliente.TipoCliente);
                    comando.Parameters.AddWithValue("@RNC", (object)cliente.RNC ?? DBNull.Value);

                    return (int)await comando.ExecuteScalarAsync();
                }
            }
        }

        //TODO: Obtener todos los clientes
        public async Task<List<Cliente>> ObtenerTodosAsync()
        {
            var clientes = new List<Cliente>();

            using (var conexion = SistemaDeConexion.ObtenerConexion())
            {
                await conexion.OpenAsync();

                string query = @"SELECT ClienteID, Nombre, Telefono, TipoCliente, RNC 
                                FROM Clientes ORDER BY Nombre";

                using (var comando = new SqlCommand(query, conexion))
                using (var reader = await comando.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        clientes.Add(new Cliente
                        {
                            ClienteID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Telefono = reader.IsDBNull(2) ? null : reader.GetString(2),
                            TipoCliente = reader.GetString(3),
                            RNC = reader.IsDBNull(4) ? null : reader.GetString(4)
                        });
                    }
                }
            }

            return clientes;
        }
    }
}
