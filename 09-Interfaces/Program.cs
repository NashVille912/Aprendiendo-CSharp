internal class Program
{
    private static void Main(string[] args)
    {
        AvisosVarios aviso1 = new AvisosVarios();
        aviso1.MostrarAvisos();

        AvisosVarios aviso2 = new AvisosVarios("AFIP", "Sancion por Incumplimientos Fiscales", "08/05/24");
        aviso2.MostrarAvisos();
    }
}