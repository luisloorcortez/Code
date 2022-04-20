using System;

class Humano : Mamiferos

{
    //Como la superclase tiene declarado un contructor, debemos uar : base() para tranferir los valores asignadors al 
    //objeto cuando se instació, de esta forma el contructor le poddrá dar sus valores iniciales. 
    public Humano(string nombre) : base(nombre) {}   

    public void Elhumano()
    {
        System.Console.WriteLine("Puedo pensar");
    }
}
