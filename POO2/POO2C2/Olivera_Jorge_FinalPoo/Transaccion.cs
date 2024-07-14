using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivera_Jorge_FinalPoo
{
    public class Transaccion
    {
        public decimal Monto { get; set; }
        public string Tipo { get; set; } 
        public string Moneda { get; set; } 
        public DateTime Fecha { get; set; }

        public Transaccion(decimal monto, string tipo, string moneda, DateTime fecha)
        {
            Monto = monto;
            Tipo = tipo;
            Moneda = moneda;
            Fecha = fecha;
        }

        public string GetDatosTransaccion()
        {
            return $"Monto: {Monto} {Moneda}\nTipo de Transacción: {Tipo}\nFecha: {Fecha}";
        }
    }
}
