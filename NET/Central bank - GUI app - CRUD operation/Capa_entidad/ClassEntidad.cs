using System;

namespace Capa_entidad
{
    //Biblíoteca
    //Creamos las variables que harán de intermediario entre la base de datos y el formulario, recibiendo y entrgando datos. 
    //En esencia, cada columna de la tabla. 
    
    //esta clase se encarga de reenviar los datos recibidos desde ClassNegocio y renviarla a ClassDatos.
    public class ClassEntidad
    {

        //Creamos métodos tipo String para poder operar los valores almacenados en la tabla que usaremos. 1 por cada columna. 
        public String codigo { get; set; }
        public String cedula { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public int edad { get; set; }
        public String cuenta { get; set; }
        public String tarjeta { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String accion { get; set; }
        public String estado { get; set; }
    }
}
