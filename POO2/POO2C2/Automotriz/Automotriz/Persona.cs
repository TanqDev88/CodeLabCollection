using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    public abstract class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDocumento { get; set; }
        public int numeroDocumento { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public Persona(string nombre, string apellido, string tipoDocumento, int numeroDocumento, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int Obtener_edad()
        {
            DateTime fecha_actual = DateTime.Now;
            int edad = fecha_actual.Year - this.fecha_nacimiento.Year;
            return edad;
        }
    }
}
