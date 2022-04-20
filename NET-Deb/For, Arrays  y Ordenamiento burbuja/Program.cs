namespace Ordenador
{
    //Este programa ordena los números ingresados de mayor a menor y vicebersa. 
    class Program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("¿Cuántos números quieres ordenar:?");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            int ingreso = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo
            int[] Numeros = new int[ingreso];

            Arreglos NumPass = new();
            NumPass.SetAcomodador(Numeros);
        }
    }
}
