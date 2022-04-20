//Librerías creadas
using Capa_datos;
using Capa_entidad;

//Librerías del systema
using System;
using System.Data;

//Esta clase se encarga de almacenar en memoria los datos y reenviarlos a la clase entidad. 
namespace Capa_negocio
{
    public class ClassNegocio
    {
        ClassDatos objd = new ClassDatos();

        //Biblioteca
        //Generamos métodos que nos permiten retornar las operaciones generadas en la Capa datos.
        //Listar, buscar y mantenimiento. 
        
        //Cargamos los valores que usaremos en memoria, para luego ser presentados. 1 método por cada procedimiento. 
        //Cargamos en memoria los datos a listar.
        public DataTable N_listar_clientes()
        {
            return objd.D_listar_clientes();
        }

        //Cargamos en memoria los datos a buscar.
        public DataTable N_buscar_clientes(ClassEntidad obje)
        {
            return objd.D_buscar_clientes(obje);
        }

        //Cargamos en memoria los datos a los que le haremos mantenimiento.
        public String N_mantenimiento_cliente(ClassEntidad obje)
        {
            return objd.D_mantenimiento_clientes(obje);
        }
    }
}
