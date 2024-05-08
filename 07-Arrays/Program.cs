using _07_Arrays;
using System;
internal class Program
{
    private static void Main(string[] args)
    {

        //int[] numeros = new int[4];
        //Random rnd = new Random();
        //for (int i = 0; i < numeros.Length; i++)
        //{
        //    numeros[i] = rnd.Next(1, 11);
        //}

        //ProcesarDatos(numeros);
        

        static void ProcesarDatos(int[] datos)
        {
            foreach (int i in datos)
            {
                Console.WriteLine(i);
            }
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("Cuantos numeros quieres que tenga el array?");
            int respuesta = int.Parse(Console.ReadLine());
            int[] datos = new int[respuesta];

            for (int i = 0;i < datos.Length; i++)
            {
                Console.WriteLine($"Ingrese el valor para la posicion {i}");
                int num = int.Parse(Console.ReadLine());
                datos[i] = num;
            }

            return datos;
        }


        int[] datos = LeerDatos();
        Console.Write("[");
        foreach (int i in datos)
        {
            Console.Write($"{i},");
        }
        Console.WriteLine("]");

        //Empleado[] arrayEmpleados = new Empleado[2];
        //arrayEmpleados[0] = new Empleado("Nacho", 36);
        //arrayEmpleados[1] = new Empleado("Diani", 38);

        //for (int i = 0; i < arrayEmpleados.Length; i++)
        //{
        //    Console.WriteLine(arrayEmpleados[i].getInfo());
        //}

    }

}
