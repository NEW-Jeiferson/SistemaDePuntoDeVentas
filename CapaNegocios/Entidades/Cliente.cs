using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Entidades
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string TipoCliente { get; set; } = "General"; //TODO: Valor por defecto, tambien puede ser "A por mayor"
        public string RNC { get; set; }

        //TODO: Porpiedad para calcular el porcentaje de descuento basado en el tipo de cliente
        public decimal PorcentajeDescuento
        {
            get
            {
                //TODO: Si el tipo de cliente es "A por mayor" el cliente tendra un 10% de descuento, de lo contrario 0%
                return TipoCliente == "A por mayor" ? 0.10m : 0.00m; 
            }
        }

        //TODO: Constructor vacio
        public Cliente() { }

        //TODO: Constructor con parametros
        public Cliente(string nombre, string tipoCliente, string rnc = null, string telefono = null)
        {
            Nombre = nombre;
            TipoCliente = tipoCliente;
            RNC = rnc;
            Telefono = telefono;
        }
    }
}
