/*
Esta clase sirve para procesar cualquier tipo de datos utilizando la herencia otorgada por Object, porque
los método se pueden almacenar en objeto, debidp a que el tipo de datos int, double, bool ect. Son considerados 
objetos es decir que heredan de este.


class AlmacenObjetos
{
    //Declaaramos cuantos elementos será cápaz de manejar el array de onjetos, que crearemos.
    public AlmacenObjetos(int Z)
    {
        //Inicializamos el array.
        DatosElementos = new object[Z]; 
    }

    //Este método nos servirá para ir llenando los espacios del array con los elemntos que ingresemos.  
    public void Agregar (Object Obj)
    {
        DatosElementos[I] = Obj;
        I++;
    }

    //Utilizamos este métodos pararegresar para mostrar la información.
    public Object GetElemento(int I) => DatosElementos[I]; 


    //Para almacenar datos tipo objeto, declaramos un array tipo objeto, como propiedad, pero no lo inicializamos.
    private Object[] DatosElementos;
    //Como deseamos interar el array sin necesidad de un for, esta variable lo hará mediante incrementos luego del uso.
    private int I=0;

}
}
*/

/*Indicamos que la clase resivirá datos genericos, todo tipo de dato.
De esta manera estamos obligando a que solo pueda manejar objetos de clases que tengan la interfaz salario*/

class AlmacenObjetos<T> where T : ISalarios
    /*Restricción aplicada a la clase generica. Índica que no aceptara objetos  de clases que
    no hereden la interface indicada*/
{
    //Declaaramos cuantos elementos será cápaz de manejar el array de onjetos, que crearemos.
    public AlmacenObjetos(int Z)
    {
        //Inicializamos el array genérico.
        DatosElementos = new T[Z];
    }



    /*Este método nos servirá para ir llenando los espacios del array con los elemntos que ingresemos. Aumentando 
    el contador e irlo igualando con los espaciio vacios del index de T[] DatosElementos.*/

    public void SetAgregar(T Obj)
    //Ondicamos que recibirá por parámetros un objeto que tenga en su inetrior cualquier dato.
    {
        DatosElementos[I] = Obj;
        I++;
    }




    //Utilizamos este métodos pararegresar para mostrar la información.
    public T GetElemento(int I) => DatosElementos[I];




    private T[] DatosElementos;
    //Array genérico para amejar objetos instanciados de clases diferentes  
    private int I = 0;
    //Iterador inicializado en 0, es un contador.

}


