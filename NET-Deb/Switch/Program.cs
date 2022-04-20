using System;
namespace Primera
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variable de tipo booleano - verdadero o falso 
            bool haceFrio;
            haceFrio = false;

            //El signo de " ! " hace el pape de la negación.
            System.Console.WriteLine(!haceFrio);
            */

            System.Console.WriteLine("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            switch (edad)
            {
                case ( >= 18 ):
                    System.Console.WriteLine("Presione 1 si tiene carnet de conducir, 0 si no tiene.");
                    int carnet = int.Parse(Console.ReadLine());

                    switch (carnet)
                    {
                        case (1):
                            System.Console.WriteLine("Presione 0 si es de moto, 1 si es de automóvil, 2 si tiene ambas.");
                            int tipo = int.Parse(Console.ReadLine());

                            switch (tipo)
                            {
                                case (0):
                                    System.Console.WriteLine($"Eres mayor de edad, tienes: {edad} años tienes licencia.");
                                    System.Console.WriteLine("Puedes pasar, y conducir motos.");
                                    break;

                                case (1):
                                    System.Console.WriteLine($"Eres mayor de edad, tienes: {edad} años y tienes licencia.");
                                    System.Console.WriteLine("Puedes pasar, y conducir automóviles.");
                                    break;

                                case (2):
                                    System.Console.WriteLine($"Eres mayor de edad, tienes: {edad} años tienes licencia.");
                                    System.Console.WriteLine("Puedes pasar, y conducir automoviles y motos.");
                                    break;

                                default:
                                    break;

                            }
                            break;

                        default:
                            System.Console.WriteLine($"Eres mayor de edad, tienes: {edad} años y no tienes licencia.");
                            System.Console.WriteLine("Puedes pasar, pero no conducir.");
                            break;
                    }
                    break;

                default:
                   System.Console.WriteLine($"No eres mayor de edad, tienes: {edad} años, no puedes pasar!");
                   break;
            }
        }
    }
}