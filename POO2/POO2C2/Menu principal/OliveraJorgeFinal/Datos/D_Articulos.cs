using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Articulos
    {
        private DbConexion conexion = new DbConexion();
        //vamos a necesitar un qry
        SqlCommand query = new SqlCommand();
        SqlDataReader reader;
        DataTable tabla = new DataTable();
        //Hacer el metodo que retorne la tabla con todos los articulos
        public DataTable Mostrar()
        {
            query.Connection = conexion.AbrirConexion();
            query.CommandText = "Select * from articulos";
            reader = query.ExecuteReader();
            tabla.Load(reader);
            return tabla;
        }
        //Crear articulos
        public void Insertar(string nombre, double precio, int stock)
        {
            query.Connection = conexion.AbrirConexion();
            query.CommandText = "SET IDENTITY_INSERT Articulos OFF; insert into Articulos values('" + nombre + "', " + precio + ", " + stock + ");";
            query.ExecuteNonQuery();
        }
    }
}
