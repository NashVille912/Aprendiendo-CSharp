using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Deseas ingresar al bucle?");
        //string respuesta = Console.ReadLine();

        //while (respuesta != "no")
        //{
        //    Console.WriteLine("Estamos dentro del bucle WHILE");
        //    Console.WriteLine("Ingresa tu nombre por favor");
        //    string nombre = Console.ReadLine();
        //    Console.WriteLine($"{nombre} deseas continuar dentro del bucle?");
        //    respuesta = Console.ReadLine();
        //}
        //Console.WriteLine("Hemos salido del bucle WHILE");

        //Random numero = new Random();
        //int numAleatorio = numero.Next(1,100);
        //int respuesta = 0;
        //int cantidadIntentos = 0;

        //while(numAleatorio != respuesta)
        //{
        //    Console.WriteLine("Adivina el numero entre 1 y 100");
        //    respuesta = int.Parse(Console.ReadLine()!);
        //    if (respuesta < numAleatorio)
        //    {
        //        Console.WriteLine("El numero que ingresaste es MENOR al numero aleatorio. Prueba de nuevo");
        //        cantidadIntentos++;
        //    }
        //    else if (respuesta > numAleatorio)
        //    {
        //        Console.WriteLine("El numero que ingresaste es MAYOR al numero aleatorio. Prueba de nuevo");
        //        cantidadIntentos++;
        //    } else
        //    {
        //        Console.WriteLine($"Adivinaste!!! El numero {respuesta} es CORRECTO. Te ha llevado {cantidadIntentos} intentos");
        //    }
        //}
        Console.WriteLine("Ingresa un numero entre 1 y 10 para ingresar al bucle");
        int num = int.Parse(Console.ReadLine()!);
        do
        {
            Console.WriteLine("Estamos dentro: Ingresa un numero entre 1 y 10");
            num = int.Parse(Console.ReadLine()!);
        } while (num <= 10);

    }
}