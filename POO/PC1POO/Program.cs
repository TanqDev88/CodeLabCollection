// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// instanciar la clase
var auto1 = new Auto(); 
auto1.Color="Amarillo";
auto1.Marca="Fiat";
auto1.Arrancar();
auto1.Modelo= 1939;
//al hacer el new se crea una instancia de la clase auto (auto1) 
//instacia de clase y objeto son sinonimos

// auto1.Marca();
// auto1.Color();
// System.Console.WriteLine(auto1.Marca);
// System.Console.WriteLine(auto1.Color);

var auto2 = new Auto();
auto2.Color="Rojo";
auto2.Marca="Fiato";
auto2.Arrancar();
auto2.Modelo= 1940;

System.Console.WriteLine(auto1.Marca + " " + auto1.Color + " " + auto1.Modelo);

if(auto1.Modelo>auto2.Modelo){
    System.Console.WriteLine("El auto 1 es mas nuevo que el auto 2");
}
else{
    System.Console.WriteLine("El auto 2 es mas nuevo");
}

//class es el modificador
class Auto{
    public string Color { get; set; }
    public string Marca { get; set; }
    public int Modelo { get; set; }

//public es la firma, void es el retorno (en este caso no devuelve nada)
    public void Arrancar(){
        Console.WriteLine("Arranco el auto");
    }
}