namespace Saludos
{
    class Program
    {
        static void Main(string[] Args)
        {
            Saludador Obj = new();

            System.Console.WriteLine("Escribe tu nombre: ");
            string Nombre = Console.ReadLine();
           
            System.Console.WriteLine(Obj.Saludo(Nombre));
        }
    }
}