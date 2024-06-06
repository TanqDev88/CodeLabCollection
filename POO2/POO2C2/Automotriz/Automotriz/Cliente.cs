using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    public class Cliente
    {
        string nombre;
        string apellido;
        int numero_documento;
        string tipo_documento;

        DateTime fecha_nacimiento;

        public DateTime FechaNacimiento { get; set; }

        //CONSTRUCTOR
        public Cliente(string nombre, string apellido, DateTime fecha_nac)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nac;
        }

        public int Obtener_edad()
        {
            DateTime fecha_actual = DateTime.Now;
            int edad = fecha_actual.Year - this.fecha_nacimiento.Year;
            return edad;
        }
    }
}
