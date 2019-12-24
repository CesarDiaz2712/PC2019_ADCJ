using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE.model.db;
using SE.model.pocos;

namespace SE.model.dao
{
    public class InformaciónLaboralDAO
    {
        public static InformacionLaboral getInformacionLaboralByIdEgresado(Int32 idEgresado)
        {
            InformacionLaboral egresado = new InformacionLaboral();
            SqlConnection conn = null;
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT " +
                                                 "x.idInformacionLabora, " +
                                                 "x.respuesta, " +
                                                 "x.idEgresado, " +
                                                 "FROM dbo.InformacionLabora x " +
                                                 "WHERE x.idEgresado = {0)", idEgresado);
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        InformacionLaboral il = new InformacionLaboral();
                        il.IdInformacionLaboral = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                        il.Respuesta = (!rd.IsDBNull(1)) ? rd.GetString(2) : "";
                        il.IdEgresado = (!rd.IsDBNull(2)) ? rd.GetInt32(2) : 0;
                    }
                    rd.Close();
                    command.Dispose();
                    Console.WriteLine(egresado);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontró Información Laboral del egresado");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return egresado;
        }

        public static bool guardar(InformacionLaboral cuestionario, bool nuevo)
        {
            String query = "";

            if (nuevo) {
                query = "INSERT INTO dbo.InformacionLabora (respuesta, idEgresado)" +
                        "VALUES(@respuesta,@idEgresado);";
            }
            else
            {
                query = "UPDATE dbo.InformacionLabora SET " +
                    "respuesta=@respuesta, " +
                    "WHERE idInformacionLabora=@idInformacionLabora;";
            }

            SqlConnection conn = null;
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                if (conn != null)
                {
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@respuesta", cuestionario.Respuesta);
                    command.Parameters.AddWithValue("@idEgresado", cuestionario.IdEgresado);

                    int i = command.ExecuteNonQuery();
                    Console.WriteLine("Filas afectadas: " + i);
                    if (i > 0)
                    {
                        return true;
                    }
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo guardar la información...");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return false;
        }
    }
}
