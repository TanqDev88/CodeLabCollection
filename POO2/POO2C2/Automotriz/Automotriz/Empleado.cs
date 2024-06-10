using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    public class Empleado: Persona
    {
        public Empleado(string apellido, string nombre, string tipoDocumento, int numeroDocumento) : base(apellido, nombre, tipoDocumento) { }
    }
}
