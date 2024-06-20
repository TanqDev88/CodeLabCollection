using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cliente
    {
        private D_Clientes objeto = new D_Clientes();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Mostrar();
            return tabla;
        }
    }
}
