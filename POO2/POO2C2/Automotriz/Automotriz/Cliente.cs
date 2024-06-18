using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    public class Cliente:Persona
    {
        private string tipoIva;
        private int numeroCuit;   


        //CONSTRUCTOR
        public Cliente(string nombre, string apellido, string tipoDocumento, int numeroDocumento, int numeroCuit) : base (apellido, nombre, tipoDocumento, numeroDocumento)
        {
            this.numeroCuit = numeroCuit;
            this.tipoIva = "CF";
        }
        //Sobrecarga
        public Cliente(string nombre, string apellido, string tipoDocumento, string numeroDocumento, int numeroCuit) : base (nombre, apellido, tipoDocumento, numeroDocumento)
        {
            this.numeroCuit = numeroCuit;
        }

        public void GetNombreCompleto
        {
            this.Nom
        }


    }
}
