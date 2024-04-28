var profe1=new Profesor(){Nombre="Eleuterio",Apellido="Sosa",DNI=26599985};
profe1.Sueldo=120000;
var alumno1= new Alumno(){Nombre="Jimena",Apellido="Erubige",DNI=45211452};
alumno1.CantidadMateriasAprobadas=45;

var ctacte1=new CtaCte();
ctacte1.CBU=124578;
var cajaahorro=new CajaAhorro();
cajaahorro.CBU=124578;

public class Persona {
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public int DNI { get; set; }
    public void Saludar(){ 

    }
}

public class Alumno : Persona{
    public int Legajo { get; set; }
    public int CantidadMateriasAprobadas { get; set; }
}

public class Profesor : Persona {
    public int Sueldo { get; set; }

}

public class Cuenta{
    public string Banco { get; set; }
public Double Saldo { get; set; }
public int CBU { get; set; }
public void Transferir() {

}
public string Titular { get; set; }
}

public class CtaCte{
    public string Chequera { get; set; }
    public double Descubierto { get; set; }
    public void EmitirCheque() {

}

}

public class CajaAhorro{
    public double CostoMantenimiento { get; set; }
        public void SumarMillas() {

}

}