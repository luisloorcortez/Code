
class Lector
{
    StreamReader Archivo = null;
    int Contador;
    string Linea;

    public Lector()
    {
        Archivo = new StreamReader(@"D:\Programación\C#\DestructoresTexto\Hola.txt");
        while ((Linea = Archivo.ReadLine()) != null)
        {
            Console.WriteLine(Linea);
            Contador++;
        }
    }

    public void Mensaje()
    {
        Console.WriteLine("Hay {0} líneas", Contador);
    }

   //Esta es la sistxis para iniciar el destructor. Usado solo para recursos que controlas.
    ~Lector()
    {
        Archivo.Close();
    }
}

