using System;
using System.Collections.Concurrent;

class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine(sumaNumeros(7, 9));
        //Console.WriteLine(divideNumeros(10, 3));


        //static int sumaNumeros(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //static double divideNumeros(double num1, double num2) => num1 / num2;

        Console.WriteLine(Suma(1, 4));
        Console.WriteLine(Suma(1.5, 3.5));


    }

    static int Suma(int num1, int num2)=> num1 + num2;
    static double Suma(double num1, double num2) => num1 + num2;

}