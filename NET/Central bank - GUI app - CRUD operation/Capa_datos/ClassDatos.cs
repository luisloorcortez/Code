
//Librerías creadas.
using Capa_entidad;
using System.Data;

//Librerías del sistema. 
using System.Configuration;
using System.Data.SqlClient;

namespace Capa_datos
{
    //Esta clase recibe de CLassEntidad y es reenviada al formulario. 
    public class ClassDatos
    {

        //Biblioteca
        //Abrimos la conxión con la base y realizamos operaciones de mantenimiento a travez de procedimientos en la misma. 
        //La llamada de la conexión con la base fue realizada mediante App.config. 
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        //Utilizamos el procedimiento listar los valores existentes en la tabla. 
        public DataTable D_listar_clientes()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_clientes", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); //Emparejamos las filas en la tabla con nuestro contenedor. 
            return dt;
        }



        //Utilizamos el procedimiento buscar en la tabla. 
        public DataTable D_buscar_clientes(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); //Emparejamos las filas en la tabla con nuestro contenedor. 
            return dt;
        }



        //Mantenimientos: Crear, modificar y borrar. 
        //Tomamos los alias creados en el procedimiento "mantenimiento" de la base de datos y los empjaremos con los valores recibidos por cada método en la clase entidad. 
        public string D_mantenimiento_clientes(ClassEntidad obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo);
            cmd.Parameters.AddWithValue("@cedula", obje.cedula);
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            cmd.Parameters.AddWithValue("@apellidos", obje.apellidos);
            cmd.Parameters.AddWithValue("@edad", obje.edad);
            cmd.Parameters.AddWithValue("@cuenta", obje.cuenta);
            cmd.Parameters.AddWithValue("@tarjeta", obje.tarjeta);
            cmd.Parameters.AddWithValue("@direccion", obje.direccion);
            cmd.Parameters.AddWithValue("@telefono", obje.telefono);
            cmd.Parameters.AddWithValue("@estado", obje.estado);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open(); //Abrimos conexión.
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close(); // Cerramos conexión.
            return accion;
        }
    }
}
