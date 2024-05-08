using System;


class AvisosVarios : IAvisos
{

    public AvisosVarios() 
    {
        remitente = "Direccion General de Transito";
        mensaje = "Sancion Cometida, Si abona dentro de los 3 dias, se reducira un 50% del valor total";
        fecha = "";
    }

    public AvisosVarios(string remitente, string mensaje, string fecha)
    {
        this.remitente = remitente;
        this.mensaje = mensaje;
        this.fecha = fecha;
    }


    public string getFecha()
    {
        return fecha;
    }

    public void MostrarAvisos()
    {
        Console.WriteLine($"El mesaje: '{mensaje}', ha sido enviado por: *{remitente}*, el dia {fecha}.");
    }


    private string remitente;
    private string mensaje;
    private string fecha;
}