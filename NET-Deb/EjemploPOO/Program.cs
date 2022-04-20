using System;
namespace PracticaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
           Declaración un objeto dentro de una clase:
           Esto es una variable "OBJETO" miCirculo y pertenece a la "CLASE" círculo. Se conforman 
           por una clase, seguido de una variable creada por el usuario.
           */
           //Circulo miCirculo;

           /*
           Inicializamos un objeto dentro de una clase:
           Las variables objeto se inician dentro de una clase de la siguiente manera. A esto de le 
           denomina instanciación, ejemplarización  o ejemplarizar una clase.  Siempre se inicia despues de  la variable objeto
           en una línea diferente.           
           */
           //miCirculo = new Circulo();
           //instanciación directa del objeto miCirculo en la Clase Círculo.
           Circulo miCirculo = new Circulo();

           /*
           Utilizamos el objeto cona la nomenclatura del punto:
           Para utilizamos la nomenclatura del " . " lo escribimos de la siguiente manera: 
           " objeto.metodo() "
           */

           //miCirculo.calculoArea(25);

           System.Console.WriteLine("Escribe el área del círculo: ");
           float area = float.Parse(Console.ReadLine());
        
           System.Console.WriteLine($"El área es: {miCirculo.calculoArea(area)}");
        }
    }

    class Circulo
    {
        /*Esto se denomina propiedad o campo de clase. variable global de clase. Hace referncia a un 
        valor "contante", que servirá de plantilla. Es una variable de clase. 
        */
        const double PI = 3.1416; 
        
        /*Los metodos (Lo que va a hacer el esta clase) son los bloques de código que realizan las 
        operaciones dentro de las clases. 
        */
        public double calculoArea(float radio)
        {
            return PI * radio * radio;
        }
    }
}
