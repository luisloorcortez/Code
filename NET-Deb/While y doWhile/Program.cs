using System;

namespace while_and_doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generamos un número aleatorio
            Random numero = new Random();
            //Cargamos el número aleatorio en una variable
            int aleatorio = numero.Next(0, 100);
            //Inicializamos variables
            int minumero;
            int intentos = 0;

            //Solicitamos información.
            Console.WriteLine("Introduce un nº entre 0 y 100");
            /*
            while (aleatorio != minumero)        
            {
                intentos++;
                minumero = int.Parse(Console.ReadLine());
                if (minumero > aleatorio) Console.WriteLine("El nº es más bajo");
                if (minumero < aleatorio) Console.WriteLine("El nº es más alto");
            }
            */
            do       
            {
                //Contamos las corridas del ciclo.
                intentos++;
                //asignamos a la variable minúmero el valor ingresado por por consola, además, al poner aquí
                //Console.Readline, ayuda a frenar el bucle y recargar el valor de la variable para otra comprobación.
                minumero = int.Parse(Console.ReadLine());
                if (minumero > aleatorio) Console.WriteLine("El nº es más bajo");
                else if (minumero < aleatorio) Console.WriteLine("El nº es más alto");
            }while (aleatorio != minumero);
            Console.WriteLine($"Correcto!. Has necesitado {intentos} intentos");
        }
    }
}
