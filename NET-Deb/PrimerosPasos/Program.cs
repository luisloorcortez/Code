/*using System;
namespace Primera
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduce el primer número");
            int num = int.Parse(Console.ReadLine()); //.parse convierte valores de texto a valore númericos.

            System.Console.WriteLine("Introduce el segundo número");
            int num2 = int.Parse(Console.ReadLine()); //.parse convierte valores de texto a valore númericos. 


            System.Console.WriteLine("El número es: {0}", num*num2); //muestra por pantalla variables concatenadas con stream
        }
    }
}

// Declaración de constantes

using System;
namespace Primera
{
    class Program
    {
        static void Main(string[] args)
        {
            const int VALOR1 = 1; //Las constantes se escriben en mayúsculas para diferenciar.
            const int VALOR2 = 2; //Las constantes inician con const.

            System.Console.WriteLine("El valor de la constante dos es: {1}", VALOR1, VALOR2);


        }
    }
}
*/

//PROGRAMA QUE BUSQUE EL ÁREA DE UN CÍRCULO 

using System;
namespace Primera
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definimos las variables
            const double PI = 3.1416;

            //Solicitamos información por pantalla
            Console.WriteLine("Introduce el radio:");
            double radio = double.Parse(Console.ReadLine());

            //Realizamos las operaciones
            double area = radio * radio * PI;
            //double area = Math.Pow(radio, 2) * PI; //Usamos la función math para elevar al cuadrado radio.

            //Console.WriteLine("El valor del radio es: {0}", area);
            //Console.WriteLine($"El valor del radio es: {area}");
            Console.WriteLine("El valor del radio es: " + area);
        }
    }
}
