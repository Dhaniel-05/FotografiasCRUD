using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Álbum_Fotográfico_Empresarial.Clases
{
    public class Conexion
    {
        SqlConnection con;

        public Conexion()
        {
            con = new SqlConnection("Server=(Local)\\Sqlexpress;Database=FotografiasEvento;Integrated Security=True");
        }

        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(con.ConnectionString);
        }

        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
