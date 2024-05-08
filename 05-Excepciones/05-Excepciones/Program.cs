using System.Collections.Concurrent;

internal class Program
{
    private static void Main(string[] args)
    {
        //Random numero = new Random();
        //int numAleatorio = numero.Next(1, 100);
        //int respuesta;
        //int cantidadIntentos = 0;

        //do
        //{
        //    Console.WriteLine("Adivina el numero entre 1 y 100");
        //    try
        //    {
        //       respuesta = int.Parse(Console.ReadLine()!);
        //    }catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.WriteLine("");
        //        Console.WriteLine("Has ingresado un valor que no es un numero, tu respuesta sera tomada como 0");
        //        Console.WriteLine("");
        //        respuesta =0;
        //    }

        //    if (respuesta < numAleatorio)
        //    {
        //        Console.WriteLine("El numero que ingresaste es MENOR al numero aleatorio. Prueba de nuevo");
        //        cantidadIntentos++;
        //    }
        //    else if (respuesta > numAleatorio)
        //    {
        //        Console.WriteLine("El numero que ingresaste es MAYOR al numero aleatorio. Prueba de nuevo");
        //        cantidadIntentos++;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Adivinaste!!! El numero {respuesta} es CORRECTO. Te ha llevado {cantidadIntentos} intentos");
        //    }
        //} while (numAleatorio != respuesta);



        //    int num = int.MaxValue;

        //    //int num2 = checked(num + 20);
        //    int num3 = unchecked(num + 20);

        //Console.WriteLine(num3);



        StreamReader archivo = null;

        try 
        {
            string linea;
            int contador = 0;

            string path = @"C:\Users\Nacho\Desktop\tirar.txt";

            archivo = new StreamReader(path);
            do
            {
                linea = archivo.ReadLine();
                Console.WriteLine(linea);
                contador++;
            }
            while (linea != null);

        }
        catch (Exception ex) 
        { 
            Console.WriteLine("No se ha podido encontrar el archivo");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (archivo != null)
            {
                archivo.Close();
                Console.WriteLine("Conexion con archivo cerrada");
            }
        }




    }
}