// See https://aka.ms/new-console-template for more information
using System.Security;

Console.WriteLine("Hello, World!");
//Implemente una calse region con su nombre y superficie, una clase pais que herede de region
//Cada pais posee una coleccion de ciudades

var Argentina = new Pais();
Argentina.OrganizacionPolitica=Pais.Organizacion.Imperio;
Argentina.Ciudades=new List<Ciudad>();

Argentina.Ciudades.Add(new Ciudad(){Nombre="CABA",Superficie=1234, CiudadCapital=true});

var AmericaDelSur= new Continente();
AmericaDelSur.Paises= new List<Pais>();
AmericaDelSur.Pais.add(Argentina);
AmericaDelSur.Pais.add(new Pais(){Nombre="Urugay",Superficie="456",OrganizacionPolitica=Pais.Organizacion.Republica});
public class Region{
    public string Nombre { get; set; }
    public int Superficie { get; set; }
}

public class Pais : Region
{
    public string Idioma { get; set; }
    public enum Organizacion
    {
        Republica,
        Monarquia,
        Imperio,
        Otro
    }
    public Organizacion OrganizacionPolitica { get; set; }

}

public class Ciudad : Region {
    public bool CiudadCapital { get; set; }
}

public class Continente : Region {
    public List<Pais> CiudadCapital { get; set; }
}