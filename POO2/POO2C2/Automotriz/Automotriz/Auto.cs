using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    internal class Auto
    {
        private string marca;
        private string modelo;
        private string color;
        private int año;
        private int velocidad_max;
        private int velocidad;

        //Metodos
        //Constructor de la clase
        public Auto(int velocidad_maxima, string color, string marca, string modelo)
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
        //Sobrecarga
        public void Acelerar(int kms, bool tiene_nitro)
        {
            if (tiene_nitro == true)
            {
                this.Acelerar(kms * 2);
            }
            else
            {
                this.Acelerar(kms);
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
