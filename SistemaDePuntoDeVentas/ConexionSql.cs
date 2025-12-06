using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public static class SistemaDeConexion
    {
        //TODO: Cadena de conexión a la base de datos
        //TODO: El static permite que la cadena de conexión sea compartida entre todas las instancias de la clase sin usar new
        private static string conexion = "Server=.;Database=SistemaDePuntoDeVentaParaColmado; Integrated Security=true; trustServerCertificate=True;";

        //TODO: Método público que devuelve una conexión lista para usar
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(conexion);
        }
    }
}
