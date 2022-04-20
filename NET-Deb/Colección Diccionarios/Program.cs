using System;
//Importamos esta librería para hacer uso de colecciones (Listas) genéricas.
using System.Collections.Generic;
namespace Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Así declaramos una colección tipo diccionario. El primer argumento en una "key" y el 
            //segundo es el valor que tendrá esa key.
            Dictionary <string, int> edades = new Dictionary<string, int>();

            //Rellenamos el diccionario. diccionario.add(key, valor)
            //Forma 1:
            edades.Add("Juan", 32);
            edades.Add("Laura", 92);

            //Forma 2: Tipo array - diccionario[key]=valor
            edades["Marcos"]=35;
            edades["Juan"]=25;

            //Recorrer un diccionario con un foreach
            foreach (KeyValuePair<string, int> i in edades)
                                           // key    valor
            {
                System.Console.WriteLine("Nombre: {0} Edad: {1}", i.Key, i.Value);
            }

        }
    }
}