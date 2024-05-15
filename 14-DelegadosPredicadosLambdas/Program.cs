internal class Program
{
    private static void Main(string[] args)
    {
        //    // Creacion del objeto delegado apuntando al metodo
        //    ObjetoDelegado bienvenidaDelegada = new ObjetoDelegado(Bienvenida.MensajeBienvenida);
        //    ObjetoDelegado despedidaDelegada = new ObjetoDelegado(Despedida.MensajeDespedida);

        //    //Utilizacion del delegado para llamar a los metodos apuntados
        //    bienvenidaDelegada("Hola Mundo!");
        //    despedidaDelegada("GoodBye World!");

        List<int> numeros = new List<int>();

        numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

        //Predicate<int> funcPredicate = new Predicate<int>(damePares);

        //List<int> listaPares = numeros.FindAll(funcPredicate);

        //foreach(int pares in listaPares)
        //{
        //    Console.WriteLine(pares);
        //}
        //Console.WriteLine();
        //List<Persona> personas = new List<Persona>();
        //Predicate<Persona> funcionPredicate = new Predicate<Persona>(comprobarNombre);

        Persona pers1 = new Persona();
        pers1.Nombre = "Nacho";
        pers1.Edad = 36;
        Persona pers2 = new Persona();
        pers2.Nombre = "Diani";
        pers2.Edad = 38;
        //Persona pers3 = new Persona();
        //pers3.Nombre = "Vicky";
        //pers3.Edad = 12;

        //personas.AddRange(new Persona[] { pers1, pers2, pers3 });

        //bool existeNacho = personas.Exists(funcionPredicate);
        //if (existeNacho) Console.WriteLine("Nacho esta en la Lista");
        //else Console.WriteLine("Nacho no se encuentra en la lista");

        OperacionesMatematicas operaciones = new OperacionesMatematicas((num1,num2) => num1 + num2);

        Console.WriteLine(operaciones(4, 7));
        Console.WriteLine();

        List<int> listaNumeros = new List<int>{ 1,2,3,4,5,6,7,8,9};

        List<int> listaPares = listaNumeros.FindAll(i => i % 2 == 0);

        foreach (int numPar in listaPares)
        {
            Console.WriteLine(numPar);
        }


    }

    public delegate int OperacionesMatematicas(int numero1, int numero2);

    public static int Cuadrado(int num)
    {
        return num * num;
    }

}

////Definicion del objeto Delegado
//delegate void ObjetoDelegado(string mensaje);


//    //Definicion funcion predicada
//    static bool damePares(int num)
//    {
//        if(num%2 ==0) return true;
//        else return false;
//    }

//    static bool comprobarNombre(Persona persona)
//    {

//        if (persona.Nombre == "Nacho") return true;
//        else return false;
//    }
//}

class Persona
{
    private string nombre;
    private int edad;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
}

//class Bienvenida
//{
//    public static void MensajeBienvenida(string mensaje)
//    {
//        Console.WriteLine("Mensaje de Bienvenida: {0}", mensaje);
//    }
//}

//class Despedida
//{
//    public static void MensajeDespedida(string mensaje)
//    {
//        Console.WriteLine("Mensaje de Despedida: {0}", mensaje);
//    }
//}