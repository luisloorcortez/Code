using System;


class Avion : Vehículo
{
    public Avion(string NomAvion) : base(NomAvion) { }

    public override void Conducir()
    {
        System.Console.WriteLine("El avión puede conducir por el cielo!");
    }
}
