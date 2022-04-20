using System;
namespace Delagados_Predicados_Landas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esta es la forma de como instanciamos un objeto delegado simples. 
            ObjetoDelegado Llamador = new ObjetoDelegado(SaludoBienvenida.Bienvenido);
            Llamador();
            Llamador = new ObjetoDelegado(SaludoDespedida.Despedida);
            Llamador();

            ObjetoDelegado Rellamador = new ObjetoDelegado(SaludoDespedida.Despedida);
            Rellamador();
            Rellamador = new ObjetoDelegado(SaludoBienvenida.Bienvenido);
            Rellamador();     
        }

        //Definición del objeto delegado
        delegate void ObjetoDelegado();
        //Para poder invocar a un delegado los parámetros debenser los mismos que los del método
        //que deseamos invocar.
    }
}