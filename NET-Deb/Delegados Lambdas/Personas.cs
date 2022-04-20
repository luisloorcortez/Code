using System;
class Persona
{
    //Para manipular el valor del atributo <Nombre>
    public string Nombre
    {
        get => Nombre; set => Nombre = value;
    }

    //Para manipular el valor del atributo <Edad>
    public string Edad
    {
        get => Edad; set => Edad = value;
    }

    private string nombre;
    private int edad;
}
