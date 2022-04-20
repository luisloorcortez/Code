using System;
namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro obj = new Carro();
            System.Console.WriteLine(obj.getInfoCoche());

        }
    }

    class Carro
    {
        /*
        Creamos un constructor - un metodo que dara un estado base a todos los objetos contruidos desde
        la clase Carro. Este método no retorna valores ni tiene tipo de dato declarado y debe ser público y
        el nombre debe ser el mismo que el de su clase.  
        */

        //Constructor carro.
        public Carro()
        {
            ruedas = 4;
            largo = 15.5;
            ancho = 5.5;
            tapiceria = "Tela";
        }

        /*Los metodos que sirven para modificar  otros metodos o retornan los valores almacenados en
        algún metodo de su misma clase se llaman Getter. La nomenclatura para crear nombre para estos 
        metodos es getNOMBREDELMETODO 
        */
        public string getInfoCoche() => "Información del coche:\nRuedas: " + ruedas +"\n"+"Largo: "+ largo +"\n"+"Ancho: " + ancho +"\n"+"Tapicería: "+ tapiceria +"\n"+"Climatízador: "+ climatizador;

        //Declaramos las propiedades o variables de clase. 
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
    }
}