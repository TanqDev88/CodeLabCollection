using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fordKa = new Automovil(123, "vmw", "Camos", "pyton");
            fordKa.Acelerar(410);

            Automovil ds4 = new Automovil(123, "vmw", "Camos", "pyton");
            ds4.Acelerar(320);

        }

        //crear clases

        class Automovil
        {
            string marca;
            string modelo;
            string color;
            int año;
            int velocidad_max;
            int velocidad;

            //Metodos
            //Constructor de la clase
            public Automovil(int velocidad_maxima, string color, string marca, string modelo)
            {
                this.velocidad = 0;
                this.velocidad_max = velocidad_maxima;
                this.color = color;
                this.marca = marca;
                this.año = 2024;
            }

            public void Acelerar(int kms)
            {
                this.velocidad = this.velocidad + kms;   //para acceder a los atributos propios de la clase en C# se utiliza la palabra reservada THIS
            }
        }
    }

}

