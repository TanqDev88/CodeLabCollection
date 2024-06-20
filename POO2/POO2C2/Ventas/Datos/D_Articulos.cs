using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Articulos
    {
        private DB_Coneccion conexion = new DB_Coneccion();
        //vamos a necesitar un qry
        SqlCommand query = new SqlCommand();
        SqlDataReader reader;
        DataTable tabla = new DataTable();
        //Hacer el metodo que devielva la tabla con todos los articulos
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
    //Crea un objeto private y hacemos la instancia de la clase DB_CONEXION 

