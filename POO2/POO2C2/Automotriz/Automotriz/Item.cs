using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    public class Item
    {
        private string concepto;
        private double cantidad;
        private double valorUnidad; //Precio unitario
        private double valorIva; //% IVA
        private double valorDescuento; //% Descuento


        public Item(string concepto, double cantidad, double valorUnidad, double valorIva, double valorDescuento)
        {
            this.concepto = concepto;
            this.cantidad = cantidad;
            this.valorUnidad = valorUnidad;
            this.valorIva = valorIva;
            this.valorDescuento = valorDescuento;
        }

        public string GetConcepto()
        {
            return this.concepto.ToString();
        }

        public string GetCantidad()
        {
            return this.cantidad.ToString();
        }
    }
}
