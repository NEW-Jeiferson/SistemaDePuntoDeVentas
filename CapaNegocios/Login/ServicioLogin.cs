using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocios.Entidades;
using Microsoft.Data.SqlClient;

namespace CapaNegocios.Login
{
    //TODO: Logica de negocio para el login
    public class LoginNegocio
    {
        //TODO: Metodo para validar el login
        public Usuario ValidarLogin(string nombreUsuario, string contrasena)
        {
            using (SqlConnection conn = SistemaDeConexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"SELECT UsuarioID, NombreUsuario, Rol
                                FROM Usuarios
                                WHERE NombreUsuario = @usuario
                                  AND Contrasena = @contrasena
                                  AND Activo = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                UsuarioID = reader.GetInt32(0),
                                NombreUsuario = reader.GetString(1),
                                Rol = reader.GetString(2)
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
