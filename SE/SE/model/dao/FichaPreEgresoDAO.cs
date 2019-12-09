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
    class FichaPreEgresoDAO
    {

        public static List<FichaPreEgreso> getFichaPreEgresoByIdEgresado(Int32 idEgresado)
        {
            List<FichaPreEgreso> list = new List<FichaPreEgreso>();
            SqlConnection conn = null;
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT "+
                                                "x.idFichaPreEgreso,"+
                                                "x.matricula,"+
                                                "x.apellidos,"+
                                                "x.nombre,"+
                                                "x.fechaNacimiento,"+
                                                "x.sexo,"+
                                                "x.nacionalidad,"+
                                                "x.direccion,"+
                                                "x.telefono,"+
                                                "x.email"+
                                                "FROM dbo.fichapreegreso x"+
                                                "WHERE x.idEgresado = {0}", idEgresado);
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        FichaPreEgreso fp = new FichaPreEgreso();
                        fp.IdFichaPreEgreso = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                        fp.Matricula = (!rd.IsDBNull(1)) ? rd.GetString(1) : "";
                        fp.Apellidos = (!rd.IsDBNull(2)) ? rd.GetString(2) : "";
                        fp.Nombre = (!rd.IsDBNull(3)) ? rd.GetString(3) : "";
                        fp.FechaNacimiento = (!rd.IsDBNull(4)) ? rd.GetString(4) : "";
                        fp.Sexo = (!rd.IsDBNull(5)) ? rd.GetString(5) : "";
                        fp.Nacionalidad = (!rd.IsDBNull(6)) ? rd.GetString(6) : "";
                        fp.Direccion = (!rd.IsDBNull(7)) ? rd.GetString(7) : "";
                        fp.Telefono = (!rd.IsDBNull(8)) ? rd.GetString(8) : "";
                        fp.Email = (!rd.IsDBNull(9)) ? rd.GetString(9) : "";

                        list.Add(fp);
                    }
                    rd.Close();
                    command.Dispose();
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
            return list;
        }

        public static bool guardar(bool nuevo, FichaPreEgreso ficha)
        {
            String query = "";
            if (nuevo)
            {
                query = "INSERT INTO dbo.fichapreegreso(matricula, apellidos, nombre, fechaNacimiento, sexo, nacionalidad, direccion, telefono, email, idEgresado)" +
                       "VALUES(@matricula,@apellidos,@nombre,@fechaNacimiento,@sexo,@nacionalidad,@direccion,@telefono,@email,@idEgresado);";
            }
            else
            {
                query = "UPDATE dbo.fichapreegreso SET" +
                        "matricula = @matricula," +
                        "apellidos = @apellidos," +
                        "nombre = @nombre," +
                        "fechaNacimiento = @fechaNacimiento," +
                        "sexo = @sexo," +
                        "nacionalidad = @nacionalidad," +
                        "direccion = @direccion," +
                        "telefono = @telefono," +
                        "email = @email"+
                        "WHERE idFichaPreEgreso = @idFichaPreEgreso;";
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
                    command.Parameters.AddWithValue("@matricula", ficha.Matricula);
                    command.Parameters.AddWithValue("@apellidos", ficha.Apellidos);
                    command.Parameters.AddWithValue("@nombre", ficha.Nombre);
                    command.Parameters.AddWithValue("@fechaNacimiento", ficha.FechaNacimiento);
                    command.Parameters.AddWithValue("@sexo", ficha.Sexo);
                    command.Parameters.AddWithValue("@direccion", ficha.Direccion);
                    command.Parameters.AddWithValue("@telefono", ficha.Telefono);
                    command.Parameters.AddWithValue("@email", ficha.Email);
                    if (nuevo)
                    {
                        command.Parameters.AddWithValue("@idEgresado", ficha.IdEgresado);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@idFichaPreEgreso", ficha.IdFichaPreEgreso);
                    }
                    int i = command.ExecuteNonQuery();
                    Console.WriteLine("Rows affected: " + i);
                    if (i>0)
                    {
                        return true;
                    }
                    command.Dispose();
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
            return false;
        }

    }
}
