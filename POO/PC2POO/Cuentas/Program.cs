// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var cuenta1 = new Cuenta(11111, "Franco Buenaventura");
Console.WriteLine(cuenta1.Titular);
System.Console.WriteLine(cuenta1.Saldo);
cuenta1.Depositar(15);
cuenta1.ImprimirConsultaSaldo();


public class Cuenta
{
    //CONSTRUCTOR 1 = CONSTRUCTOR POR DEFAULT: Crear una instancia de la clase Cuenta sin proporcionar ningún valor inicial.
    public Cuenta()
    {

    }
    //CONSTRUCTOR 2 = CONSTRUCTOR CON PARAMETROS: Crea una instancia de la clase Cuenta y asignar valores iniciales al número de cuenta y al titular de la cuenta
    public Cuenta(int nro)
    {
        Nro = nro;
    }
    public Cuenta(int nrocta, string nomtit) :this(nrocta) 
    {
        Titular = nomtit;
    }
    public Cuenta(int nrocta, int sucursal, string nomtitu) :this(nrocta,nomtitu) 
    {
        Sucursal = sucursal;

    }
    public Cuenta(int nrocta, int sucursal, string nomtit, int doc):this(nrocta,sucursal,nomtit)
    {
        Dni = doc;
    }
//nro != nrocta los constructores se vinculan mediante el tipo de dato y no por el nombre de la variable.
// Lo que importa es el tipo y el orden de los parámetros en la firma del constructor, no sus nombres
    public string Titular { get; set; }
    public int Nro { get; set; }
    public int Dni { get; set; }
    public double Saldo { get; private set; }
    public int Sucursal{get; set;}
    public void Depositar(Double Monto)
    {
        Saldo += Monto;
    }

    public void Extraer(Double Monto)
    {
        Saldo -= Monto;
    }

    public double ConsultaSaldo()
    {
        return Saldo;
    }

    public void ImprimirConsultaSaldo()
    {
        System.Console.WriteLine(Saldo);
    }

}