using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    public class Item
    {
        private Articulo articulo;
        private double cantidad;
        private double valorUnidad; //Precio unitario
        private double valorIva; //% IVA
        private double valorDescuento; //% Descuento


        public Item(Articulo articulo, double cantidad, double valorUnidad, double valorIva, double valorDescuento)
        {
            this.articulo = articulo;
            this.cantidad = cantidad;
            this.valorUnidad = valorUnidad;
            this.valorIva = valorIva;
            this.valorDescuento = valorDescuento;
        }

        public string GetArticulo()
        {
            return this.articulo.GetNombre() + " - " + this.articulo.GetCodigo().ToString();
        }

        public string GetCantidad()
        {
            return this.cantidad.ToString();
        }
    }
}


// 