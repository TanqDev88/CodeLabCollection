using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Automotriz
{
    public abstract class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDocumento { get; set; }
        public int numeroDocumento { get; set; }
        public string numDocumento { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public Persona(string nombre, string apellido, string tipoDocumento, int numeroDocumento, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.fechaNacimiento = fechaNacimiento;
            this.numDocumento = numDocumento;
        }

        //Sobrecarga cambiarndo la cantidad de parametros (se puede hacer un constructor con la misma cantidad de parametros pero no exactamente igual)
        public Persona(string nombre, string apellido, string tipoDocumento, int numeroDocumento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
        }
        //sobrecarfo con igual cnadidfa de arcumentos paero distingto tipo

        public Persona(string nombre, string apellido, string tipoDocumento, string numDocumento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoDocumento  = tipoDocumento;
            this.numDocumento = numDocumento;
        }
        public int Obtener_edad()
        {
            DateTime fecha_actual = DateTime.Now;
            int edad = fecha_actual.Year - this.fecha_nacimiento.Year;
            return edad;
        }
    }
}
