using System;
//Importamos esta librería para hacer uso de colecciones (Listas) genéricas.
using System.Collections.Generic;
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Colocamos la clase genérica seguido del tipo de elemnto que usaremos.
            Queue<int> numeros = new Queue<int>();

            int[] Array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Declaración de un Array de forma directa, solo para usar su conttenico. 
            //foreach (var  numero  in new var[10] {1,2, 3, 4, 5, 6, 7, 8, 9, 10})            
            foreach (var i in Array)
            {
                numeros.Enqueue(i);
                //Utilizamos el método Enqueue para agregar la lista FIFO.
            }

            //Imprimimos las Queue (Lista FIFO) números
            foreach (var i in numeros)
            {
                System.Console.WriteLine(i);
            }

            //Para eliminar elmentos utilizamos Dequeue
            //Este método no admite elementos, y simplemnete elimina el primero en la cola. 
            //En nuestro caso, el 1.
            numeros.Dequeue();
        }
    }
}