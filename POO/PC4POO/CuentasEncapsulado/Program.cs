// var cuenta1=new Cuenta();
var cuenta2=new CtaCtr();
var cuenta3=new CajaAhorro();
cuenta2.Retirar();
cuenta3.Retirar();

public abstract class Cuenta
{
    public int DNI { get; set; }
    public string? Banco { get; set; }
    public int CBU { get; set; }
    // public double Saldo { get; set; }
        private double Saldo; 

    public string? Alias { get; set; }
    public void Depositar(double monto) { 
        Saldo+=monto;
    }
    public override void Retirar(double monto)
    {
        throw new NotImplementedException();
    }
}

public class CtaCtr : Cuenta
{
    public int CBU { get; set; }
    public double Descubierto { get; set; }
    public void Retirar (){
        
    }
        // public override void Retirar(double monto)
    {
        throw new NotImplementedException();
    }

}

public class CajaAhorro : Cuenta
{
    public bool Dolares { get; set; }
    public double Descubierto { get; set; }
    public override void Retirar(double monto)
    {
        throw new NotImplementedException();
    }

}

public class CuentaVirtual: Cuenta {
    public string CVU { get; set; }
    public override void Retirar(double monto)
    {
        throw new NotImplementedException();
    }
    public void ConsultarSaldo(double Depositar){

}

}

