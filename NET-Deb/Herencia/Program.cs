using System;
namespace HerenaciaClaseAstracta
{
    class Program
    {
        static void Main(string[] Args)
        {

            //Instanciación de objetos utilizando el principio de tranferencia. 
            Caballo Appaloosa = new ("Babieca");
            Caballo Shire = new ("Terron");

            Mamiferos[] Mamiferos = new[] {Appaloosa, Shire};
            Mamiferos[1].GetNombre();
            //Shire.GetNombre();
            //Shire.Elcaballo();

            Lagartija Rosa = new ("Juancho");
            Rosa.GetNombre();
        }
    }
}
