using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivera_Jorge_FinalPoo
{
    public class Ticket
    {
        public Cliente Cliente { get; set; }
        public Transaccion Transaccion { get; set; }
        public Sucursal Sucursal { get; set; }

        public Ticket(Cliente cliente, Transaccion transaccion, Sucursal sucursal)
        {
            Cliente = cliente;
            Transaccion = transaccion;
            Sucursal = sucursal;
        }

        public void GenerarTicket()
        {
            Console.WriteLine("Detalle del Ticket");
            Console.WriteLine(Cliente.GetDatosCliente());
            Console.WriteLine(Transaccion.GetDatosTransaccion());
            Console.WriteLine(Sucursal.GetDatosSucursal());
        }
    }
}
