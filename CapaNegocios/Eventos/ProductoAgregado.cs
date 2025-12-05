using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios.Entidades;

namespace CapaNegocios.Eventos
{
    //TODO: Clase para manejar eventos relacionados con la adición de productos a una venta
    public class ProductoAgregadoEventArgs : EventArgs
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        //TODO: Constructor para inicializar los datos del evento
        public ProductoAgregadoEventArgs(Producto producto, int cantidad, decimal total)
        {
            Producto = producto;
            Cantidad = cantidad;
            Total = total;
        }
    }
}
