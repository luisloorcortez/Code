using System.Data.SqlClient;

namespace Plantilla
{
    internal class ClassConexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("Server=SERVER=DESKTOP-GVD6R4L;Database=master;Trusted_Connection=True;database=ZapateriaMartita"); 
            return cn;
        }
    }
}
