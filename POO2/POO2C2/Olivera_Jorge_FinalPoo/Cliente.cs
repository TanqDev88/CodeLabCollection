using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivera_Jorge_FinalPoo
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }
        public int NumeroCliente { get; set; }

        public Cliente(string nombre, string apellido, string dni, string direccion, string localidad, string provincia, string codigoPostal, int numeroCliente)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Direccion = direccion;
            Localidad = localidad;
            Provincia = provincia;
            CodigoPostal = codigoPostal;
            NumeroCliente = numeroCliente;
        }

        public string GetDatosCliente()
        {
            return $"Cliente: {Nombre} {Apellido}\nNúmero de Cliente: {NumeroCliente}";
        }
    }
}
