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
            ds4.Acelerar(20);
            Console.WriteLine(ds4.Get_velocidad());
            ds4.Acelerar(100);
            Console.WriteLine(ds4.Get_velocidad());
            ds4.Acelerar(80);
            Console.WriteLine(ds4.Get_velocidad());

            Cliente mateo = new Cliente("Mateo", "Sarac", "DU", 123123, 4561233);
            Console.WriteLine(mateo.Obtener_edad());
            Empleado Susana = new Empleado("sunana", "Aguar", "DU", 1274532164);

            //Clase creada desde otro modulo
            //DateTime nacimiento_marcos = new DateTime(1995, 12, 10);
            //Cliente marcos = new Cliente("Marcos", "Chuck", nacimiento_marcos);
            //Console.WriteLine(marcos.Obtener_edad());

        }

        //crear clases

        class Automovil
        {
            private string marca;
            private string modelo;
            private string color;
            private int año;
            private int velocidad_max;
            private int velocidad;

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
                int velocidad_aux = this.velocidad + kms;   //para acceder a los atributos propios de la clase en C# se utiliza la palabra reservada THIS
                if ((kms > 0) && (velocidad_aux <= this.velocidad_max))
                    { this.velocidad = velocidad_aux; }
                else if (velocidad_aux > this.velocidad)
                {
                    this.velocidad = this.velocidad_max;
                }
            }
            public int Get_velocidad()
            {
                return this.velocidad;
            }
            public void Frenar(int kms)
            {
                int velocidad_aux = this.velocidad - kms;
                if (velocidad_aux >= 0)
                {
                    this.velocidad = velocidad_aux;
                }
                else
                {
                    this.velocidad = 0;
                }
            }
        }
    }

}

