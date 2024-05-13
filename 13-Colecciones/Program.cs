using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        //List

        //List<int> numeros = new List<int>();

        //Console.WriteLine("Cuantos elementos deseas introducir?");
        //int cantidad = int.Parse(Console.ReadLine());

        //for (int i = 0; i < cantidad; i++)
        //{
        //    Console.WriteLine($"Introduce el numero para el index {i}");
        //    int num = int.Parse(Console.ReadLine());
        //    numeros.Add(num);
        //}

        //Console.Write("[");
        //foreach (int num in numeros)
        //{
        //    Console.Write($"{num},");
        //}
        //Console.WriteLine("]");

        //LINKEDLIST

        //LinkedList<int> numeros = new LinkedList<int>();

        //foreach (int numero in new int[] {10, 8, 6,4,2, 0})
        //{
        //    numeros.AddLast(numero);
        //}

        //foreach (int numero in numeros)
        //{
        //    Console.WriteLine(numero);
        //}


        //QUEUES 

        //Queue<int> numeros = new Queue<int>();

        //foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
        //{
        //    numeros.Enqueue(numero);
        //}


        ////Recorrer el Queue
        //Console.WriteLine("Recorriendo el Queue");
        //foreach (int num in numeros)
        //{
        //    Console.WriteLine($"Queue: {num}");
        //}
        //Console.WriteLine();
        //Console.WriteLine("ToArray()    Copia los elementos Queue<T> en una matriz nueva.");
        //int[] num2 = numeros.ToArray();
        //foreach (int num in num2)
        //{
        //    Console.WriteLine($"Array: {num}");
        //}
        ////Eliminamos el primer elemento
        //numeros.Dequeue();
        //Console.WriteLine();
        //Console.WriteLine("Recorremos nuevamente con el Primer Elemento Eliminado con el metodo DEQUEUE()");

        //foreach (int num in numeros)
        //{
        //    Console.WriteLine($"Queue: {num}");
        //}
        //Console.WriteLine();
        //Console.WriteLine("Metodo .Contains<int>(4)  Comprobamos si el numero 4 esta dentro del Queue");
        //Console.WriteLine(numeros.Contains<int>(4));
        //Console.WriteLine();
        //Console.WriteLine("Peek()   Devuelve un objeto al principio de Queue<T> sin eliminarlo.");
        //Console.WriteLine(numeros.Peek());

        //Console.WriteLine();
        //Console.WriteLine("Clear()\t Quita todos los objetos de la colección Queue<T>.");
        //numeros.Clear();
        //foreach (int num in numeros)
        //{
        //    Console.WriteLine($"Queue: {num}");
        //}

        //STACKS

        //Stack<int> numeros = new Stack<int>();

        //foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
        //{
        //    numeros.Push(numero);
        //}
        //Console.WriteLine("Recorriendo el Stack");
        //foreach (int num in numeros)
        //{
        //    Console.WriteLine($"Stack: {num}");
        //}


        //DICTIONARYS


        Dictionary<string, int> edades = new Dictionary<string, int>();

        edades.Add("Nacho", 36);
        edades.Add("Diani", 38);
        edades.Add("More", 15);
        edades.Add("Vicky", 12);

        foreach(KeyValuePair<string, int> keyValuePair in edades)
        {
            Console.WriteLine($"Nombre: {keyValuePair.Key} - Edad: {keyValuePair.Value} ");
        }



    }
}