using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class Articulos
    {
        private D_Articulos objeto = new D_Articulos();

        public DataTable MostrarArticulos()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Mostrar();
            return tabla;
        }
    }
}
