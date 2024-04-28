var emp1=new Empleado(33333,"Luciano","Luciano",44444);
emp1.Antiguedad=1;
emp1.Hijos=1;
var emp2=new Empleado(44444,"Pepe","Galarraga",44444);
emp2.Antiguedad=10;
emp2.Hijos=0;
var emp3=new Empleado(55555,"Lucas","Perez",1500);
emp3.Antiguedad=0;
emp3.Hijos=2;
var emp4=new Empleado(66666,"Martin","Luc",1200);
emp4.Antiguedad=2;
emp4.Hijos=2;
var emp5=new Empleado(66666,"Romana","Marintes",1000);
emp5.Antiguedad=6;
emp5.Hijos=3;

var listaEmpelados=new List<Empleado>();
listaEmpelados.Add(emp1);
listaEmpelados.Add(emp2);
listaEmpelados.Add(emp3);
listaEmpelados.Add(emp4);
listaEmpelados.Add(emp5);

var sueldosTotales=0;
foreach(var emp in listaEmpelados){
    var sueldoemp=emp.CalcularSueldo();
    System.Console.WriteLine(emp.NombreCompleto + " " +  emp.Cuil + " " + sueldoemp);
    sueldosTotales+=sueldoemp;
}
System.Console.WriteLine(sueldosTotales);

public class Empleado
{
    public Empleado(int cuil, string nombre, string apellido, int sueldo)
    {
        Cuil = cuil;
        Nombre = nombre;
        Apellido = apellido;
        SueldoBasico = sueldo;
    }
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public int SueldoBasico { get; set; }
    public int Cuil { get; set; }
    public int Hijos { get; set; }
    public int Antiguedad { get; set; }
    public string NombreCompleto {
        get {
            return Nombre + " " + Apellido;
        }
    }

    public int CalcularSueldo()
    {
        var sueldo = SueldoBasico + (Hijos * 100) + (Antiguedad * 50);
        return sueldo;
    }
}

// Por que implelmentar un constructor? Por que la apolicacion debe tener los datoa de nombre CUIL y sueldo basico de manera obligattoria y el construtor si bien lo utilizamos para crear instancias de una clase e inicializarla 
// tambien es restrictivo don de se agreguen atributos ahi ya se limita la instanciacion de una clase a la existencias de dichos  atrivutos