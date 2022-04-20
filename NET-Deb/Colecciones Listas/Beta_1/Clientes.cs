using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta_1
{
    internal class Clientes
    {
        public Clientes(string Nombre, double Monto)
        {
            this.Nombre = Nombre;
            this.Monto = Monto;
        }

        public double Deposito(double Deposito)
        {
            Monto += Deposito;
            return Monto;
        }

        public double Extraer(double Retiro)
        {
            Monto += Retiro;
            return Monto;
        }
        public void RetornarMonto()
        {
            Console.WriteLine($"El usuario {Nombre}, tiene: ${Monto} en su cuenta.");
        }

        private double Monto;
        private string Nombre;

    }
}
