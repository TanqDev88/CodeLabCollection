using System.ComponentModel;

var  macbookpro = new Portatil();
macbookpro.Procesador=new Procesador();
macbookpro.Procesador.Nucleos=8;
macbookpro.Procesador.Velocidad=2000;
macbookpro.Mouse=Portatil.mouse.touchPad;

var pccasa=new PC();
var intelI7=new Procesador(2500,8);
// intelI7.Nucleos=8; Estas dos linea ahora no tiene sentido por que paso los valores desde el constructor
// intelI7.Velocidad=2500;
intelI7.Marca="Intel";
intelI7.Precio=60000;
var hdd=new Disco();
hdd.Tipo=Disco.tipos.Rigido;
hdd.Capacidad=1000;

pccasa.Procesador=intelI7;

var fuente=new Fuente();
fuente.Voltaje=220;
fuente.Watts=800;
fuente.Modular=false;

pccasa.Procesador=intelI7;
pccasa.Disco=hdd;
pccasa.Fuente=false;


public abstract class Componente {
    public string Marca { get; set; }
    public double Precio { get; set; }
    public int Codigo { get; set; }

}

public abstract class Computadora : Componente {
    public Procesador Procesador{get; set;}
    public Disco Disco { get; set; } //CHAT GPT
}

public class Portatil: Computadora{
    public string Bateria { get; set; }
    public Monitor Monitor { get; set; }
    public enum mouse{
        trackPoint,
        touchPad
    }
    public mouse Mouse{ get; set; }

}

public class PC: Computadora{
        public bool Fuente { get; set; }
}
public class Procesador : Componente {
    public Procesador(){

    }
    public Procesador(int veloc, int nucleos){
        Velocidad=veloc;
        Nucleos=nucleos;
    }
    public int Velocidad { get; set; }
    public int Nucleos { get; set; }

}

public class Monitor :Componente {
    public int Pulgadas { get; set; }
    public int Resolucion { get; set; }
    public bool Regulable { get; set; }
    public bool Giratorio { get; set; }

}

public class Disco :Componente {
    public int Capacidad { get; set; }
    public enum tipos {
        Solido,
        Rigido
    }
    public tipos Tipo { get; set; }
    public int MyProperty { get; set; }

}

public class Bateria :Componente {
    public int Celdas { get; set; }
    public int Duracion { get; set; }

}

public class Fuente :Componente {
    public int Watts { get; set; }
    public int Voltaje { get; set; }
    public bool Modular { get; set; }

}