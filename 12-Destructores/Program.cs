internal class Program
{
    private static void Main(string[] args)
    {
        ManejoArchivos miArchivo = new ManejoArchivos();

        miArchivo.mensaje();
    }
}

class ManejoArchivos
{
    StreamReader archivo = null;

    int contador = 0;
    string linea;

    public ManejoArchivos()
    {
        archivo = new StreamReader(@"C:\Users\Nacho\Desktop\texto.txt");

        while ((linea = archivo.ReadLine()) != null)
        {
            Console.WriteLine(linea);
            contador++;
        }
    }
    public void mensaje()
    {
        Console.WriteLine();
        Console.WriteLine($"Hay {contador} lineas en el archivo.");
    }

    ~ManejoArchivos()
    {
        archivo.Close();
    }
}