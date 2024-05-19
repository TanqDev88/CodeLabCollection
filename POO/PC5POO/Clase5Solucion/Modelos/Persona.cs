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

        public Persona(int DNI, string Nombre)
        {
            this.DNI = DNI;
            this.Nombre = Nombre;
        }

        public void Saludar(){
            Console.ForegroundColor=ConsoleColor.Red
        }

    }
}