using System;

namespace EntidadBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcesosBancarios Servicios = new ();
            bool Flag = true;


            while (Flag == true)
            {
                Console.Clear();
                System.Console.WriteLine("Bienvenido al Banco 'La Esculapia'.");
                System.Console.WriteLine();

                try
                {
                    System.Console.WriteLine("Precione: 1 Iniciar aplicación, 0 Salir");
                    int Seleccion = int.Parse(System.Console.ReadLine());

                    if (Seleccion >= 0 && Seleccion <= 1)
                        if (Seleccion == 1) { Servicios.OperacionesCliente(); }
                        else { Flag = false; }

                    else { System.Console.WriteLine("No ingresó un número entre 0 y 1. Reintente."); }
                }
                catch (Exception) { System.Console.WriteLine("No ingresó un número. Inténtelo de nuevo."); }
            }
        }
    }
}