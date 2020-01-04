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
            InformacionLaboral informacionLaboral = new InformacionLaboral();
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
                                                 "x.cargoDesempeñado, " +
                                                 "x.tipoContrato, " +
                                                 "x.trabajoLigadoFormacion, " +
                                                 "x.tiempoPrimerEmpleo, " +
                                                 "x.promedioIngresoMensual, " +
                                                 "x.razonNoEncontrartrabajo, " +
                                                 "x.importanciaExperiencia, " +
                                                 "x.tipoOrganismo, " +
                                                 "x.conocimientosTeoricos, " +
                                                 "x.saberesHeuristicos, " +
                                                 "x.experienciaEducativaCursada, " +
                                                 "x.saberesTeoricosRespuesta1, " +
                                                 "x.saberesTeoricosRespuesta2, " +
                                                 "x.saberesTeoricosRespuesta3, " +
                                                 "x.saberesTeoricosRespuesta4, " +
                                                 "x.saberesTeoricosRespuesta5, " +
                                                 "x.saberesTeoricosRespuesta6, " +
                                                 "x.saberesTeoricosRespuesta7, " +
                                                 "x.saberesTeoricosRespuesta8, " +
                                                 "x.saberesTeoricosRespuesta9, " +
                                                 "x.saberesTeoricosRespuesta10, " +
                                                 "x.saberesHeuristicosRespuesta1, " +
                                                 "x.saberesHeuristicosRespuesta2, " +
                                                 "x.saberesHeuristicosRespuesta3, " +
                                                 "x.saberesHeuristicosRespuesta4, " +
                                                 "x.saberesHeuristicosRespuesta5, " +
                                                 "x.saberesHeuristicosRespuesta6, " +
                                                 "x.saberesHeuristicosRespuesta7, " +
                                                 "x.saberesAxiologicosRespuesta1, " +
                                                 "x.saberesAxiologicosRespuesta2, " +
                                                 "x.saberesAxiologicosRespuesta3, " +
                                                 "x.saberesAxiologicosRespuesta4, " +
                                                 "x.saberesAxiologicosRespuesta5, " +
                                                 "x.saberesAxiologicosRespuesta6, " +
                                                 "x.saberesAxiologicosRespuesta7, " +
                                                 "x.saberesAxiologicosRespuesta8, " +
                                                 "x.saberesAxiologicosRespuesta9, " +
                                                 "x.saberesAxiologicosRespuesta10, " +
                                                 "x.saberesAxiologicosRespuesta11, " +
                                                 "x.saberesAxiologicosRespuesta12, " +
                                                 "x.saberesAxiologicosRespuesta13, " +
                                                 "x.saberesAxiologicosRespuesta14, " +
                                                 "x.saberesAxiologicosRespuesta15, " +
                                                 "x.saberesAxiologicosRespuesta16, " +
                                                 "x.saberesAxiologicosRespuesta17, " +
                                                 "x.saberesAxiologicosRespuesta18, " +
                                                 "x.saberesAxiologicosRespuesta19, " +
                                                 "x.funcionesRealizadasRespuesta1, " +
                                                 "x.funcionesRealizadasRespuesta2, " +
                                                 "x.funcionesRealizadasRespuesta3, " +
                                                 "x.funcionesRealizadasRespuesta4, " +
                                                 "x.funcionesRealizadasRespuesta5, " +
                                                 "x.funcionesRealizadasRespuesta6, " +
                                                 "x.funcionesDesempeñadas, " +
                                                 "x.problematicasSolucionadas, " +
                                                 "x.propiaEmpresa, " +
                                                 "x.propiaEmpresaPorque, " +
                                                 "x.diferenciaConocimientoRespuesta1, " +
                                                 "x.diferenciaConocimientoRespuesta2, " +
                                                 "x.diferenciaConocimientoRespuesta3, " +
                                                 "x.diferenciaConocimientoRespuesta4, " +
                                                 "x.diferenciaConocimientoRespuesta5, " +
                                                 "x.diferenciaConocimientoRespuesta6, " +
                                                 "x.diferenciaConocimientoRespuesta7, " +
                                                 "x.diferenciaConocimientoRespuesta8, " +
                                                 "x.formacionProfesional, " +
                                                 "x.idPreguntaLaboral, " +
                                                 "x.idEgresado " +
                                                 "FROM dbo.InformacionLabora x " +
                                                 "WHERE x.idEgresado = '{0}';", idEgresado);
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        InformacionLaboral il = new InformacionLaboral();
                        il.IdInformacionLaboral = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                        il.CargoDesempenado = (!rd.IsDBNull(1)) ? rd.GetString(1) : "";
                        il.TipoContratacion = (!rd.IsDBNull(2)) ? rd.GetString(2) : "";
                        il.TrabajoLigadoFormacion = (!rd.IsDBNull(3)) ? rd.GetString(3) : "";
                        il.TiempoTranscurridoPrimerEmpleo = (!rd.IsDBNull(4)) ? rd.GetString(4) : "";
                        il.PromedioIngresoMensual = (!rd.IsDBNull(5)) ? rd.GetString(5) : "";
                        il.RazonNoEncontrartrabajo = (!rd.IsDBNull(6)) ? rd.GetString(6) : "";
                        il.ImportanciaExperiencia = (!rd.IsDBNull(7)) ? rd.GetString(7) : "";
                        il.TipoOrganismo = (!rd.IsDBNull(8)) ? rd.GetString(8) : "";
                        il.ConocimientosTeoricos = (!rd.IsDBNull(9)) ? rd.GetString(9) : "";
                        il.SaberesHeuristicos = (!rd.IsDBNull(10)) ? rd.GetString(10) : "";
                        il.ExperienciaEducativaCursada = (!rd.IsDBNull(11)) ? rd.GetString(11) : "";
                        il.SaberesTeoricosRespuesta1 = (!rd.IsDBNull(12)) ? rd.GetString(12) : "";
                        il.SaberesTeoricosRespuesta2 = (!rd.IsDBNull(13)) ? rd.GetString(13) : "";
                        il.SaberesTeoricosRespuesta3 = (!rd.IsDBNull(14)) ? rd.GetString(14) : "";
                        il.SaberesTeoricosRespuesta4 = (!rd.IsDBNull(15)) ? rd.GetString(15) : "";
                        il.SaberesTeoricosRespuesta5 = (!rd.IsDBNull(16)) ? rd.GetString(16) : "";
                        il.SaberesTeoricosRespuesta6 = (!rd.IsDBNull(17)) ? rd.GetString(17) : "";
                        il.SaberesTeoricosRespuesta7 = (!rd.IsDBNull(18)) ? rd.GetString(18) : "";
                        il.SaberesTeoricosRespuesta8 = (!rd.IsDBNull(19)) ? rd.GetString(19) : "";
                        il.SaberesTeoricosRespuesta9 = (!rd.IsDBNull(20)) ? rd.GetString(20) : "";
                        il.SaberesTeoricosRespuesta10 = (!rd.IsDBNull(21)) ? rd.GetString(21) : "";
                        il.SaberesHeuristicosRespuesta1 = (!rd.IsDBNull(22)) ? rd.GetString(22) : "";
                        il.SaberesHeuristicosRespuesta2 = (!rd.IsDBNull(23)) ? rd.GetString(23) : "";
                        il.SaberesHeuristicosRespuesta3 = (!rd.IsDBNull(24)) ? rd.GetString(24) : "";
                        il.SaberesHeuristicosRespuesta4 = (!rd.IsDBNull(25)) ? rd.GetString(25) : "";
                        il.SaberesHeuristicosRespuesta5 = (!rd.IsDBNull(26)) ? rd.GetString(26) : "";
                        il.SaberesHeuristicosRespuesta6 = (!rd.IsDBNull(27)) ? rd.GetString(27) : "";
                        il.SaberesHeuristicosRespuesta7 = (!rd.IsDBNull(28)) ? rd.GetString(28) : "";
                        il.SaberesAxiologicosRespuesta1 = (!rd.IsDBNull(29)) ? rd.GetString(29) : "";
                        il.SaberesAxiologicosRespuesta2 = (!rd.IsDBNull(30)) ? rd.GetString(30) : "";
                        il.SaberesAxiologicosRespuesta3 = (!rd.IsDBNull(31)) ? rd.GetString(31) : "";
                        il.SaberesAxiologicosRespuesta4 = (!rd.IsDBNull(32)) ? rd.GetString(32) : "";
                        il.SaberesAxiologicosRespuesta5 = (!rd.IsDBNull(33)) ? rd.GetString(33) : "";
                        il.SaberesAxiologicosRespuesta6 = (!rd.IsDBNull(34)) ? rd.GetString(34) : "";
                        il.SaberesAxiologicosRespuesta7 = (!rd.IsDBNull(35)) ? rd.GetString(35) : "";
                        il.SaberesAxiologicosRespuesta8 = (!rd.IsDBNull(36)) ? rd.GetString(36) : "";
                        il.SaberesAxiologicosRespuesta9 = (!rd.IsDBNull(37)) ? rd.GetString(37) : "";
                        il.SaberesAxiologicosRespuesta10 = (!rd.IsDBNull(38)) ? rd.GetString(38) : "";
                        il.SaberesAxiologicosRespuesta11 = (!rd.IsDBNull(39)) ? rd.GetString(39) : "";
                        il.SaberesAxiologicosRespuesta12 = (!rd.IsDBNull(40)) ? rd.GetString(40) : "";
                        il.SaberesAxiologicosRespuesta13 = (!rd.IsDBNull(41)) ? rd.GetString(41) : "";
                        il.SaberesAxiologicosRespuesta14 = (!rd.IsDBNull(42)) ? rd.GetString(42) : "";
                        il.SaberesAxiologicosRespuesta15 = (!rd.IsDBNull(43)) ? rd.GetString(43) : "";
                        il.SaberesAxiologicosRespuesta16 = (!rd.IsDBNull(44)) ? rd.GetString(44) : "";
                        il.SaberesAxiologicosRespuesta17 = (!rd.IsDBNull(45)) ? rd.GetString(45) : "";
                        il.SaberesAxiologicosRespuesta18 = (!rd.IsDBNull(46)) ? rd.GetString(46) : "";
                        il.SaberesAxiologicosRespuesta19 = (!rd.IsDBNull(47)) ? rd.GetString(47) : "";
                        il.FuncionesRealizadasRespuesta1 = (!rd.IsDBNull(48)) ? rd.GetString(48) : "";
                        il.FuncionesRealizadasRespuesta2 = (!rd.IsDBNull(49)) ? rd.GetString(49) : "";
                        il.FuncionesRealizadasRespuesta3 = (!rd.IsDBNull(50)) ? rd.GetString(50) : "";
                        il.FuncionesRealizadasRespuesta4 = (!rd.IsDBNull(51)) ? rd.GetString(51) : "";
                        il.FuncionesRealizadasRespuesta5 = (!rd.IsDBNull(52)) ? rd.GetString(52) : "";
                        il.FuncionesRealizadasRespuesta6 = (!rd.IsDBNull(53)) ? rd.GetString(53) : "";
                        il.FuncionesDesempenadas = (!rd.IsDBNull(54)) ? rd.GetString(54) : "";
                        il.ProblematicasSolucionadas = (!rd.IsDBNull(55)) ? rd.GetString(55) : "";
                        il.PropiaEmpresa = (!rd.IsDBNull(56)) ? rd.GetString(56) : "";
                        il.PropiaEmpresaPorque = (!rd.IsDBNull(57)) ? rd.GetString(57) : "";
                        il.DiferenciaConocimientoRespuesta1 = (!rd.IsDBNull(58)) ? rd.GetString(58) : "";
                        il.DiferenciaConocimientoRespuesta2 = (!rd.IsDBNull(59)) ? rd.GetString(59) : "";
                        il.DiferenciaConocimientoRespuesta3 = (!rd.IsDBNull(60)) ? rd.GetString(60) : "";
                        il.DiferenciaConocimientoRespuesta4 = (!rd.IsDBNull(61)) ? rd.GetString(61) : "";
                        il.DiferenciaConocimientoRespuesta5 = (!rd.IsDBNull(62)) ? rd.GetString(62) : "";
                        il.DiferenciaConocimientoRespuesta6 = (!rd.IsDBNull(63)) ? rd.GetString(63) : "";
                        il.DiferenciaConocimientoRespuesta7 = (!rd.IsDBNull(64)) ? rd.GetString(64) : "";
                        il.DiferenciaConocimientoRespuesta8 = (!rd.IsDBNull(65)) ? rd.GetString(65) : "";
                        il.FormacionProfesional = (!rd.IsDBNull(66)) ? rd.GetString(66) : "";
                        il.IdEgresado = (!rd.IsDBNull(68)) ? rd.GetInt32(68) : 68;
                    }
                    rd.Close();
                    command.Dispose();
                    Console.WriteLine(informacionLaboral);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("No se encontró Información Laboral del egresado");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return informacionLaboral;
        }

        public static bool guardar(InformacionLaboral informacionLaboral, bool nuevo)
        {
            String query = "";

            if (nuevo) {
                query = "INSERT INTO dbo.InformacionLabora (cargoDesempeñado, tipoContrato, trabajoLigadoFormacion, tiempoPrimerEmpleo, promedioIngresoMensual, razonNoEncontrarTrabajo, importanciaExperiencia, tipoOrganismo, conocimientosTeoricos, saberesHeuristicos, experienciaEducativaCursada, saberesTeoricosRespuesta1, saberesTeoricosRespuesta2, saberesTeoricosRespuesta3, saberesTeoricosRespuesta4, saberesTeoricosRespuesta5, saberesTeoricosRespuesta6, saberesTeoricosRespuesta7, saberesTeoricosRespuesta8, saberesTeoricosRespuesta9, saberesTeoricosRespuesta10, " +
                        "saberesHeuristicosRespuesta1, saberesHeuristicosRespuesta2, saberesHeuristicosRespuesta3, saberesHeuristicosRespuesta4, saberesHeuristicosRespuesta5, saberesHeuristicosRespuesta6, saberesHeuristicosRespuesta7, saberesAxiologicosRespuesta1, saberesAxiologicosRespuesta2, saberesAxiologicosRespuesta3, saberesAxiologicosRespuesta4, saberesAxiologicosRespuesta5, saberesAxiologicosRespuesta6, saberesAxiologicosRespuesta7, saberesAxiologicosRespuesta8, saberesAxiologicosRespuesta9, saberesAxiologicosRespuesta10, saberesAxiologicosRespuesta11, " +
                        "saberesAxiologicosRespuesta12, saberesAxiologicosRespuesta13, saberesAxiologicosRespuesta14, saberesAxiologicosRespuesta15, saberesAxiologicosRespuesta16, saberesAxiologicosRespuesta17, saberesAxiologicosRespuesta18, saberesAxiologicosRespuesta19, funcionesRealizadasRespuesta1, funcionesRealizadasRespuesta2, funcionesRealizadasRespuesta3, funcionesRealizadasRespuesta4, funcionesRealizadasRespuesta5, funcionesRealizadasRespuesta6, funcionesDesempeñadas, problematicasSolucionadas, propiaEmpresa, propiaEmpresaPorque, " +
                        "diferenciaConocimientoRespuesta1, diferenciaConocimientoRespuesta2, diferenciaConocimientoRespuesta3, diferenciaConocimientoRespuesta4, diferenciaConocimientoRespuesta5, diferenciaConocimientoRespuesta6, diferenciaConocimientoRespuesta7, diferenciaConocimientoRespuesta8, formacionProfesional,idEgresado) " +
                        "VALUES(@cargoDesempeñado, @tipoContrato, @trabajoLigadoFormacion, @tiempoPrimerEmpleo, @promedioIngresoMensual, @razonNoEncontrarTrabajo, @importanciaExperiencia, @tipoOrganismo, @conocimientosTeoricos, @saberesHeuristicos, @experienciaEducativaCursada, @saberesTeoricosRespuesta1, @saberesTeoricosRespuesta2, @saberesTeoricosRespuesta3, @saberesTeoricosRespuesta4, @saberesTeoricosRespuesta5, @saberesTeoricosRespuesta6, @saberesTeoricosRespuesta7, @saberesTeoricosRespuesta8, @saberesTeoricosRespuesta9, @saberesTeoricosRespuesta10, " +
                        "@saberesHeuristicosRespuesta1, @saberesHeuristicosRespuesta2, @saberesHeuristicosRespuesta3, @saberesHeuristicosRespuesta4, @saberesHeuristicosRespuesta5, @saberesHeuristicosRespuesta6, @saberesHeuristicosRespuesta7, @saberesAxiologicosRespuesta1, @saberesAxiologicosRespuesta2, @saberesAxiologicosRespuesta3, @saberesAxiologicosRespuesta4, @saberesAxiologicosRespuesta5, @saberesAxiologicosRespuesta6, @saberesAxiologicosRespuesta7, @saberesAxiologicosRespuesta8, @saberesAxiologicosRespuesta9, @saberesAxiologicosRespuesta10, @saberesAxiologicosRespuesta11, " +
                        "@saberesAxiologicosRespuesta12, @saberesAxiologicosRespuesta13, @saberesAxiologicosRespuesta14, @saberesAxiologicosRespuesta15, @saberesAxiologicosRespuesta16, @saberesAxiologicosRespuesta17, @saberesAxiologicosRespuesta18, @saberesAxiologicosRespuesta19, @funcionesRealizadasRespuesta1, @funcionesRealizadasRespuesta2, @funcionesRealizadasRespuesta3, @funcionesRealizadasRespuesta4, @funcionesRealizadasRespuesta5, @funcionesRealizadasRespuesta6, @funcionesDesempeñadas, @problematicasSolucionadas, @propiaEmpresa, @propiaEmpresaPorque, " +
                        "@diferenciaConocimientoRespuesta1, @diferenciaConocimientoRespuesta2, @diferenciaConocimientoRespuesta3, @diferenciaConocimientoRespuesta4, @diferenciaConocimientoRespuesta5, @diferenciaConocimientoRespuesta6, @diferenciaConocimientoRespuesta7, @diferenciaConocimientoRespuesta8, @formacionProfesional,@idEgresado);";
            }
            else
            {
                query = "UPDATE dbo.InformacionLabora SET " +
                    "cargoDesempeñado = @cargoDesempeñado, " +
                    "tipoContrato = @tipoContrato, " +
                    "trabajoLigadoFormacion = @trabajoLigadoFormacion, " +
                    "tiempoPrimerEmpleo = @tiempoPrimerEmpleo, " +
                    "promedioIngresoMensual = @promedioIngresoMensual, " +
                    "razonNoEncontrartrabajo = @razonNoEncontrartrabajo, " +
                    "importanciaExperiencia = @importanciaExperiencia, " +
                    "tipoOrganismo = @tipoOrganismo, " +
                    "conocimientosTeoricos = @conocimientosTeoricos, " +
                    "saberesHeuristicos = @saberesHeuristicos, " +
                    "experienciaEducativaCursada = @experienciaEducativaCursada, " +
                    "saberesTeoricosRespuesta1 = @saberesTeoricosRespuesta1, " +
                    "saberesTeoricosRespuesta2 = @saberesTeoricosRespuesta2, " +
                    "saberesTeoricosRespuesta3 = @saberesTeoricosRespuesta3, " +
                    "saberesTeoricosRespuesta4 = @saberesTeoricosRespuesta4, " +
                    "saberesTeoricosRespuesta5 = @saberesTeoricosRespuesta5, " +
                    "saberesTeoricosRespuesta6 = @saberesTeoricosRespuesta6, " +
                    "saberesTeoricosRespuesta7 = @saberesTeoricosRespuesta7, " +
                    "saberesTeoricosRespuesta8 = @saberesTeoricosRespuesta8, " +
                    "saberesTeoricosRespuesta9 = @saberesTeoricosRespuesta9, " +
                    "saberesTeoricosRespuesta10 = @saberesTeoricosRespuesta10, " +
                    "saberesHeuristicosRespuesta1 = @saberesHeuristicosRespuesta1, " +
                    "saberesHeuristicosRespuesta2 = @saberesHeuristicosRespuesta2, " +
                    "saberesHeuristicosRespuesta3 = @saberesHeuristicosRespuesta3, " +
                    "saberesHeuristicosRespuesta4 = @saberesHeuristicosRespuesta4, " +
                    "saberesHeuristicosRespuesta5 = @saberesHeuristicosRespuesta5, " +
                    "saberesHeuristicosRespuesta6 = @saberesHeuristicosRespuesta6, " +
                    "saberesHeuristicosRespuesta7 = @saberesHeuristicosRespuesta7, " +
                    "saberesAxiologicosRespuesta1 = @saberesAxiologicosRespuesta1, " +
                    "saberesAxiologicosRespuesta2 = @saberesAxiologicosRespuesta2, " +
                    "saberesAxiologicosRespuesta3 = @saberesAxiologicosRespuesta3, " +
                    "saberesAxiologicosRespuesta4 = @saberesAxiologicosRespuesta4, " +
                    "saberesAxiologicosRespuesta5 = @saberesAxiologicosRespuesta5, " +
                    "saberesAxiologicosRespuesta6 = @saberesAxiologicosRespuesta6, " +
                    "saberesAxiologicosRespuesta7 = @saberesAxiologicosRespuesta7, " +
                    "saberesAxiologicosRespuesta8 = @saberesAxiologicosRespuesta8, " +
                    "saberesAxiologicosRespuesta9 = @saberesAxiologicosRespuesta9, " +
                    "saberesAxiologicosRespuesta10 = @saberesAxiologicosRespuesta10, " +
                    "saberesAxiologicosRespuesta11 = @saberesAxiologicosRespuesta11, " +
                    "saberesAxiologicosRespuesta12 = @saberesAxiologicosRespuesta12, " +
                    "saberesAxiologicosRespuesta13 = @saberesAxiologicosRespuesta13, " +
                    "saberesAxiologicosRespuesta14 = @saberesAxiologicosRespuesta14, " +
                    "saberesAxiologicosRespuesta15 = @saberesAxiologicosRespuesta15, " +
                    "saberesAxiologicosRespuesta16 = @saberesAxiologicosRespuesta16, " +
                    "saberesAxiologicosRespuesta17 = @saberesAxiologicosRespuesta17, " +
                    "saberesAxiologicosRespuesta18 = @saberesAxiologicosRespuesta18, " +
                    "saberesAxiologicosRespuesta19 = @saberesAxiologicosRespuesta19, " +
                    "funcionesRealizadasRespuesta1 = @funcionesRealizadasRespuesta1, " +
                    "funcionesRealizadasRespuesta2 = @funcionesRealizadasRespuesta2, " +
                    "funcionesRealizadasRespuesta3 = @funcionesRealizadasRespuesta3, " +
                    "funcionesRealizadasRespuesta4 = @funcionesRealizadasRespuesta4, " +
                    "funcionesRealizadasRespuesta5 = @funcionesRealizadasRespuesta5, " +
                    "funcionesRealizadasRespuesta6 = @funcionesRealizadasRespuesta6, " +
                    "funcionesDesempeñadas = @funcionesDesempeñadas, " +
                    "problematicasSolucionadas = @problematicasSolucionadas, " +
                    "propiaEmpresa = @propiaEmpresa, " +
                    "propiaEmpresaPorque = @propiaEmpresaPorque, " +
                    "diferenciaConocimientoRespuesta1 = @diferenciaConocimientoRespuesta1, " +
                    "diferenciaConocimientoRespuesta2 = @diferenciaConocimientoRespuesta2, " +
                    "diferenciaConocimientoRespuesta3 = @diferenciaConocimientoRespuesta3, " +
                    "diferenciaConocimientoRespuesta4 = @diferenciaConocimientoRespuesta4, " +
                    "diferenciaConocimientoRespuesta5 = @diferenciaConocimientoRespuesta5, " +
                    "diferenciaConocimientoRespuesta6 = @diferenciaConocimientoRespuesta6, " +
                    "diferenciaConocimientoRespuesta7 = @diferenciaConocimientoRespuesta7, " +
                    "diferenciaConocimientoRespuesta8 = @diferenciaConocimientoRespuesta8, " +
                    "formacionProfesional = @formacionProfesional " +
                    "WHERE idInformacionLabora = @idInformacionLabora;";
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
                    command.Parameters.AddWithValue("@cargoDesempeñado", informacionLaboral.CargoDesempenado);
                    command.Parameters.AddWithValue("@tipoContrato", informacionLaboral.TipoContratacion);
                    command.Parameters.AddWithValue("@trabajoLigadoFormacion", informacionLaboral.TrabajoLigadoFormacion);
                    command.Parameters.AddWithValue("@tiempoPrimerEmpleo", informacionLaboral.TiempoTranscurridoPrimerEmpleo);
                    command.Parameters.AddWithValue("@promedioIngresoMensual", informacionLaboral.PromedioIngresoMensual);
                    command.Parameters.AddWithValue("@razonNoEncontrartrabajo", informacionLaboral.RazonNoEncontrartrabajo);
                    command.Parameters.AddWithValue("@importanciaExperiencia", informacionLaboral.ImportanciaExperiencia);
                    command.Parameters.AddWithValue("@tipoOrganismo", informacionLaboral.TipoOrganismo);
                    command.Parameters.AddWithValue("@conocimientosTeoricos", informacionLaboral.ConocimientosTeoricos);
                    command.Parameters.AddWithValue("@saberesHeuristicos", informacionLaboral.SaberesHeuristicos);
                    command.Parameters.AddWithValue("@experienciaEducativaCursada", informacionLaboral.ExperienciaEducativaCursada);
                    command.Parameters.AddWithValue("@saberesTeoricosRespuesta1", informacionLaboral.SaberesTeoricosRespuesta1);
                    command.Parameters.AddWithValue("@saberesTeoricosRespuesta2", informacionLaboral.SaberesTeoricosRespuesta2);
                    command.Parameters.AddWithValue("@saberesTeoricosRespuesta3", informacionLaboral.SaberesTeoricosRespuesta3);
                    command.Parameters.AddWithValue("@saberesTeoricosRespuesta4", informacionLaboral.SaberesTeoricosRespuesta4);
                    command.Parameters.AddWithValue("@saberesTeoricosRespuesta5", informacionLaboral.SaberesTeoricosRespuesta5);
                    command.Parameters.AddWithValue("@saberesTeoricosRespuesta6", informacionLaboral.SaberesTeoricosRespuesta6);
                    command.Parameters.AddWithValue("@saberesTeoricosRespuesta7", informacionLaboral.SaberesTeoricosRespuesta7);
                    command.Parameters.AddWithValue("@saberesTeoricosRespuesta8", informacionLaboral.SaberesTeoricosRespuesta8);
                    command.Parameters.AddWithValue("@saberesTeoricosRespuesta9", informacionLaboral.SaberesTeoricosRespuesta9);
                    command.Parameters.AddWithValue("@saberesTeoricosRespuesta10", informacionLaboral.SaberesTeoricosRespuesta10);
                    command.Parameters.AddWithValue("@saberesHeuristicosRespuesta1", informacionLaboral.SaberesHeuristicosRespuesta1);
                    command.Parameters.AddWithValue("@saberesHeuristicosRespuesta2", informacionLaboral.SaberesHeuristicosRespuesta2);
                    command.Parameters.AddWithValue("@saberesHeuristicosRespuesta3", informacionLaboral.SaberesHeuristicosRespuesta3);
                    command.Parameters.AddWithValue("@saberesHeuristicosRespuesta4", informacionLaboral.SaberesHeuristicosRespuesta4);
                    command.Parameters.AddWithValue("@saberesHeuristicosRespuesta5", informacionLaboral.SaberesHeuristicosRespuesta5);
                    command.Parameters.AddWithValue("@saberesHeuristicosRespuesta6", informacionLaboral.SaberesHeuristicosRespuesta6);
                    command.Parameters.AddWithValue("@saberesHeuristicosRespuesta7", informacionLaboral.SaberesHeuristicosRespuesta7);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta1", informacionLaboral.SaberesAxiologicosRespuesta1);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta2", informacionLaboral.SaberesAxiologicosRespuesta2);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta3", informacionLaboral.SaberesAxiologicosRespuesta3);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta4", informacionLaboral.SaberesAxiologicosRespuesta4);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta5", informacionLaboral.SaberesAxiologicosRespuesta5);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta6", informacionLaboral.SaberesAxiologicosRespuesta6);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta7", informacionLaboral.SaberesAxiologicosRespuesta7);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta8", informacionLaboral.SaberesAxiologicosRespuesta8);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta9", informacionLaboral.SaberesAxiologicosRespuesta9);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta10", informacionLaboral.SaberesAxiologicosRespuesta10);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta11", informacionLaboral.SaberesAxiologicosRespuesta11);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta12", informacionLaboral.SaberesAxiologicosRespuesta12);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta13", informacionLaboral.SaberesAxiologicosRespuesta13);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta14", informacionLaboral.SaberesAxiologicosRespuesta14);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta15", informacionLaboral.SaberesAxiologicosRespuesta15);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta16", informacionLaboral.SaberesAxiologicosRespuesta16);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta17", informacionLaboral.SaberesAxiologicosRespuesta17);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta18", informacionLaboral.SaberesAxiologicosRespuesta18);
                    command.Parameters.AddWithValue("@saberesAxiologicosRespuesta19", informacionLaboral.SaberesAxiologicosRespuesta19);
                    command.Parameters.AddWithValue("@funcionesRealizadasRespuesta1", informacionLaboral.FuncionesRealizadasRespuesta1);
                    command.Parameters.AddWithValue("@funcionesRealizadasRespuesta2", informacionLaboral.FuncionesRealizadasRespuesta2);
                    command.Parameters.AddWithValue("@funcionesRealizadasRespuesta3", informacionLaboral.FuncionesRealizadasRespuesta3);
                    command.Parameters.AddWithValue("@funcionesRealizadasRespuesta4", informacionLaboral.FuncionesRealizadasRespuesta4);
                    command.Parameters.AddWithValue("@funcionesRealizadasRespuesta5", informacionLaboral.FuncionesRealizadasRespuesta5);
                    command.Parameters.AddWithValue("@funcionesRealizadasRespuesta6", informacionLaboral.FuncionesRealizadasRespuesta6);
                    command.Parameters.AddWithValue("@funcionesDesempeñadas", informacionLaboral.FuncionesDesempenadas);
                    command.Parameters.AddWithValue("@problematicasSolucionadas", informacionLaboral.ProblematicasSolucionadas);
                    command.Parameters.AddWithValue("@propiaEmpresa", informacionLaboral.PropiaEmpresa);
                    command.Parameters.AddWithValue("@propiaEmpresaPorque", informacionLaboral.PropiaEmpresaPorque);
                    command.Parameters.AddWithValue("@diferenciaConocimientoRespuesta1", informacionLaboral.DiferenciaConocimientoRespuesta1);
                    command.Parameters.AddWithValue("@diferenciaConocimientoRespuesta2", informacionLaboral.DiferenciaConocimientoRespuesta2);
                    command.Parameters.AddWithValue("@diferenciaConocimientoRespuesta3", informacionLaboral.DiferenciaConocimientoRespuesta3);
                    command.Parameters.AddWithValue("@diferenciaConocimientoRespuesta4", informacionLaboral.DiferenciaConocimientoRespuesta4);
                    command.Parameters.AddWithValue("@diferenciaConocimientoRespuesta5", informacionLaboral.DiferenciaConocimientoRespuesta5);
                    command.Parameters.AddWithValue("@diferenciaConocimientoRespuesta6", informacionLaboral.DiferenciaConocimientoRespuesta6);
                    command.Parameters.AddWithValue("@diferenciaConocimientoRespuesta7", informacionLaboral.DiferenciaConocimientoRespuesta7);
                    command.Parameters.AddWithValue("@diferenciaConocimientoRespuesta8", informacionLaboral.DiferenciaConocimientoRespuesta8);
                    command.Parameters.AddWithValue("@formacionProfesional", informacionLaboral.FormacionProfesional);

                    if (nuevo)
                    {
                        command.Parameters.AddWithValue("@idEgresado", informacionLaboral.IdEgresado);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@idInformacionLabora", informacionLaboral.IdInformacionLaboral);
                    }

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
