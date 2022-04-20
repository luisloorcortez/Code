using System;
namespace PROGRAMA01_01
{
    class Program
    {   //Desrrollado por Luis Loor C.
        static void Main(String[] args)
        {
            bool Flag = true;
            //Instanciamos Calculadora en ClassCalculadora.
            ClassCalculadora Calculadora = new();

            //Presentamos el programa.
            Console.WriteLine("Este Programa realiza OPERACIONES CON 2 NÚMEROS");
            Console.WriteLine();

            while (Flag == true)
            {  
                try
                {
                    //Pedimos al susario que ingrese los datos necesarios.
                    Console.WriteLine("Igrese el primer número: "); double Nun1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Igrese el segundo número: "); double Nun2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qué operación realizarás con los números ingresados: Suma, Resta, Multiplicación o División: ");
                    string Operacion = Console.ReadLine();


                    //Realizamos la operación que es usuario elogió y presentamos resultados.
                    if (Operacion == "Suma" || Operacion == "suma" || Operacion == "SUMA" || Operacion == "+")
                    { Console.WriteLine($"El resultado de la Suma es: {Calculadora.Suma(Nun1, Nun2)}"); }

                    else if (Operacion == "Resta" || Operacion == "resta" || Operacion == "RESTA" || Operacion == "-")
                    { Console.WriteLine($"El resultado de la Resta es: {Calculadora.Resta(Nun1, Nun2)}"); }

                    else if (Operacion == "Multiplicación" || Operacion == "multiplicación" || Operacion == "multiplicacion"|| Operacion == "MULTIPLICACION" || Operacion == "*")
                    { Console.WriteLine($"El resultado de la Multiplicación es: {Calculadora.Multiplicacion(Nun1, Nun2)}"); }

                    else if (Operacion == "División" || Operacion == "división" || Operacion == "division" || Operacion == "DIVISION" || Operacion == "/")
                    { Console.WriteLine($"El resultado de la División es: {Calculadora.Division(Nun1, Nun2)}"); }

                    else { Console.WriteLine("No escrbió una orden valida. LEA BIEN LAS INSTRUCCIONES!"); }


                    //Consultamos si desea realizar otra operación. 
                    Console.WriteLine();
                    Console.WriteLine("Deseas realizar otra operación? s/n");
                    string Seleccion = Console.ReadLine();

                    if (Seleccion == "s" || Seleccion == "S") { Console.Clear(); }
                    else if (Seleccion == "n" || Seleccion == "N") { Flag = false; }
                    else { Console.WriteLine("Opción no valida. Programa terminado!"); Flag = false; }
                }
                catch (Exception) { Console.WriteLine("El dato ingresa es incorrecto.");}                
            }
        }       
    }
}