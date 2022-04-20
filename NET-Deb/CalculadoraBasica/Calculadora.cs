using System;
namespace PROGRAMA01_01
{
    class ClassCalculadora    
    {
        //Métodos para las operaciones. 
        public double Suma( double Valor1, double Valor2)
        {
            Respuesta = Valor1 + Valor2;
            return Respuesta;
        }
        public double Resta(double Valor1, double Valor2)
        {
            Respuesta = Valor1 - Valor2;
            return Respuesta;
        }
        public double Multiplicacion(double Valor1, double Valor2)
        {
            Respuesta = Valor1 * Valor2;
            return Respuesta;
        }
        public double Division(double Valor1, double Valor2)
        {
            Respuesta = Valor1 / Valor2;
            return Respuesta;
        }

        //Declaramos PROPIEDADES
        private double Respuesta;
    }
}
