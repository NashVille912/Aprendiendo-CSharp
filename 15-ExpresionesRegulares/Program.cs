using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string frase = "Hola Mi nombre es Nacho, mi numero de telefono es 343-123-4567 y el codigo postal de mi ciudad es 3100";

        string patron = @"\d{3}";

        Regex miRegex = new Regex(patron);

        MatchCollection matches = miRegex.Matches(frase);

        foreach (Match match in matches)
        {
            if (match.Success) {
                Console.WriteLine("encontrada");
            } else
            {
                Console.WriteLine("no encontrada");
            }
        }
    }
}