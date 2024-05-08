using System;

public class Circulo
{
    private const double PI = 3.1416;

    public double calcularArea(double radio)
    {
        return PI * (radio * radio);
    }
    public double calcularCircunferencia(double radio)
    {
        return 2 * (PI * radio);
    }
}
