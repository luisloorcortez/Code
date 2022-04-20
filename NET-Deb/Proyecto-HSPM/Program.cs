using System;
namespace Proyecto_De_Herencia_Sustitución_Polimorfismo_Modularidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion airbus = new ("Airbus");
            airbus.ArrancarMotor();
            airbus.PararMotor();
            airbus.Conducir();

            System.Console.WriteLine("");
            Vehículo maserati = new ("Maserati");
            maserati.Conducir();
            maserati.ArrancarMotor();
            maserati.Conducir();
        } 
    }
}
