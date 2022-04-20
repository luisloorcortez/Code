using System;


class Cliente
{
    /*Coonstructor inicial
    public Cliente()
    {
        var User = 0;
        var Money = 0;
    }
    */
    //Set de Montos[].
    public void SetDepositos(int Usuario)
    {
        try
        {
            Console.Clear();
            System.Console.WriteLine("Ingrese la cantidad de dinero que desea depositar:");
            double Deposito = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Operación realizada correctamente.");
            //Acumulador Montos[].
            Montos[Usuario] += Deposito;
            //Contadores de interacción.
            Transacciones++;
            Depositos++;
        }
        catch (Exception) { System.Console.WriteLine("No ingresó un número, inténtelo de nuevo."); }
    }

    //Set - 2 Montos[].
    public void SetExtraer(int Usuario)
    {
        try
        {
            Console.Clear();
            System.Console.WriteLine("Ingrese la cantidad de dinero que desea retirar:");
            double Retiro = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Operación realizada correctamente.");
            //Acumulador Montos[].
            Montos[Usuario] -= Retiro;
            //Contadores de interacción.
            Transacciones++;
            Retiros++;
        }
        catch (Exception) { System.Console.WriteLine("No ingresó un número, inténtelo de nuevo."); }
    }

    //Get de Clientes[], Montos[]. 
    public void GetMonto(int Usuario)
    {
        Console.Clear();
        System.Console.WriteLine($"El saldo en la cuenta del cliente {Clientes[Usuario]} es: ${Montos[Usuario]}");
        //Contadores de interacción.
        Transacciones++;
        Consultas++;
    }

    //Get Transacciones
    public void GetOperaciones()
    {
        //Arqueo de caja.
        double Aux = 0;
        for (int i = 0; i < Montos.Length; i++)
        {
            double Total = Montos[0] += Montos[i];
            Aux = Total;
        }

        //Interacciiones.
        if (Transacciones > 0)
        {
            System.Console.WriteLine($"Se han realizado {Transacciones} Transaccion(es): {Depositos} Depósito(s), {Retiros} Retiro(s), {Consultas} Consuta(s) de fondos.");
            System.Console.WriteLine($"Total de dinero en el banco: ${Aux}");
        }
        else
        {
            System.Console.WriteLine($"Se han realizado {Transacciones} Transacciones.");
            System.Console.WriteLine($"Total de dinero en el banco: ${Aux}");
        }
    }

    //Propiedades de clase inicializadas y encapsuladas.
    private string[] Clientes = new string[] { "", "Daniel", "Daniela", "Dario", "Fernando" };
    private double[] Montos = new double[] { 0, 500, 500, 500, 500 };
    private int Transacciones, Retiros, Depositos, Consultas;
}

