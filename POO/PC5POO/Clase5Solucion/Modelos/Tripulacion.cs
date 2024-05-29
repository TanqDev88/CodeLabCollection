using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Tripulacion : Persona //Pasa a ser abstracta y todo el presonal del avion va a heredar de Tripulaciuon
    {
        public Tripulacion()
        {//Constructor por default

        }

        public Tripulacion(int DNI, String Nombre, string Apellido) : base(DNI, Nombre, Apellido)
        { //Constructor sobrecargado


        }
        public Tripulacion(int DNI, String Nombre, string Apellido, int NroLegajo) : base(DNI, Nombre, Apellido)
        { //Constructor sobrecargado
            this.NroLegajo = NroLegajo;
            System.Console.WriteLine("Hola pasajeros mi nombre es " + this.Nombre);
        }
        protected void Hablar()
        {

        }
        public int NroLegajo { get; set; }

        protected internal void Despedir()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Despedir en tripulacion");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }

    public class Tcp : Tripulacion
    {
        internal void SaludoCordial()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("Este es el saludo internal");
            Console.ForegroundColor = ConsoleColor.White;
            base.Despedir();
        }

    }
    public class Piloto : Tripulacion
    {
        public Piloto()
        {

        }
        public Piloto(string apell, string nomb, int dni, int hv) : base(dni, nomb, apell)
        {
            this.Apellido = apell;
            this.Nombre = nomb;
            this.HorasDeVuelo = hv;
            this.CantVuelos += 1;
        }
        public void SaludarPiloto()
        {
            base.Saludar();
        }
        public void HablarOficial()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Hablar();
            System.Console.WriteLine("Este es el metodo haclar oficial");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public int HorasDeVuelo { get; set; }
        private int CantVuelos { get; set; }
    }
}