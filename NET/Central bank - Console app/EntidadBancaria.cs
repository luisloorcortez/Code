centos
using System;

class ProcesosBancarios
{
    public void OperacionesCliente()
    {
        //Instanciamos el objeto "Operaciones" en la clase cliente.
        Cliente Operaciones = new Cliente();

        //Flag de bucle.
        bool Flag = true;

        while (Flag == true)
        {
            //Control genérico de excepciones.
            try
            {
                //Menú general.
                System.Console.WriteLine();

                System.Console.WriteLine("Presione: 1 Depositos, 2 Retiros, 3 Saldos, 4 Operaciones realizadas, 0 para salir:");
                int Seleccion = int.Parse(System.Console.ReadLine());

                if (Seleccion >= 0 && Seleccion <= 4)
                {
                    //Realizar depósito en la cuenta de los clientes.
                    if (Seleccion == 1)
                    {
                        bool Flag_1 = true;
                        while (Flag_1 == true)
                        {
                            //Menú 2.a
                            System.Console.WriteLine();
                            System.Console.WriteLine("DEPÓSITOS:");
                            System.Console.WriteLine("Presione: 1 Daniel, 2 Daniela, 3 Dario, 4 Fernando, 0 Ir al menú principal: ");
                            int Seleccion_2 = int.Parse(System.Console.ReadLine());

                            if (Seleccion_2 > 0 && Seleccion_2 < 5)
                            {
                                //El objeto "Operaciones" usa el método SetDepositos.
                                Operaciones.SetDepositos(Seleccion_2);
                            }
                            else if (Seleccion_2 == 0) { Flag_1 = false; }
                            else { System.Console.WriteLine("No ingresó un número, entre 0 y 4. Lo enviaremos al menú principal"); }
                        }
                    }

                    //Retiros. 
                    else if (Seleccion == 2)
                    {
                        bool Flag_2 = true;
                        while (Flag_2 == true)
                        { //Menú 2.
                            System.Console.WriteLine();
                            System.Console.WriteLine("RETIROS:");
                            System.Console.WriteLine("Presione: 1 Daniel, 2 Daniela, 3 Dario, 4 Fernando, 0 Ir al menú principal: ");
                            int Seleccion_2 = int.Parse(System.Console.ReadLine());

                            if (Seleccion_2 > 0 && Seleccion_2 < 5)
                            {
                                //El objeto "Operaciones" usa el método SetExtraer.
                                Operaciones.SetExtraer(Seleccion_2);
                            }
                            else if (Seleccion_2 == 0) { Flag_2 = false; }
                            else { System.Console.WriteLine("No ingresó un número, entre 0 y 4"); }
                        }
                    }

                    //Consultas. 
                    else if (Seleccion == 3)
                    {
                        bool Flag_3 = true;
                        while (Flag_3 == true)
                        {
                            //Menú 2.c
                            System.Console.WriteLine();
                            System.Console.WriteLine("CONSULTA DE SALDOS:");
                            System.Console.WriteLine("Presione: 1 Daniel, 2 Daniela, 3 Dario, 4 Fernando, 0 Ir al menú principal: ");
                            int Seleccion_2 = int.Parse(System.Console.ReadLine());

                            if (Seleccion_2 > 0 && Seleccion_2 < 5)
                            {
                                //El objeto "Operaciones" usa el método RetornarMonto(GetMonto).
                                Operaciones.GetMonto(Seleccion_2);
                            }
                            else if (Seleccion_2 == 0) { Flag_3 = false; }
                            else { System.Console.WriteLine("No ingresó un número, entre 0 y 4"); }
                        }
                    }

                    //Interacciones.
                    else if (Seleccion == 4)
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("OPERACIONES REALIZADAS Y DINERO EN EL BANCO LA ESCULAPIA:");
                        //El objeto "Operaciones" usa el método RetornarMonto(GetMonto).
                        Operaciones.GetOperaciones();
                        Console.WriteLine("Presione ENTER para salir: ");
                        Console.ReadLine();
                    }

                    //Negación flag.
                    else { Flag = false; }
                }
                else { System.Console.WriteLine("No ingresó un número, entre 0 y 4"); }
            }
            catch (Exception) { System.Console.WriteLine("No ingresó un número. Inténtelo de nuevo."); }
        }
    }
}


