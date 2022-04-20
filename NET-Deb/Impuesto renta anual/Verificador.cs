using System;

class VerifiacdorReintentos
{
    public bool Reintentar()
    {
        //MANTENEDOR DEBUCLE
        bool FlagLocal = true;

        while (FlagLocal == true)
        {
            //CONTROL EXCEPSIONES
            try
            {
                //RECPCIÓN DE DATOS 
                System.Console.WriteLine("Presione: 1 realizar cálculo, 0 salir.");
                int Aux = int.Parse(System.Console.ReadLine());

                //VERIFADOR USO CORRECTO DE DATOS.
                if (Aux == 0 || Aux < 0 || Aux > 1)
                {
                    if (Aux == 0)
                    {
                        //CERRAR WHILE, INFORMACIÓN.
                        Flag = false;
                        //CERRAR WHILE LOCAL.
                        FlagLocal = false;
                    }

                    else
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("Opción no valida. Reintente!");
                    }
                }

                //CERRAMOS BUCLE LOCAL, SELECCIÓN OPCIÓN <1>
                else
                {
                    System.Console.Clear();
                    FlagLocal = false;
                }
            }
            catch (Exception)
            {
                System.Console.Clear();
                System.Console.WriteLine("Datos incorrectos. Reintente!");
            }
        }
        return Flag;
    }
    private bool Flag = true;
}