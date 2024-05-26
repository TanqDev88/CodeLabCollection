using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Tripulacion : Persona //Pasa a ser abstracta y todo el presonal del avion va a heredar de Tripulaciuon
    {
        public int NroLegajo { get; set; }

    }

        public class Tcp : Persona
    {
        
    }
    public class Piloto : Persona
    {
        public Piloto()
        {

        }
        public Piloto(string apell, string nomb, int dni, int hv) : base(dni, nomb, apell)
        {
            this.Apellido = apell;
            this.Nombre = nomb;
            this.HorasDeVuelo = hv;
        }
        public void SaludarPiloto()
        {
            base.Saludar();
        }

        public int HorasDeVuelo { get; set; }
    }
}