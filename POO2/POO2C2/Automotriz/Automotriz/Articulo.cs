using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    public class Articulo
    {
        private String Nombre;
        private int Codigo;
        private string Descripcion;
        private double Stock;
        private double Precio;

        public Articulo(string nombre, int codigo)
        {
            Nombre = nombre;
            Codigo = codigo;
        }   

        public string GetNombre()
        {
            return this.Nombre;
        }
        public int GetCodigo()
        {
            return this.Codigo;
        }
        public void SetStock(double stock)
        {
            this.Stock = stock;
        }
    }
}
