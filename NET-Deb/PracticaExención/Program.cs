using System;

namespace exectionControl
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

            int minumero = 0;
            int intentos = 0;
            bool reint = false;

            //Solicitamos información.
            Console.WriteLine("Introduce un nº entre 0 y 100");

            while (aleatorio != minumero)
            {
                intentos++;
                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }

                //Esta en una excepción general (padre) que toma todas las excepciones que aparecen.
                catch (Exception ex)
                {
                    System.Console.WriteLine("Introduciste datos incorrectos. Ingresamos el 0, por ti.");
                }

                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }

                //Esta en una excepción de formato (texto) que toma todas las excepciones de texto.
                catch (FormatException ex)
                {
                    System.Console.WriteLine("No ingresaste números. Ingresamos el 0, por ti.");
                }

                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }

                //Esta en una excepción de desvordamiento (númros/memoria).
                catch (OverflowException ex)
                {
                    System.Console.WriteLine("No ingresaste muchos números. Ingresamos el 0, por ti.");
                }

                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }
                //Esta en una excepción tipo filtro, que registra todas las excepciones, menos la que indiques.
                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    System.Console.WriteLine("No ingresaste muchos números. Ingresamos el 0, por ti.");
                }
                //Esta en una excepción que indicaste en el filtro anterior. Aquí programas lo que quieres que haga en concreto.
                catch (FormatException ex)
                {
                    System.Console.WriteLine("No ingresaste números. Ingresamos el 0, por ti.");
                }

                if (minumero > aleatorio) Console.WriteLine("El nº es más bajo");
                if (minumero < aleatorio) Console.WriteLine("El nº es más alto");

            }
            Console.WriteLine($"Correcto!. Has necesitado {intentos} intentos");
            System.Console.WriteLine("El programa continua luego de aquí");
        }
    }
}