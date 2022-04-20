class Vehículo
{
    public Vehículo(string Nombre)
    {
        NomVehiculo = Nombre;
    }
    public void ArrancarMotor()
    {
       System.Console.WriteLine($"El {NomVehiculo} puede arrancar su motor");
    }
    public void PararMotor()
    {
        System.Console.WriteLine($"El {NomVehiculo} puede frenar su motor");
    }

    public virtual void Conducir()
    {
        System.Console.WriteLine("");
    }

    private string NomVehiculo;
}
