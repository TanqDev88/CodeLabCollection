using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Agregar esta referencia
using System.Data.SqlClient; //Agregar esta otra referencia

namespace Datos
{
    public class DB_Coneccion
    {//Coneccion
        private SqlConnection Conexion = new SqlConnection("Server=JORGE_PC\\SQLEXPRESS01; DataBase=Laboratorio;Intregrated Security= true");

        //Metodo que abre la coneccion
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }
        //Metodo que cierra la coneccion
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
