using System;
namespace Encapsulación
{
    class Program
    {
        //Este programa cálcula el área de un círculo.
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo();
            miCirculo.areaCirculo();

        }
    }

    class Circulo
    {
        public Circulo()
        {
            PI = 3.1416;
        }

        /*
        public void setCambioPi(double nuevoPi)
        {
            if (nuevoPi > 0) PI = nuevoPi;
            else PI = 3.1416;
        }
        */

        public void areaCirculo()
        {
            System.Console.WriteLine("El área de cuantos círculos vas a cálcular? Ingresa un número: ");
            int cantidad = int.Parse(Console.ReadLine());
            double[] numAreas = new double[cantidad];

            double[] toma = new double[cantidad];

            for (int i = 0; i < numAreas.Length; i++)
            {
                double[] paso = new double[i + 1];
                System.Console.WriteLine($"Ingresa el área del {i + 1} círculo:");
                paso[i] = double.Parse(Console.ReadLine());
                toma[i] = paso[i];
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Los resultados son los siguientes:");
            System.Console.WriteLine();

            for (int i = 0; i < toma.Length; i++)
            {
                double[] dame = new double[i + 1];
                dame[i] = toma[i];

                double areaCirculo = PI * Math.Pow(dame[i], 2);
                System.Console.WriteLine($"El resultado del área {i + 1} es {areaCirculo}");
            }
        }

        private static double PI = 3.1416;
    }
}
