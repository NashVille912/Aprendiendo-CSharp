using System;


namespace _07_Arrays
{
    //internal class Arrays
    //{

    //    private static void Main(string[] args)
    //    {
    //        //int[] miArray = new int[5];
    //        //miArray[0] = 1;
    //        //miArray[1] = 5;
    //        //miArray[2] = 63;
    //        //miArray[3] = 34;
    //        //miArray[4] = 59;
            

    //         //Array Impicito 
    //         int[] miArray = { 1, 5, 63, 34, 59 };

    //        //var datos = new[] { "Nacho", "Villarraza", 36 }; // No puede combinar tipos diferentes
    //        var datos = new[] { 1, 4, 77.8, 90.5 }; //aca convierte los int a double
    //        Console.WriteLine("Bucle For");
    //        for (int i = 0; i < miArray.Length; i++)
    //        {
    //            Console.WriteLine(miArray[i]);
    //        }
    //        Console.WriteLine("Bucle ForEach");
    //        foreach (var num in miArray)
    //        {
    //            Console.WriteLine(num);
    //        }


    //        // Array de tipos o clases anonimas
    //        var personas = new[]
    //        {
    //            new{Nombre = "Nachito", edad = 36},
    //            new{Nombre = "Dianita", edad = 38},
    //            new{Nombre = "Juan", edad = 99}
    //        };
    //    }

        

    //}
    class Empleado
        {
            public Empleado(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
            public string getInfo()
            {
                return $"Nombre: {nombre}, edad: {edad}";
            }
            private string nombre;
            private int edad;
        }
}
