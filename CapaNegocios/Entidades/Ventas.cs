using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Entidades
{
    public class Ventas
    {
        public int VentaID { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int UsuarioID { get; set; }

        //TODO: Cambiar a string para almacenar el nombre o mantener compatibilidad con BD
        public string Cliente { get; set; }

        public List<ItemVenta> Items { get; set; } = new List<ItemVenta>();
        public string MetodoPago { get; set; } = "Efectivo";

        //TODO: Propiedades calculadas usando LINQ
        public decimal Subtotal => Items.Sum(i => i.Subtotal);
        public decimal ITBIS => Items.Sum(i => i.ITBIS);
        public decimal Descuento { get; set; }
        public decimal Total => Subtotal + ITBIS - Descuento;

        //TODO: Propiedad para contar items
        public int CantidadItems => Items.Count;

        //TODO: Constructor vacio
        public Ventas() { }

        //TODO: Metodo para limpiar el carrito
        public void LimpiarCarrito()
        {
            Items.Clear();
            Descuento = 0;
        }
    }

}
