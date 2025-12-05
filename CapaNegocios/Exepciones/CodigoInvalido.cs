using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Exepciones
{
    //TODO: La heredacion exception nos permite crear nuestras propias excepciones personalizadas
    public class CodigoInvalidoException : Exception
    {
        public string Codigo { get; set; }

        public CodigoInvalidoException(string codigo)
            : base($"El codigo '{codigo}' no existe en el inventario")
        {
            Codigo = codigo;
        }
    }
}
