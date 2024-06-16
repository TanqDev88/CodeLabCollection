using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente mateo = new Cliente("Mateo", "Sarac", "DU", 123123, 4561233);
            Console.WriteLine(mateo.Obtener_edad());
            Empleado Susana = new Empleado("sunana", "Aguar", "DU", 1274532164);
            DateTime fechaFactura01 = new DateTime(2023, 10, 12);
            Movimiento Factura01 = new Movimiento(1001, fechaFactura01, mateo);//Ejemplo de agregacion no se puede crear la instancia de Movimiento si no tengo creado el cliente
            //Clase creada desde otro modulo
            //DateTime nacimiento_marcos = new DateTime(1995, 12, 10);
            //Cliente marcos = new Cliente("Marcos", "Chuck", nacimiento_marcos);
            //Console.WriteLine(marcos.Obtener_edad());
            Folio folioNro01 = new Folio(1);
            Factura01.SetFolio(folioNro01); //Ejemplo de asociacion

        }

        //crear clases  Movimiento depende de que exista un objeto cliente para que esta pueda existir

        
    }

}

