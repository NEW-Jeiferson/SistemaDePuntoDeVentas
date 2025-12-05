using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Exepciones
{
    //TODO: La heredacion exception nos permite crear nuestras propias excepciones personalizadas
    public class ProductoAgotadoException : Exception
    {
        public string CodigoProducto { get; set; }
        public int CantidadSolicitada { get; set; }
        public int StockDisponible { get; set; }

        //TODO: Constructor de la excepcion personalizada
        public ProductoAgotadoException(string codigo, int solicitada, int disponible)
            : base($"Producto '{codigo}' agotado.\nSolicitado: {solicitada}\nDisponible: {disponible}")
        {
            CodigoProducto = codigo;
            CantidadSolicitada = solicitada;
            StockDisponible = disponible;
        }
    }
}
