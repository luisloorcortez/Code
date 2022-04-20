namespace Estructura_base
{
    class Program
    {
        static void Main(string[] Args)
        {
            Acomodador Retorno = new();
            //Así declaramos e inicializamos una lista La llenamos usando: list.Add(1);
            List<int> list = new(); 

            Console.WriteLine("¿Cuántos números quieres ingresar?");
            int Num = int.Parse(Console.ReadLine());


            Console.WriteLine("Procedemos a llenar la lista:");

            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine($"Ingresa el número {i + 1}:");
                list.Add(int.Parse(Console.ReadLine()));
            }           


            Console.WriteLine("Los números de tu lista, ordenados de menor a mayor, son:");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(Retorno.Ordenados(list)); 
            }
        }
    }
}