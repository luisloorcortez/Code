using System;
namespace forAndarray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numeros = new int[] { 7, 9, 15, 13 };
            ProcesaDatos(numeros);
            */
            int[] elementos = LeerDatos();

            System.Console.WriteLine();
            System.Console.WriteLine("Imprimiendo desde el main");

            System.Console.WriteLine();
            foreach (var i in elementos)
            {
                System.Console.WriteLine(i);
            }

        }

        /*
        static void ProcesaDatos(int[] datos)
        {
            
            foreach (var i in datos)
            {
                System.Console.WriteLine(i);
            }
            

            for (int i = 0; i < datos.Length; i++)
            {
                //datos[i] += 10;
                System.Console.WriteLine(datos[i] += 10);
            }
            */
        static int[] LeerDatos()
        {

            System.Console.WriteLine("Cuántos elementos quieres en el array?");
            int numElementos = int.Parse(Console.ReadLine());

            int[] datos = new int[numElementos];

            for (int i = 0; i < datos.Length; i++)
            {
                System.Console.WriteLine($"introduce los datos para la posición: {i}");
                datos[i] = int.Parse(Console.ReadLine());
            }
            return datos;
        }
    }
}
