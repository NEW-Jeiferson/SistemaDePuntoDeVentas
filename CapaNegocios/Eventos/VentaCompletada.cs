using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocios.Entidades;

namespace CapaNegocios.Eventos
{
    public class VentaCompletadaEventArgs : EventArgs
    {
        public Ventas Venta { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Cambio => MontoPagado - Venta.Total;

        //TODO: Constructor para inicializar los datos del evento
        public VentaCompletadaEventArgs(Ventas venta, decimal montoPagado)
        {
            Venta = venta;
            MontoPagado = montoPagado;
        }
    }
}
