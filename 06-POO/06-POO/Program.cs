using _06_POO;

namespace POO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Circulo miCirculo = new Circulo();

            //double area = miCirculo.calcularArea(5);
            //Console.WriteLine(area);

            //Circulo nuevoCirculpo = new Circulo();
            //double area2 = nuevoCirculpo.calcularArea(10);
            //Console.WriteLine(area2);

            //Coche miCoche = new Coche(3500.2, 1800.0);
            //miCoche.setExtras(true, "Cuero");
            //Console.WriteLine(miCoche.getInfoCoche());
            //Console.WriteLine(miCoche.getExtras());

            //realizarTarea();

            var miClaseAnonima = new { Nombre = "Nacho", edad = 36 };

            Console.WriteLine($"{miClaseAnonima.Nombre} - {miClaseAnonima.edad} anios");

        }


        static void realizarTarea()
        {
            //TODO: Continuar la realizacion del codigo...

            Punto punto = new Punto();
            Punto punto2 = new Punto();
            Punto segundoPunto = new Punto(280, 140);

            Console.WriteLine(punto.distanciaHasta(segundoPunto));

            Console.WriteLine($"Cantidad de Objetos creados de la clase Punto: {Punto.getContador()}");
        }



    }

   


}

