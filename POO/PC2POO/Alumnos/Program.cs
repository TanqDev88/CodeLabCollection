// ATRIBUTOS (Se van a pasar a la clase como Datos): Nombres, Apellido, fecha de nacimiento
// COMPORTAMIENTOS (Se van a pasar a la clase como Metodos):

var alumno1 = new Alumno();
alumno1.Saludar();
alumno1.Nombre = "Pepe";
alumno1.Apellido = "Grillo";

var alumno14=new Alumno(19391978);
System.Console.WriteLine(alumno14.Documento);

Alumno alumnoBecado = new Alumno();

var alumnoLibre = new Alumno();

alumnoLibre.Nombre= "Patuyo";
alumnoBecado.Saludar();
public class Alumno
{
    public Alumno(){

    }

        public Alumno(int pdni){
            dni=pdni;
        
    }
    // CAMPOS
    string nombre;
    public string Apellido{get;set;}
    private int dni;
    public int Documento
    {
        get { return dni; }
        set { dni = value; }
    }
    //PROPIEDADES
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }


    // public string Apellido
    // {
    //     get { return apellido; }
    //     set { apellido = value; }
    // }

    public string NombreCompleto
    {
        get { return nombre + " " + Apellido; }
    }

    public void Saludar()
    {
        nombre = "Laura";
        System.Console.WriteLine("Hola soy: " + nombre);
    }
    private void Anotarse()
    {

    }
}

// private class Alumno
// { //Todo lo que va adentro de la clase se llamand mienbros de la clase(pueden ser campos, propiedades, listas, metodos, otras clases)
//   //Campos
//     string nombre;
//     string apellido;

//     private int dni;
//     //Metodos
//     public void Saludar()
//     {
//         nombre = "Laura";
//     }

//     private void Anotarse()
//     {

//     }

// }


