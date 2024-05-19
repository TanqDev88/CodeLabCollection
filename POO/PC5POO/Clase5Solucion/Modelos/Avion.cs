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
        public List<Pasajero> Pasajeros;
        public List<Tcp> Tripulantes;

        //Creando un metodo para cada objeto del tipo persona (tipo creado mediante la abstraccion) o crear un solo metodo del tipo mas de dato mas primitivo
        // public void Abordar(Pasajero pasaj)
        // {

        // }
        // public void Abordar(Piloto piloto)
        // {

        // }
        // public void Abordar(Tcp tripulante)
        // {

        // }
        public void Abordar(Persona persona)
        {
            System.Console.WriteLine(persona.GetType().ToString());
            if(persona.GetType()== typeof(Pasajero)){
                System.Console.WriteLine("Soy del tipo pasajero");
            }
            else if(persona.GetType(==typeof(Piloto))){
                
            }
        }


        public void Reporte()
        {

        }
    }
}