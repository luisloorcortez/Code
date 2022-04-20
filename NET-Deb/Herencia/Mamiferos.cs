internal class Mamiferos : Animales
{
    public Mamiferos(string Nombre)
    {
        NomMamifero = Nombre;
    }

    public void CuidarCrias()
    {
        System.Console.WriteLine("Cuido de mis crias hasta que se valgan por si mismos");
    }

    public override void GetNombre()
    {
        System.Console.WriteLine($"El nombre del mamífero es: {NomMamifero}");
    }

    private string NomMamifero;
}


