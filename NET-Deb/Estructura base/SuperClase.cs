using System;

class SuperClase
{
    //Constructor de Clase.
    public SuperClase() { }

    //Set para modificar propiedades de clase.
    public void SetClase() { }

    //Get para mostrar propiedades de clase.
    public string GetClase() => "";

    //Método para realizar operaciones de clase. 
    public int Metodo(int a, int b) => 0;

    //Popiedades o variables de clase.
    private static int variables = 0;
}

//Por convención, el nomnre de las interfaces se escriben con mayúsculas.
interface IInterface
{
    /*
    Plantilla de métodos obligatorios que se deben construir en una clase: int metodo1(); 
    como es una "PLANTILLA" no necesita valores, solo ser claro en la característica obligatorias
    que se quiera aplicar a dichos métodos. 
    */
}