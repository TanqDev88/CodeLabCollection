using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos
{
    public class Pasajero : Persona
    {
        public Pasajero()
        {

        }// Caudndo quiero llamar al constructor de pasajero (derivada) lo que tengo que hacer es llamar al ":base" (llama al constructor de la clase base) que el epase los paremetros y se va a encargar de inicializar la clase
        public Pasajero(int dni, string nombm, string apell) : base(dni, nombm, apell)
        {//por que se repiten en el base dni,nomb y apell GPT

        }
        public Pasajero(int dni, string nombm)
        {

        }
        public int Pasaporte { get; set; }

    }
    public class PasajeroVIP : Pasajero
    {
        public int NroViajeroFrecuente { get; set; }

    }
    public class PasajeroNormal : Pasajero
    {

    }
}