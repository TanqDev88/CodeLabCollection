using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(){

        }
        public Persona(int DNI, string Nombre)
        {
            this.DNI = DNI;
            this.Nombre = Nombre;
        }

        public Persona(int DNI, string Nombre, string Apellido) : this(DNI, Nombre)//Para reutilizar las propiedades DIN y nombre del otro constructor de la misma clase se utiliza la palabra THIS
        {
            this.Nombre = Apellido;
        }

        public void Saludar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("este es el saludo declarado en persona");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}