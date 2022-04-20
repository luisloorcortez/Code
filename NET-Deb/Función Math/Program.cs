using System;
namespace PracticaMath
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();

        }
        static void realizarTarea()
        {
            //Objeto o instancia creado con el constructor por defecto - sin ingreso de parámetros
            Punto origen = new Punto();

            //Objeto o instancia creador con el constructor por defecto y reasignado el valor de sus variables con setPunto. 
            Punto destino = new Punto();
            destino.setPunto(128, 80);

            double distancia = origen.DistanciaHasta(destino);
            System.Console.WriteLine($"La distancia entre los punto es: {distancia}");
        }

        class Punto
        {
            //Constructor sin ingreso de información.
            public Punto()
            {
                x = 0;
                y = 0;
            }
            //Este setter modifica el valor de las variables otorgadas por el constructo dentro del objeto que lo invocó, mediante asignación.
            public void setPunto(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            /*
            Método o módulo que cálcula la distancia de un punto, usando "This" para que el método sepa cúales son las variables
            del objeto que invocó el método  "Origen" y cuales son las variables asignadas como parámetros del método, y así poder
            realizar las operaciones en su interior.  
            Si el parámetro del método es un objeto, al momento de ser invocado se deverá declarar como parámetro un objeto, y
            se tomará como asignación todas las variables en su interior. 
            */
            public double DistanciaHasta(Punto otroPunto)
            {
                int xDif = this.x - otroPunto.x;
                int yDif = this.y - otroPunto.y;
                double diferenciaPuntos = Math.Round(Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2)));

                //Fórmula para el teórema de Pitagoras, con resultado redondeado. 
                //double diferenciaPuntos = Math.Round(Math.Sqrt(Math.Pow((this.x - otroPunto.x), 2) + Math.Pow((this.y - otroPunto.y), 2)));

                return diferenciaPuntos;
            }

            //Propiedades, cracterísticas, parámetros o variables de clases
            private int x, y;
        }
    }
}
