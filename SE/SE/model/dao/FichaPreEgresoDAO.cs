﻿using System;
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
    /*
     * Clase DAO para la conexion con la base de datos
     * con la FIchaPreEgreso
     */
    public class FichaPreEgresoDAO
    {

        public static FichaPreEgreso getFichaPreEgresoByIdEgresado(Int32 idEgresado)
        {
            FichaPreEgreso egresado = new FichaPreEgreso();
            SqlConnection conn = null;
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT "+
                                                "x.idFichaPreEgreso, "+
                                                "x.fechaNacimiento, "+
                                                "x.sexo, "+
                                                "x.nacionalidad, "+
                                                "x.telefono, "+
                                                "x.email, "+
                                                "x.calle, "+
                                                "x.numeroCasa, " +
                                                "x.colonia, " +
                                                "x.ciudad, " +
                                                "x.estado, " +
                                                "x.codigoPostal, " +
                                                "x.idEgresado " +
                                                "FROM dbo.FichaPreEgreso x " +
                                                "WHERE x.idEgresado = '{0}';", idEgresado);
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        FichaPreEgreso fp = new FichaPreEgreso();
                        fp.IdFichaPreEgreso = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                        fp.FechaNacimiento = (!rd.IsDBNull(1)) ? rd.GetDateTime(1) : new DateTime();
                        fp.Sexo = (!rd.IsDBNull(2)) ? rd.GetString(2) : "";
                        fp.Nacionalidad = (!rd.IsDBNull(3)) ? rd.GetString(3) : "";
                        fp.Telefono = (!rd.IsDBNull(4)) ? rd.GetString(4) : "";
                        fp.Email = (!rd.IsDBNull(5)) ? rd.GetString(5) : "";
                        fp.Calle = (!rd.IsDBNull(6)) ? rd.GetString(6) : "";
                        fp.NumeroCasa = (!rd.IsDBNull(7)) ? rd.GetString(7) : "";
                        fp.Colonia = (!rd.IsDBNull(8)) ? rd.GetString(8) : "";
                        fp.Ciudad = (!rd.IsDBNull(9)) ? rd.GetString(9) : "";
                        fp.Estado = (!rd.IsDBNull(10)) ? rd.GetString(10) : "";
                        fp.CodigoPostal = (!rd.IsDBNull(11)) ? rd.GetString(11) : "";
                        fp.IdEgresado = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                    }
                    rd.Close();
                    command.Dispose();
                    Console.WriteLine(egresado);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("No se encontro ficha del egresado");
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

        public static FichaPreEgreso obtenerFichaPreEgreso(Int32 idEgresado)
        {
            FichaPreEgreso fp = null;
            SqlConnection conn = null;
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT " +
                                                "x.idFichaPreEgreso, " +
                                                "x.fechaNacimiento, " +
                                                "x.sexo, " +
                                                "x.nacionalidad, " +
                                                "x.telefono, " +
                                                "x.email, " +
                                                "x.calle, " +
                                                "x.numeroCasa, " +
                                                "x.colonia, " +
                                                "x.ciudad, " +
                                                "x.estado, " +
                                                "x.codigoPostal, " +
                                                "x.idEgresado " +
                                                "FROM dbo.FichaPreEgreso x " +
                                                "WHERE x.idEgresado = '{0}';", idEgresado);
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        fp = new FichaPreEgreso();
                        fp.IdFichaPreEgreso = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                        fp.FechaNacimiento = (!rd.IsDBNull(1)) ? rd.GetDateTime(1) : new DateTime();
                        fp.Sexo = (!rd.IsDBNull(2)) ? rd.GetString(2) : "";
                        fp.Nacionalidad = (!rd.IsDBNull(3)) ? rd.GetString(3) : "";
                        fp.Telefono = (!rd.IsDBNull(4)) ? rd.GetString(4) : "";
                        fp.Email = (!rd.IsDBNull(5)) ? rd.GetString(5) : "";
                        fp.Calle = (!rd.IsDBNull(6)) ? rd.GetString(6) : "";
                        fp.NumeroCasa = (!rd.IsDBNull(7)) ? rd.GetString(7) : "";
                        fp.Colonia = (!rd.IsDBNull(8)) ? rd.GetString(8) : "";
                        fp.Ciudad = (!rd.IsDBNull(9)) ? rd.GetString(9) : "";
                        fp.Estado = (!rd.IsDBNull(10)) ? rd.GetString(10) : "";
                        fp.CodigoPostal = (!rd.IsDBNull(11)) ? rd.GetString(11) : "";
                        fp.IdEgresado = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                    }
                    rd.Close();
                    command.Dispose();
                    Console.WriteLine(fp);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("No se encontro ficha del egresado");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return fp;
        }

        public static bool guardar(FichaPreEgreso ficha, bool nuevo)
        {
            String query = "";
            if (nuevo)
            {

                query = "INSERT INTO dbo.FichaPreEgreso (fechaNacimiento,sexo,nacionalidad,telefono,email,calle,numeroCasa,colonia,ciudad,estado,codigoPostal,idEgresado) " +
                       "VALUES(GETDATE(),@sexo,@nacionalidad,@telefono,@email,@calle,@numeroCasa,@colonia,@ciudad,@estado,@codigoPostal,@idEgresado);";
            }
            else
            {
                query = "UPDATE dbo.FichaPreEgreso SET " +
                        "fechaNacimiento= @fechaNacimiento, " +
                        "sexo=@sexo, " +
                        "nacionalidad=@nacionalidad, " +
                        "telefono=@telefono, " +
                        "email=@email, " +
                        "calle=@calle, " +
                        "numeroCasa=@numeroCasa, " +
                        "colonia=@colonia, " +
                        "ciudad=@ciudad, " +
                        "estado=@estado, " +
                        "codigoPostal=@codigoPostal " +
                        "WHERE idFichaPreEgreso=@idFichaPreEgreso;";
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
                    command.Parameters.AddWithValue("@sexo", ficha.Sexo);
                    command.Parameters.AddWithValue("@nacionalidad", ficha.Nacionalidad);
                    command.Parameters.AddWithValue("@telefono", ficha.Telefono);
                    command.Parameters.AddWithValue("@email", ficha.Email);
                    command.Parameters.AddWithValue("@calle", ficha.Calle);
                    command.Parameters.AddWithValue("@numeroCasa", ficha.NumeroCasa);
                    command.Parameters.AddWithValue("@colonia", ficha.Colonia);
                    command.Parameters.AddWithValue("@ciudad", ficha.Ciudad);
                    command.Parameters.AddWithValue("@estado", ficha.Estado);
                    command.Parameters.AddWithValue("@codigoPostal", ficha.CodigoPostal);

                    if (nuevo)
                    {
                        command.Parameters.AddWithValue("@idEgresado", ficha.IdEgresado);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@idFichaPreEgreso", ficha.IdFichaPreEgreso);
                    }


                    int i = command.ExecuteNonQuery();
                    Console.WriteLine("Filas afectadas: " + i);
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
