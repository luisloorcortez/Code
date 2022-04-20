using System;
using System.Data;
using System.Data.SqlClient;

namespace Plantilla
{
    public class ClassProcesos
    {
        //Atributos locales. 
        private string cpNombres, cpApellidos, cpProducto, cpTelefono, cpEstado;
        private int cpCodigo;

        //Proceso setear atributos
        SqlConnection cn = ClassConexion.Conectar();
        
        //Sobrecarga de métodos. 
        public void setVariables(string loNombres, string loApellidos, string loProducto, string loTelefono)
        {
            cpNombres = loNombres;
            cpApellidos = loApellidos;
            cpProducto = loProducto;
            cpTelefono = loTelefono;
        }
        public void setVariables(string loNombres, string loApellidos, string loProducto, string loTelefono, string loEstado, int loCodigo)
        {
            cpNombres = loNombres;
            cpApellidos = loApellidos;
            cpProducto = loProducto;
            cpTelefono = loTelefono;
            cpCodigo = loCodigo;
            cpEstado=loEstado;              
        }

        //Proceso get datos
        public object getDatosPersonas()
        {
            string query;

            query = "mantenimiento @action='PGC'";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        //Proceso mantenimiento registrar
        public Boolean getRegistrar()
        {
            try
            {
                cn.Open();
                string query = "mantenimiento @action='PGI', @nombres='" + cpNombres + "', @apellidos='" + cpApellidos + "', @producto='" + cpProducto + "', @telefono='" + cpTelefono + "' ";
                SqlCommand comando = new SqlCommand(query, cn);
                comando.ExecuteNonQuery();
                cn.Close();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        //Proceso mantenimiento actualizar
        public Boolean getActualizar()
        {
            try
            {
                cn.Open();
                string query = "mantenimiento @action='PGA', @nombres='" + cpNombres + "', @apellidos='" + cpApellidos + "', @producto='" + cpProducto + "', @telefono='" + cpTelefono + "', @codigo='" + cpCodigo + "', @estado='" + cpEstado + "' ";
                SqlCommand comando = new SqlCommand(query, cn);
                comando.ExecuteNonQuery();
                cn.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Proceso mantenimiento eliminar
        public Boolean getEliminar()
        {
            try
            {
                cn.Open();
                string query = "mantenimiento @action='PGE', @codigo='" + cpCodigo + "' ";
                SqlCommand comando = new SqlCommand(query, cn);
                comando.ExecuteNonQuery();
                cn.Close();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }        
    }
}
