using _08_Herencia;

internal class Program
{
    private static void Main(string[] args)
    {
        Caballo caballo = new Caballo("Tornado");
        IMamiferosSaltador miCaballo = caballo;

        Humano humano = new Humano("Nacho");   
        Gorila gorila = new Gorila("Copito");

        //Console.WriteLine($"El caballo se llama: {caballo.getNombre()}");
        //Console.WriteLine($"El humano se llama: {humano.getNombre()}");
        //Console.WriteLine($"El gorila se llama: {gorila.getNombre()}");

        //Mamiferos animal = new Caballo("Bucefalo");

        //Mamiferos[] mamiferos = new Mamiferos[3];
        //mamiferos[0] = caballo;
        //mamiferos[1] = humano;
        //mamiferos[2] = gorila;


        //foreach (Mamiferos animales in mamiferos)
        //{
        //   animales.pensar();
        //}

        //Avion avion = new Avion("Boeing 747", 6, "Turbinas");
        //Coche coche = new Coche("Ferrari", 4, "Nafta 3.5");

        //Console.WriteLine("Clase Avion");
        //avion.getInfo();
        //avion.arrancarMotor();
        //avion.conducir();
        //avion.detenerMotor();
        //Console.WriteLine();
        //Console.WriteLine("Clase Coche");
        //coche.getInfo();
        //coche.arrancarMotor();
        //coche.conducir();
        //coche.detenerMotor();

        Console.WriteLine($"El numero de patas con el que salta mi caballo es de {miCaballo.NumPatas()}");
    }




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

class Mamiferos
{
    public Mamiferos(string nombre)
    {
        this.nombre = nombre;
    }

    public void respirar()
    {
        Console.WriteLine("Soy capaz de respirar");
    }
    public void cuidarCrias() {
        Console.WriteLine("Cuido mi cria hata que se pueda valer por si sola");
    }

    public string getNombre()
    {
        return nombre;
    }

    public virtual void pensar()
    {
        Console.WriteLine("Cada Mamifero puede pensar y tomar decisiones.");
    }

    string nombre;
}

class Caballo: Mamiferos, IMamiferosTerrestres, IMamiferosEnDeportes, IMamiferosSaltador
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

class Humano: Mamiferos, IMamiferosEnDeportes
{

    public Humano(string nombreHumano): base(nombreHumano)
    {

    }
    public override void pensar()
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

class Gorila: Mamiferos
{
    public Gorila(string nombreGorila): base(nombreGorila)
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

class Ballena: Mamiferos
{
    public Ballena(string nombre): base(nombre)
    {

    }

    public void nadar()
    {
        Console.WriteLine("Estoy nadando por los mares!");
    }
}

class Avion : Vehiculo
{
    public Avion(string marca, int ruedas, string tipoMotor) : base(marca, ruedas, tipoMotor)
    {

    }

    public override void conducir()
    {
        Console.WriteLine("Estoy Piloteando un Avion!");
    }
}

class Coche : Vehiculo
{
    public Coche(string marca, int ruedas, string tipoMotor) : base(marca, ruedas, tipoMotor)
    {

    }

    public override void conducir()
    {
        Console.WriteLine("Estoy conduciendo mi coche");
    }
}