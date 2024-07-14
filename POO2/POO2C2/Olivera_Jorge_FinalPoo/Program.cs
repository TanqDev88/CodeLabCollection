using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Olivera_Jorge_FinalPoo
{
    internal class Program
    {
        static void Main()
        {

            Cliente cliente = new Cliente("Susana", "Herrera", "24155210", "Lavalle 1250", "Diamante", "Entre Ríos", "3105", 10544);

            Transaccion transaccion = new Transaccion(15000, "retiro", "pesos", new DateTime(DateTime.Now.Year, 6, 20));

            Sucursal sucursal = new Sucursal(1670, "Gral. Dr. Pascual Echagüe 350", "Diamante", "Entre Ríos", "3105");

            Ticket ticket = new Ticket(cliente, transaccion, sucursal);
            ticket.GenerarTicket();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
