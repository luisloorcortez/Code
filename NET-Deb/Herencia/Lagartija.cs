
class Lagartija : Animales
{
    public Lagartija(string Nombre)
    {
        NomReptil = Nombre;
    }
    
    public override void GetNombre()
    {
        System.Console.WriteLine($"El nombre del reptil es: {NomReptil}");
    }

    private string NomReptil;
}

