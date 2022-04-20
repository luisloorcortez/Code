class Arreglos
{
    public void SetAcomodador(int[] Numero)
    {
        Array = Numero;

        //Recibimos la información  del objeto y lo guardamos en el Array.

        for (int i = 0; i < Array.Length; i++)
        {
            Console.WriteLine($"Ingresa el {i + 1} número: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            Array[i] = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo
        }

        
        //Ordenamiento burbuja con bandera: 

        bool Ordenado = false;  
        
        for (int i = 0; i < Array.Length && Ordenado == false ; i++)
        {
           //Esta es la bandera :)
            Ordenado = true;

            for (int j = 0; j < Array.Length - 1; j++)
            {
                if (Array[j] > Array[j + 1])
                {
                    Ordenado = false;
                    Aux = Array[j];
                    Array[j] = Array[j + 1];
                    Array[j + 1] = Aux;
                }
            }
        }

        //Presentamos la información del Array

        Console.WriteLine();
        Console.WriteLine("Estos son los números ordenados de menor a mayor:");

        for (int i = 0; i < Array.Length; i++)
        {
            Console.WriteLine(Array[i]);
        }

        Console.WriteLine();
        Console.WriteLine("Estos son los números ordenados de mayor a menor:");

        for (int i = Array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(Array[i]);
        }
    }

    private int[] Array = new int[1];
    private int Aux;
}