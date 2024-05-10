internal class Program
{
    private static void Main(string[] args)
    {
        AlmacenEmpleados<Director> directores = new AlmacenEmpleados<Director>(3);
        directores.agregar(new Director(2500));
        directores.agregar(new Director(2500));
        directores.agregar(new Director(2500));
        AlmacenEmpleados<Secretaria> secretarias = new AlmacenEmpleados<Secretaria>(3);
        secretarias.agregar(new Secretaria(1800));
        secretarias.agregar(new Secretaria(1800));
        secretarias.agregar(new Secretaria(1800));
        AlmacenEmpleados<Electricista> electricistas = new AlmacenEmpleados<Electricista>(3);
        electricistas.agregar(new Electricista(1800));
        electricistas.agregar(new Electricista(1800));
        electricistas.agregar(new Electricista(1800));

        //Aqui nos marca el error porque estudiante no implementa la Interfaz IEmpleado
        //AlmacenEmpleados<Estudiante> estudiantes = new AlmacenEmpleados<Estudiante>(3);



        {

        }
    }
}

class AlmacenEmpleados<T> where T: IEmpleado
{
    public AlmacenEmpleados(int z)
    {
        datosEmpleados = new T[z];
    }

    public void agregar(T obj)
    {
        datosEmpleados[i] = obj;
        i++;
    }

    private int i = 0;
    private T[] datosEmpleados;
}

class Director: IEmpleado
{
    public Director(double salario)
    {
        this.salario = salario;
    }

    public double salario;

    public double getSalario()
    {
        return salario;
    }
}
class Secretaria: IEmpleado
{
    public Secretaria(double salario)
    {
        this.salario = salario;
    }

    public double getSalario()
    {
        return salario;
    }

    public double salario;
}
class Electricista: IEmpleado
{
    public Electricista(double salario)
    {
        this.salario = salario;
    }
    public double getSalario()
    {
        return salario;
    }

    public double salario;
}

class Estudiante
{
    public Estudiante(double edad)
    {
        this.edad = edad;
    }

    public double getEdad()
    {
        return edad;
    }

    private double edad;
}

interface IEmpleado
{
    double getSalario();
}