internal class Program
{
    private static void Main(string[] args)
    {
        Lagartija miLagartija = new Lagartija("Juancho");

        miLagartija.respirar();
        miLagartija.getNombre();
    }
}

abstract class Animal
{
    public void respirar()
    {
        Console.WriteLine("Soy capaz de respirar");
    }

    public abstract void getNombre();
}

interface IMamiferosTerrestres
{
    int NumPatas();
}

interface IMamiferosEnDeportes
{
    string TipoDeporte();
    bool EsOlimpico();
}
interface IMamiferosSaltador
{
    int NumPatas();
}

class Lagartija: Animal
{
    public Lagartija(string nombre)
    {
        this.nombre = nombre;
    }
    public override void getNombre()
    {
        Console.WriteLine(nombre);
    }
    private string nombre;
}

class Mamiferos: Animal
{
    public Mamiferos(string nombre)
    {
        this.nombre = nombre;
    }

    public void cuidarCrias()
    {
        Console.WriteLine("Cuido mi cria hata que se pueda valer por si sola");
    }

    public override void getNombre()
    {
        Console.WriteLine(nombre);
    }

    public virtual void pensar()
    {
        Console.WriteLine("Cada Mamifero puede pensar y tomar decisiones.");
    }

    string nombre;
}

class Caballo : Mamiferos, IMamiferosTerrestres, IMamiferosEnDeportes, IMamiferosSaltador
{

    public Caballo(string nombreCaballo) : base(nombreCaballo)
    {

    }

    public void galopar()
    {
        Console.WriteLine("Soy capaz de galopar");
    }

    int IMamiferosTerrestres.NumPatas()
    {
        return 4;
    }
    int IMamiferosSaltador.NumPatas()
    {
        return 2;
    }
    public string TipoDeporte()
    {
        return "Hipica";
    }
    public bool EsOlimpico()
    {
        return true;
    }
}

class Humano : Mamiferos, IMamiferosEnDeportes
{

    public Humano(string nombreHumano) : base(nombreHumano)
    {

    }
    public sealed override  void pensar()
    // Al usar la palabra NEW le estamos confirmando al compilador que nuestra idea era sobreescribir el metodoo.
    {
        Console.WriteLine("Soy capaz de pensar(?)");
    }

    public string TipoDeporte()
    {
        return "Futbol";
    }
    public bool EsOlimpico()
    {
        return true;
    }

}

class Adolescente : Humano
{
    public Adolescente(string nombre) : base(nombre)
    {

    }

    public override void pensar()
    {
        Console.WriteLine("Las hormonas me impiden pensar con claridad.");
    }
}

class Gorila : Mamiferos
{
    public Gorila(string nombreGorila) : base(nombreGorila)
    {

    }
    public override void pensar()
    {
        Console.WriteLine("Pensamiento Avanzado");
    }

    public void trepar()
    {
        Console.WriteLine("Soy capaz de trepar");
    }

}

class Ballena : Mamiferos
{
    public Ballena(string nombre) : base(nombre)
    {

    }

    public void nadar()
    {
        Console.WriteLine("Estoy nadando por los mares!");
    }
}

class Chimpance: Gorila
{
    public Chimpance(string nombre): base(nombre)
    {

    }
}

