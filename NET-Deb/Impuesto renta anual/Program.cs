using System;
using System.Text;
namespace CalculoImpuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS OBJETO OPERADOR EN LA CLASE INFORMACIÓN
            Informacion Operador = new();

            //PRESENTAMOS EL PROGRAMA
            System.Console.Clear();
            System.Console.WriteLine("Este pograma realiza cálculo del impuesto a la renta anual.");
            System.Console.WriteLine();

            //iNSTANCIAMOS EL OBJETO OPERADOR
            Operador.SolicitarDatos();

        }
    }
}