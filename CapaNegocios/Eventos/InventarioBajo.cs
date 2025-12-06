using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios.Entidades;

namespace CapaNegocios.Eventos
{
    //TODO: Clase para manejar eventos relacionados con inventario bajo
    public class InventarioBajoEventArgs : EventArgs
    {
        public Producto Producto { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }

        //TODO: Constructor para inicializar los datos del evento
        public InventarioBajoEventArgs(Producto producto)
        {
            Producto = producto;
            StockActual = producto.Stock;
            StockMinimo = producto.StockMinimo;
        }
    }
}
