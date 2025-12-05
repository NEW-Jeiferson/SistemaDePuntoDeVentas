using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Servicios
{
    //TODO: Clase de metodos de extension para el tipo decimal
    public static class DecimalExtensions
    {
        public static string AFormatoDominicano(this decimal precio)
        {
            return $"RD${precio:N2}";
        }

        public static string APesosDominicanos(this decimal precio)
        {
            return string.Format("RD$ {0:###,###,##0.00}", precio);
        }
    }
}
