using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Modelos
{
    public class Avion
    {
        private Piloto MiPiloto;
        private List<Pasajero> ListaPasajeros=new List<Pasajero>();
        private List<Tcp> Tripulantes=new List<Tcp>();
        public void Abordar(Persona pers)
        {
            if(pers.GetType() == typeof(Pasajero))
            {
                ListaPasajeros.Add((Pasajero)pers);
            }
            else if(pers is Tripulacion){
                if(pers.GetType()==typeof(Tcp))
                Tripulantes.Add((Tcp)pers);
                else
                
        MiPiloto = (Piloto)pers;
                
            }
        }


        public void Reporte()
        {

        }
    }
}