using System;

class Informacion
{
    public void SolicitarDatos()
    {
        //OBJETOS
        CalculoBase Calculo = new();
        VerifiacdorReintentos Reintento = new();

        //MANTENEDOR DE BUCLE
        bool Flag = true;

        while (Flag == true)
        {
            //VERIFICADOR DE EXCEPCIONES
            try
            {
                //SOLICITUD DE DATOS
                System.Console.WriteLine("Por favor, ingrese la ganancia anual:");
                double Dinero = double.Parse(System.Console.ReadLine());

                //VERIFICADOR DE NÚMEROS POSITIVOS
                if (Dinero < 0)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Valor no aceptado. Reintente!");
                }
                else
                {
                    System.Console.Clear();
                    System.Console.WriteLine($"El total de dinero a pagar por el {Calculo.GetImpuesto()} % de impuestos es: {Calculo.Proceso(Dinero):C2}");
                }
            }
            catch (Exception)
            {
                System.Console.Clear();
                System.Console.WriteLine("No ingresó un dato valido. Reintente!.");
            }

            //VERIFICAR REINTENTO
            Flag = Reintento.Reintentar();
        }
    }
}