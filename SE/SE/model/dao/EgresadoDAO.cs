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
    public class EgresadoDAO
    {
        public static Egresado getLogin(String usuario, String contrasena)
        {
            Egresado u = null;
            SqlConnection conn = null;
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT " +
                        "x.idEgresado, " +
                        "x.matricula, " +
                        "x.apellidos, " +
                        "x.nombre, " +
                        "x.nombreUsuario, " +
                        "x.contraseña, " +
                        "x.idFichaPreEgreso " +
                        "FROM dbo.Egresado x " +
                        "WHERE x.nombreUsuario = '{0}' AND x.contraseña ='{1}';", usuario, contrasena);
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        u = new Egresado();
                        u.IdEgresado = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                        u.Matricula = (!rd.IsDBNull(1)) ? rd.GetString(1) : "";
                        u.Apellidos = (!rd.IsDBNull(2)) ? rd.GetString(2) : "";
                        u.Nombre = (!rd.IsDBNull(3)) ? rd.GetString(3) : "";
                        u.NombreUsuario = (!rd.IsDBNull(4)) ? rd.GetString(4) : "";
                        u.Contrasenia = (!rd.IsDBNull(5)) ? rd.GetString(5) : "";
                        u.IdFichaPreEgreso = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
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

        public static Egresado consultaInformacionEgresado(Int32 idEgresado)
        {
            Egresado u = null;
            SqlConnection conn = null;
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT " +
                        "x.idEgresado, " +
                        "x.matricula, " +
                        "x.apellidos, " +
                        "x.nombre, " +
                        "x.nombreUsuario, " +
                        "x.contraseña " +
                        "FROM dbo.Egresado x " +
                        "WHERE x.idEgresado = '{0}';", idEgresado);
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        u = new Egresado();
                        u.IdEgresado = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                        u.Matricula = (!rd.IsDBNull(1)) ? rd.GetString(1) : "";
                        u.Apellidos = (!rd.IsDBNull(2)) ? rd.GetString(2) : "";
                        u.Nombre = (!rd.IsDBNull(3)) ? rd.GetString(3) : "";
                        u.NombreUsuario = (!rd.IsDBNull(4)) ? rd.GetString(4) : "";
                        u.Contrasenia = (!rd.IsDBNull(5)) ? rd.GetString(5) : "";
                    }
                    rd.Close();
                    command.Dispose();
                    Console.WriteLine(u);
                }
            }
            catch (Exception e)
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
