using System;

class clasePersona
{
    //CONSTRUCTORES
    public clasePersona() { } //INNECESARIO
    public clasePersona(string Nombre, bool Edad)  //INNECESARIO
    {
        this.Nombre = Nombre;
        this.Edad = Edad;
    }
    public clasePersona(string Nombre, string Sexo, string Identificacion, bool Edad)  //INNECESARIO
    {
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Identificacion = Identificacion;
        this.Sexo = Sexo;
    }


    //SETTER DE LA CLASE
    public void SetNombre(string Nombre)
    {
        this.Nombre = Nombre;
    }
    public void SetSexo(string Sexo)
    {
        if (Sexo == "Masculino" || Sexo == "Femenino")
        {
            this.Sexo = Sexo;
        }
        else { this.Sexo = "Indefinido"; }
    }
    public void SetEdad(int Edad)
    {
        if (Edad >= 18)
        {
            this.Edad = true;
        }
        else { this.Edad = false; }
    }
    public void SetIdentificacion(string Identificacion)
    {
        this.Identificacion = Identificacion;
    }


    //GETTER DE LA CLASE
    public void GetTotal()
    {
        Console.WriteLine();
        Console.WriteLine($"Nombre del sujeto: {this.Nombre}");
        Console.WriteLine($"Identificación del sujeto: {this.Identificacion}");
        Console.WriteLine($"¿El sujeto es mayor de edad?: {this.Edad}");
        Console.WriteLine($"Sexo del sujeto es: {this.Sexo}");
        Console.WriteLine();
    }


    //PROPIEDADES DE CLASE
    private string Nombre, Sexo, Identificacion;
    private bool Edad;      
}

