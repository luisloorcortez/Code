class Caballo : Mamiferos, IAnimalesDeportes
{
    public Caballo(string Nombre) : base(Nombre) { }
    public void Elcaballo()
    {
        System.Console.WriteLine($"El caballo puede galopar");
    }

    public string TipoDeporte(string Deporte) => $"Mi deporte es {Deporte}";
    public bool EsOlimpico(bool Respuesta) => Respuesta;

}

