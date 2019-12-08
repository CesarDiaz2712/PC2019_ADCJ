using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE.model.db;
using SE.model.pocos;

namespace SE.model.dao
{
    class UsuarioDAO
    {
        public static Usuario getLogin(String usuario, String contrasena)
        {
            Usuario u = null;
            SqlConnection conn = null;
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT"+
                        "x.idUsuario," +
                        "x.nombreUsuario," +
                        "x.contraseña" + 
                        "FROM dbo.seguimientoegresados x" +
                        "WHERE x.nombreUsuario = '{1}' AND x.contraseña = '{2}';", usuario, contrasena);
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        u = new Usuario();
                        u.IdUsuario = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                        u.NombreUsuario = (!rd.IsDBNull(1)) ? rd.GetString(1) : "";
                        u.Contrasena = (!rd.IsDBNull(2)) ? rd.GetString(2) : "";
                    }
                    rd.Close();
                    command.Dispose();
                    Console.WriteLine(u);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return u;
        }

    }
}
