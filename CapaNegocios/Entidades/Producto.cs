using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Entidades
{
    //TODO: Clase que representa un producto en el sistema
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public decimal Costo { get; set; }

        //TODO: Propiedad calculada que indica si el inventario está bajo
        public bool InventarioBajo => Stock <= StockMinimo;

        //TODO: Constructor vacío
        public Producto() { }

        //TODO: Constructor con parámetros
        public Producto(int id, string codigo, string nombre, decimal precio, int stock, int stockMinimo)
        {
            ProductoID = id;
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            StockMinimo = stockMinimo;
        }
    }
}
