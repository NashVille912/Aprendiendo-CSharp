internal class Program
{
    private static void Main(string[] args)
    {   
        //Propiedades


        //Empleado juan = new Empleado("Juan");
        //juan.SALARIO = 1200;
        //Console.WriteLine($"El salario del empleado es de: {juan.SALARIO}");
        //double bono = (juan.SALARIO * 30) / 100;
        //Console.WriteLine($"Este mes el empleado con el bono del 30% cobrara: {juan.SALARIO + bono}");

        //Structs


        //Employee empleado = new Employee(1200, 250);
        //Console.WriteLine(empleado.ToString());
        //empleado.aumentarSalario(empleado, 250);
        //Console.WriteLine(empleado.ToString());
    
        //Enums
    }
}

enum Estaciones
{
    Verano, Otono,Invierno, Primavera
}

class Empleado {

    public Empleado(string nombre)
    {
        this.nombre = nombre;
    }

    //public void setSalario(double salario)
    //{
    //    if (salario < 0)
    //    {
    //        Console.WriteLine("El salario no puede ser negativo, se asignara por defecto 0");
    //        this.salario = 0;
    //    }
    //    else
    //    {
    //        this.salario = salario;
    //    }
    //}


    //public double getSalario()
    //{
    //    return salario;
    //}


    private double evaluaSalario(double salario)
    {
        if (salario < 0)
        {
            return 0;
        }
        else
        {
            return salario;
        }
    }

    public double SALARIO
    {
        //get { return salario; }
        //set { this.salario = evaluaSalario(value);}

        get => this.salario;
        set => this.salario = evaluaSalario (value);
    }


    private string nombre;
    private double salario;

}
struct Employee
{

    public Employee(double salario, double comision)
    {
        this.salario = salario;
        this.comision = comision;
    }

    public override string ToString()
    {
        return $"Salario y comision del empleado {this.salario}, {this.comision}";
    }

    public void aumentarSalario(Employee empleado, double incremento)
    {
        empleado.salario += incremento;
        Console.WriteLine($"El nuevo salario del empleado sera de ${empleado.salario}");
    }


    private double salario;
    private double comision;

}