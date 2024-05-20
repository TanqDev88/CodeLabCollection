// See https://aka.ms/new-console-template for more information
using Modelos;

var piloto=new Piloto();
piloto.Apellido="Papagudia";
piloto.Nombre="Saracho";
piloto.DNI=11111;

var hunkers=new Avion();
hunkers.Abordar(piloto);

piloto.SaludarPiloto();
var pasajero1=new Pasajero(12345678,"Marina");
// pasajero1.Nombre="Marina";
// pasajero1.Apellido="Cacha";
// pasajero1.DNI=124578;

hunkers.Abordar(pasajero1);

//var persona=new Persona();
