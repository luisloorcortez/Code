namespace Propiedades
{
    class Program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Ingresa el salario del empleo: ");
            double Salario = double.Parse(Console.ReadLine());

            Empleado Admministracion = new("Pablo");
            Admministracion.SALARIO = Salario;

            Console.WriteLine($"El salario del empeado es: $" + Admministracion.SALARIO);
        }
    }
}
