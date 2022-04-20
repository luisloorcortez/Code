

internal class Empleado
{
    public Empleado(string Nombre)
    {
        this.Nombre = Nombre;
    }

    /*
    public void SetSalario(decimal Salario)
    {        
        if (Salario < 0)
        {
            Console.WriteLine("El salario no puede ser negativo, se asignará $0 como salario.");
            Salario = 0;            }
        else
        {
            this.Salario = Salario;
        }       
    }

    public decimal GetSalario() => Salario

    */

    //Aquí usamos PROPIEDADES para realizar una verificación y entrega de información.

    private double EvaluaSalario(double Salario)
    {
        if (Salario < 0) return 0;
        else return Salario;
    }

    public double SALARIO
    {
        get { return Salario; }
        set { Salario = EvaluaSalario(value); }
    }

    private string Nombre;
    private double Salario;
}

