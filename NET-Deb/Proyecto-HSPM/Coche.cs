using System;


class Coche : Vehículo
{
    public Coche(string NomCoche) : base(NomCoche) { }

    public override void Conducir()
    {
        System.Console.WriteLine("El coche puede conducir por la tierra!");
    }
}
