using System;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de array
            int[] nombre_array1;

            /*
            Inicialización o reserva de espacio en memoria en el array, en este caso son 4 posiciones en el índice - 0, 1, 2, 3.
            */
            nombre_array1 = new int[4];

            /*
            Declaración e inicialización de un array interactivo (El usuario ingresará los valores) con 4 elementos. En este 
            caso los valores por defeccto en cada índice es "0".
            */
            int[] nombre_array2 = new int[4];

            nombre_array2[0] = 11;
            nombre_array2[1] = 12;
            nombre_array2[2] = 13;
            nombre_array2[3] = 14;

            //Declaración de array con inicialización de los 4 elementos en el indice. 
            int[] nombre_array3 = { 1, 2, 3, 4 };

            /*
            Array implicito - No se especifica el tipo de dato que contendrá es una de las opciones más flexibles de array, y +
            se declara de la siguiente manera:
            */

            //Así no se declara un array implícito
            //var nombre_array4 = new[] {"Juan", "Días", 15};

            /*
            Esta es la forma correcta de declarar un array implícito. con datos numéricos de varios tipos. Para saber el tipo de
            datos, el arreglo toma como tipo de dato general, de mayor gerarquía, por ejemplo int.
            */
            var nombre_array4 = new [] {0, 1, 2, 3};

            //USo de objeto tipo array
            Empleados Ana = new Empleados("Ana", 27);
 
            //Declaración de objeto tipo array
            Empleados[] arrayEmpleados = new Empleados[2];

            //Creación  de objeto y almacenamiento en un array
            arrayEmpleados[0] = new Empleados("Luis", 25);

            //Alamcenamiento de objeto ya creado
            arrayEmpleados[1] = Ana;

            //Arrays anónimos - recuerda que los campos ingresados cada objeto almacenado siempre deben ser los mismos para 
            //que no de error.

            var personas = new []
            {
                new {Nombre = "Juan", Edad = 19},
                new {Nombre = "Pedro", Edad = 29},
                new {Nombre = "Luis", Edad = 39}
            };
        }

      

        class Empleados

        {
            //Constructor interactivo de clase.
            public Empleados(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }

            //Parámetros de clase.
            string nombre = "";
            int edad = 0;
        }
    }
}
