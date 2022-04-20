using System;
namespace VerificadorPersona
{
    class Program
    {   //ESTE PROGRAMA SOLICITA POR PANTALLA INFORMACIÓN, LA VERIFICA Y LA 
        static void Main(string[] args)
        {
            //CREAMOS OBJETO 
            clasePersona Cliente = new();

            //SOLICITAMOS INFORMACIÓN
            for (int i = 0; i < 3; i++)
            { 
                //NOMBRE
                Console.WriteLine($"Ingrese el nombre del cliente {i + 1}: ");
                string Nombre = Console.ReadLine();
                Cliente.SetNombre(Nombre);

                //VERIFICAMOS QUE SE INGRESEN 10 DÍGITOS DE CÉDULA
                bool Flag = true;
                while (Flag == true)
                {
                    Console.WriteLine("Ingrese su identificación (10 dígitos!): ");
                    string Id = Console.ReadLine();

                    int Digitos = Id.ToString().Length;
                    if (Digitos == 10)
                    {
                        Console.WriteLine("La cédula es válida!");
                        Cliente.SetIdentificacion(Id);
                        Flag = false;
                    }
                    else { Console.WriteLine("La cédula es invalida, reintente!"); }
                }

                //SEXO
                Console.WriteLine("Ingrese su sexo, Masculino o Femenino: ");
                string Sexo = Console.ReadLine();
                Cliente.SetSexo(Sexo);

                //EDAD - CONTROL EXCEPCIONES
                Flag = true;
                while (Flag == true)
                {
                    try
                    {
                        Console.WriteLine("Ingrese su edad: ");
                        int Edad = int.Parse(Console.ReadLine());
                        if (Edad > 1 && Edad < 110)
                        {
                            Cliente.SetEdad(Edad);
                            Flag = false;
                        }
                        else { Console.WriteLine("La edad que ingresó no es correcta, reintente!"); }
                    }
                    catch (Exception) { Console.WriteLine("ingresó un dato incorrecto, reintente!"); }
                }

                //PRESENTAMOS LA INFORMACIÓN
                Console.WriteLine($"DATOS DEL CLIENTE: {i + 1}.");
                Cliente.GetTotal();
            }
        }
    }
}