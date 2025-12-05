using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Exepciones
{
    //TODO: La heredacion exception nos permite crear nuestras propias excepciones personalizadas
    public class MontoInsuficienteException : Exception
    {
        public decimal MontoRecibido { get; set; }
        public decimal MontoRequerido { get; set; }

        //TODO: Constructor de la excepcion personalizada
        public MontoInsuficienteException(decimal recibido, decimal requerido)
            : base($"Monto insuficiente.\nRecibido: RD${recibido:N2}\nRequerido: RD${requerido:N2}")
        {
            MontoRecibido = recibido;
            MontoRequerido = requerido;
        }
    }
}
