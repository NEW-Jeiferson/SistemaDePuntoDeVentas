using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Entidades
{
    //TODO: Clase que representa un ítem en una venta
    public class ItemVenta
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public decimal PrecioUnitario => Producto.Precio;

        public decimal Subtotal => PrecioUnitario * Cantidad;

        public decimal ITBIS => Subtotal * 0.18m;

        public decimal Total => Subtotal + ITBIS;
    }
}
