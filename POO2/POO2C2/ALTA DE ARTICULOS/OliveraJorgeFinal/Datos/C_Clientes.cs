using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class D_Clientes
    {
        private DbConexion conexion = new DbConexion();
        SqlDataReader reader;
        DataTable tabla = new DataTable();
        SqlCommand query = new SqlCommand();

        public DataTable Mostrar()
        {
            query.Connection = conexion.AbrirConexion();
            query.CommandText = "Select * from Clientes";
            reader = query.ExecuteReader();
            tabla.Load(reader);
            conexion.CerrarConexion();
            return tabla;
        }

    }
}
