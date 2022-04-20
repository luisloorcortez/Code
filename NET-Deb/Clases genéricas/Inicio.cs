namespace Genericos
{
    class Inicio
    {
        static void Main(string[] Args)
        {
            AlmacenObjetos<Empleado> Archivos = new(5);
                        /*Aquí índicamos que usaremos objetos creasdos por la clase con la vamos a interactuaar
                        Al momentode crear un objeto*/
            
            //Archivos.Agregar("Luis");
            //Archivos.Agregar("Pedro");
            //Archivos.Agregar("Lucas");
            //Archivos.Agregar("Raúl");
            
            //Aquí estoy declarando un objeto tipo empleado, que tienen como nombre  el index del arreglo donde los 
            //estan enviando. 
            Archivos.SetAgregar(new Empleado(1500));
            /*Los objetos instanciados en la clase Empleado y pasados como parametro al método
            Agregar, de la clase AlmacenObjetos, por el objeto archivo. toman como nombre, su 
            espacio en el inedex del arreglo de objetos: T[] DatosElementos, en la clase AlmacenObjetos*/

            Archivos.SetAgregar(new Empleado(2500));
            Archivos.SetAgregar(new Empleado(3500));
            Archivos.SetAgregar(new Empleado(4500)); 
            Archivos.SetAgregar(new Empleado(0));


            //En este punto Asignamos el valor que devuleve el metodos a una variable tipo string, pero
            //como la información que retorna es una objeto, debemos hacer una conversión explicita o "casting"

            //string NonPersona = (string)Archivos.GetElemento(3);
            //Console.WriteLine(NonPersona);

            //Mostramos los valores impares en orden decendente
            for (int i = 4; i >= 0 ; i -= 2)
            {
                Console.WriteLine($"{Archivos.GetElemento(i)} Número: {i +1}");
               
                for (int j = 0; j < 1; j++)
                {
                    Empleado SalEmpleado = Archivos.GetElemento(i);
                    Console.WriteLine($"Gana: ${SalEmpleado.GetSalario()}");
                }
            }
            //Mostramos los valores impares en orden acendente.


            for (int i = 3; i >= 0; i -= 2)
            {
                Console.WriteLine($"{Archivos.GetElemento(i)} Número: {i + 1}");

                for (int j = 0; j < 1; j++)
                {
                    Empleado SalEmpleado = Archivos.GetElemento(i);
                    Console.WriteLine($"Gana: ${SalEmpleado.GetSalario()}");
                }
            }
        }
    }
}