
class Empleado : ISalarios
{
    public Empleado(double Salario)
    {
        this.Salario = Salario; 
    }

    public double GetSalario() => Salario;
   
    private double Salario;
}

