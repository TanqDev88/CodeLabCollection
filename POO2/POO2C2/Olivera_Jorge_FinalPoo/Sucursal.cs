using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivera_Jorge_FinalPoo
{
    public class Sucursal
    {
        public int Numero { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }

        public Sucursal(int numero, string direccion, string localidad, string provincia, string codigoPostal)
        {
            Numero = numero;
            Direccion = direccion;
            Localidad = localidad;
            Provincia = provincia;
            CodigoPostal = codigoPostal;
        }

        public string GetDatosSucursal()
        {
            return $"Sucursal: {Numero}\nDirección de la Sucursal: {Direccion}, {Localidad}, {Provincia}, CP {CodigoPostal}";
        }
    }
}
