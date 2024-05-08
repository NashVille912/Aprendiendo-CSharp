//bool frio = true;
//bool calor = !frio;
//if (frio)
//{
//    Console.WriteLine("Hace Frio");
//} else if (calor)
//{
//    Console.WriteLine("No hace Frio");
//} else
//{
//    Console.WriteLine("No tengo esa informacion disponible");
//}

Console.WriteLine("Elige tu estacion favorita del año: Verano, Otoño, Invierno o Primavera:");
String estacion = Console.ReadLine();

switch (estacion)
{
    case "Verano":
        Console.WriteLine("Se ve que te gusta mucho el Calor");
        break;
    case "Otono":
        Console.WriteLine("Te encanta ver las ojas secas en el piso");
        break;
    case "Invierno":
        Console.WriteLine("Eres un fanatico de la nieve");
        break;
    case "Primavera":
        Console.WriteLine("Te gusta mucho la estacion de las flores!");
        break;
    default:
        Console.WriteLine("Estacion invalida");
        break;
}
