using System;

public class Coche
{

    public Coche(double largo = 2300.5, double ancho = 1400.5)
    {
        this.ruedas = 4;
        this.largo = largo;
        this.ancho = ancho;
    }
    public string getInfoCoche()
    {
        return $"Informacion del Coche: \nRuedas = {ruedas}, \nLargo = {largo}, \nAncho = {ancho}.";
    }

    public void setExtras(bool calefaccion, string tapiceria)
    {
        this.calefaccion = calefaccion;
        this.tapiceria = tapiceria;
    }

    public string getExtras()
    {
        return $"Calefaccion: {calefaccion}, \nTapiceria: {tapiceria}";
    }

    private int ruedas;
    private double largo;
    private double ancho;
    private bool calefaccion;
    private string tapiceria;




}
