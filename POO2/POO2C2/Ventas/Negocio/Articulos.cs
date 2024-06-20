using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class Articulos
    {
        private D_Articulos objeto = new D_Articulos();
        //Metodo que une la capa de daots y la de front end toma los registros de la tabla de la bd y pasarlo a un data talbe que es lo que necesitar el frontend para mostrar los datos
        public DataTable MostrarArticulos()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Mostrar();
            return tabla;
        }
        //EDsto es todo lo qu es e va a hacer en la capa de negocio

    }
}
