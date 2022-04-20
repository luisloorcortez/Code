
class Saludador
{
    //Constructor
    public Saludador() { Hola = "Hola querid@"; }

    // Métodos Set y Get
    public void SetCamSal(string Hola) { this.Hola = Hola; }
    public string GetCamSal() => $"El saludo guardado es: {Hola}";

    //Método centrar de la clase.
    public string Saludo(string Sujeto) => $"{Hola}, {Sujeto}";

    //Propiedadesd de clase.
    private string Hola;

}

