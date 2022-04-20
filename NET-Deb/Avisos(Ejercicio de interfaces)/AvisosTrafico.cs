
class AvisosTrafico : IAvisos
{   
    public AvisosTrafico()
    {
        Remitente = "DGT";
        Mensaje = "Tiene una multa de tráfico qu epagar";
        Fecha = "";    
    }
    public AvisosTrafico(string Remitente, string Mensaje, string Fecha)
    {
        this.Remitente = Remitente;
        this.Mensaje = Mensaje;
        this.Fecha = Fecha;
    }
    public string GetFecha() => Fecha;
    
    public void MostrarAviso() 
    {
        Console.WriteLine("Mensaje {0} ha sido enviado {1} el día {2} ", Mensaje, Remitente, Fecha);      
    }

    private string Remitente;
    private string Mensaje;
    private string Fecha;
}

