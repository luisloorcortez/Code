using System;
namespace Lambdas
{
    //Este tipo de expresiones se utilizan al momento de usar delegados cencillos y su opoerador es < => >
    //parámetro => expresión o bloque de sentencia (La tarea a realizar).

    class Program
    {
        //Creamos un delegados  
        public delegate int OperArit(int Num);
        public delegate int AritOper(int Num1, int Num2);


        static void Main(string[] args)
        {

            //Le pasamos como parámeto al delegado, un método que realizará la operación.
            OperArit operaciones = new OperArit(Cuadrado);
            System.Console.WriteLine(operaciones(4));

            //Declaración de delegado lambda.
            AritOper Multiplica = new AritOper((num1, num2) => num1 * num2);

            //Como la construcción es genérica se debe indica los parámetros que se asegnaraán.
            System.Console.WriteLine(Multiplica(4, 7));
        }


        //Método que retorna el cuadrado de un número.
        public static int Cuadrado(int Num)
        {
            return Num * Num;
        }
    }
}