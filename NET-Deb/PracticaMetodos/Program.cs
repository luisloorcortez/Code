/*using System;
namespace PracticaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //mensajePantalla();
            System.Console.WriteLine("Mensaje desde el Main");
            //Un método se llama usando solo su nombre, respetando el flujo de ejecución
            //mensajePantalla();
            //Este tipo de metodos, espera que se le ingresen los parametros necesarios al momento de llamarlos.
            sumaNumeros( 7, 9);
        }
        

        /*Ejemplo de método void no interactivo #1 - No devurlve datos solo imprime pantalla. 
        static void mensajePantalla()
        {
            System.Console.WriteLine("Mensdaje desde el método MP");
        }
        

        //Ejemplo de método void no interactivo #2 - No devuelven satos, solo imprimen pantalla. 
        static void sumaNumeros( int num1, int num2)
        {
            //int resultado = num1 + num2;
            System.Console.WriteLine($"El resultados de la suma es: {num1+num2}");
        }
    }
}
*/

// Metodos que retoenan resultados

using System;
namespace PracticaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {            
            System.Console.WriteLine("Ingresa el primer número");
            int num1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingresa el segundo número");
            int num2 = int.Parse(Console.ReadLine());
          
            
            sumaNumeros( num1, num2);
            System.Console.WriteLine($"El resultados es: {sumaNumeros( num1, num2)}");
        }
        /*Datos:
        Si le dices a un metodo que recibirá un tipo de dato específico, procesará la información
        usando ese tipo de dato. a menos que los parametros usen otro tipo de datos tomará en cuenta el 
        que tenga gerarquía superior

        Si un metodo tiene más de una carilla está mal diseñado.    
        */
        /*
        Sintaxis clásica para invocar a un método.
        static int sumaNumeros( int num1, int num2)
        {
            //int resultado = num1 + num2;
            return num1+num2;
        }
        
        //Otra forma para la sintaxis de los métodos de una línea de código
        static int sumaNumeros( int num1, int num2) => num1+num2;
        */

        //Sobecarga de métodos:
        /*Hace referencia a la utilización de métodos con el mismo nombre, ca,biando el tipo de datos que recibe y
        los parámetros dentro del metodo, haciendo de esa manera la sobrecarga.
        
        static int sumaNumeros( int num1, int num2, int num3) => num1+num2+num3;
        static float sumaNumeros( float num1, int num2) => num1+num2;
        static int sumaNumeros( int num1, int num2) => num1+num2;

        */
        static int sumaNumeros( int num1, int num2) => num1+num2;


    }
}