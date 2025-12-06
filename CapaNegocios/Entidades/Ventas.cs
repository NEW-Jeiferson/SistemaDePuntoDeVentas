using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Entidades
{
    public class Ventas
    {
        public class Venta
        {
            public int VentaID { get; set; }
            public DateTime Fecha { get; set; } = DateTime.Now;

            public int UsuarioID { get; set; }
            public string Cliente { get; set; }
            public List<ItemVenta> Items { get; set; } = new List<ItemVenta>();

            public string MetodoPago { get; set; }

            public decimal Subtotal => Items.Sum(i => i.Subtotal);
            public decimal ITBIS => Items.Sum(i => i.ITBIS);
            public decimal Descuento { get; set; }
            public decimal Total => Subtotal + ITBIS - Descuento;
        }

    }
}
