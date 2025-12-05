using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Microsoft.Data.SqlClient;

namespace CapaNegocios.Login
{
   public class LoginNegocio
   {
        public bool ValidarLogin(string usuario, string contrasena)
        {
            using (SqlConnection conn = SistemaDeConexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"SELECT COUNT(*)
                                 FROM Usuarios
                                 WHERE NombreUsuario = @admin
                                   AND Contrasena = @123
                                   AND Activo = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@admin", usuario);
                    cmd.Parameters.AddWithValue("@123", contrasena);

                    int count = (int)cmd.ExecuteScalar();

                    return count == 1;
                }
            }
        }

   }
}
