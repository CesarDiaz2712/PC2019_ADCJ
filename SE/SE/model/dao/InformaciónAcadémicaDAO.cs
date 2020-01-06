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
    public class InformaciónAcadémicaDAO
    {
        public static InformacionAcademica obtenerInformacionAcademicaByIdEgresado(Int32 idEgresado)
        {
            InformacionAcademica informacionAcademica = null;
            SqlConnection conn = null;
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;
                SqlDataReader rd;
                if (conn != null)
                {
                    String query = String.Format("SELECT " +
                                                 "x.idInformacionAcademica, " +
                                                 "x.ingresoLicenciatura, " +
                                                 "x.egresoLicenciatrua, " +
                                                 "x.formacionActual, " +
                                                 "x.planDeEstudios, " +
                                                 "x.desempeñoDocentes, " +
                                                 "x.organizacionAdministrativa, " +
                                                 "x.instalacion, " +
                                                 "x.serviciosApoyo, " +
                                                 "x.actCulturalesYDeportivas, " +
                                                 "x.ingles1, " +
                                                 "x.ingles2, " +
                                                 "x.computacionBasica, " +
                                                 "x.lecturaRedaccion, " +
                                                 "x.habilidadesPensamiento, " +
                                                 "x.algebraLineal, " +
                                                 "x.probabilidad, " +
                                                 "x.matematicasDiscretas, " +
                                                 "x.algoritmosEstucturasDatos1, " +
                                                 "x.arquitecturaComputadoras1, " +
                                                 "x.metodologiaInvestigacion, " +
                                                 "x.logica, " +
                                                 "x.calculo, " +
                                                 "x.redes1, " +
                                                 "x.redes2, " +
                                                 "x.ingenieriaSoftware1, " +
                                                 "x.ingenieriaSoftware2, " +
                                                 "x.basesDatos1, " +
                                                 "x.basesDatos2, " +
                                                 "x.tallerIntegracion1, " +
                                                 "x.sistemasOperativos, " +
                                                 "x.arquitecturaComputadoras2, " +
                                                 "x.algoritmosEstructurasDatos2, " +
                                                 "x.organizacionArchivos, " +
                                                 "x.inteligenciaArtificial, " +
                                                 "x.tallerIntegracion2, " +
                                                 "x.tallerIntegracion3, " +
                                                 "x.programacionAvanzada, " +
                                                 "x.programacionDeSistemas, " +
                                                 "x.eticaLegislacionInformatica, " +
                                                 "x.fundamentosAdministracion, " +
                                                 "x.administracionProyectos, " +
                                                 "x.compiladores, " +
                                                 "x.administracionRecursosInformaticos, " +
                                                 "x.servicioSocial, " +
                                                 "x.experienciaRecepcional, " +
                                                 "x.desarrolloAplicacionesEnRed, " +
                                                 "x.ingenieriaSoftware3, " +
                                                 "x.graficacion, " +
                                                 "x.sistemasInformacionEmpresarial, " +
                                                 "x.administracionSeguridadDeServiciosEnRed, " +
                                                 "x.topicosSelectos1, " +
                                                 "x.topicosSelectos2, " +
                                                 "x.topicosSelectos3, " +
                                                 "x.topicosSelectos4, " +
                                                 "x.sistemasInformacionGeografica, " +
                                                 "x.multimedia, " +
                                                 "x.auditoriaInformatica, " +
                                                 "x.tallerIntegracion4, " +
                                                 "x.redes3, " +
                                                 "x.idEgresado " +
                                                 "FROM dbo.InformacionAcademica x " +
                                                 "WHERE x.idEgresado = '{0}';", idEgresado);
                    Console.WriteLine(query);
                    command = new SqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        informacionAcademica = new InformacionAcademica();
                        informacionAcademica.IdInformacionAcademica = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                        informacionAcademica.IngresoLicenciatura = (!rd.IsDBNull(1)) ? rd.GetString(1) : "";
                        informacionAcademica.EgresoLicenciatrua = (!rd.IsDBNull(2)) ? rd.GetString(2) : "";
                        informacionAcademica.FormacionActual = (!rd.IsDBNull(3)) ? rd.GetString(3) : "";
                        informacionAcademica.PlanDeEstudios = (!rd.IsDBNull(4)) ? rd.GetString(4) : "";
                        informacionAcademica.DesempeñoDocentes = (!rd.IsDBNull(5)) ? rd.GetString(5) : "";
                        informacionAcademica.OrganizacionAdministrativa = (!rd.IsDBNull(6)) ? rd.GetString(6) : "";
                        informacionAcademica.Instalacion = (!rd.IsDBNull(7)) ? rd.GetString(7) : "";
                        informacionAcademica.ServiciosApoyo = (!rd.IsDBNull(8)) ? rd.GetString(8) : "";
                        informacionAcademica.ActCulturalesYDeportivas = (!rd.IsDBNull(9)) ? rd.GetString(9) : "";
                        informacionAcademica.Ingles1 = (!rd.IsDBNull(10)) ? rd.GetString(10) : "";
                        informacionAcademica.Ingles2 = (!rd.IsDBNull(11)) ? rd.GetString(11) : "";
                        informacionAcademica.ComputacionBasica = (!rd.IsDBNull(12)) ? rd.GetString(12) : "";
                        informacionAcademica.LecturaRedaccion = (!rd.IsDBNull(13)) ? rd.GetString(13) : "";
                        informacionAcademica.HabilidadesPensamiento = (!rd.IsDBNull(14)) ? rd.GetString(14) : "";
                        informacionAcademica.AlgebraLineal = (!rd.IsDBNull(15)) ? rd.GetString(15) : "";
                        informacionAcademica.Probabilidad = (!rd.IsDBNull(16)) ? rd.GetString(16) : "";
                        informacionAcademica.MatematicasDiscretas = (!rd.IsDBNull(17)) ? rd.GetString(17) : "";
                        informacionAcademica.AlgoritmosEstucturasDatos1 = (!rd.IsDBNull(18)) ? rd.GetString(18) : "";
                        informacionAcademica.ArquitecturaComputadoras1 = (!rd.IsDBNull(19)) ? rd.GetString(19) : "";
                        informacionAcademica.MetodologiaInvestigacion = (!rd.IsDBNull(20)) ? rd.GetString(20) : "";
                        informacionAcademica.Logica = (!rd.IsDBNull(21)) ? rd.GetString(21) : "";
                        informacionAcademica.Calculo = (!rd.IsDBNull(22)) ? rd.GetString(22) : "";
                        informacionAcademica.Redes1 = (!rd.IsDBNull(23)) ? rd.GetString(23) : "";
                        informacionAcademica.Redes2 = (!rd.IsDBNull(24)) ? rd.GetString(24) : "";
                        informacionAcademica.IngenieriaSoftware1 = (!rd.IsDBNull(25)) ? rd.GetString(25) : "";
                        informacionAcademica.IngenieriaSoftware2 = (!rd.IsDBNull(26)) ? rd.GetString(26) : "";
                        informacionAcademica.BasesDatos1 = (!rd.IsDBNull(27)) ? rd.GetString(27) : "";
                        informacionAcademica.BasesDatos2 = (!rd.IsDBNull(28)) ? rd.GetString(28) : "";
                        informacionAcademica.TallerIntegracion1 = (!rd.IsDBNull(29)) ? rd.GetString(29) : "";
                        informacionAcademica.SistemasOperativos = (!rd.IsDBNull(30)) ? rd.GetString(30) : "";
                        informacionAcademica.ArquitecturaComputadoras2 = (!rd.IsDBNull(31)) ? rd.GetString(31) : "";
                        informacionAcademica.AlgoritmosEstructurasDatos2 = (!rd.IsDBNull(32)) ? rd.GetString(32) : "";
                        informacionAcademica.OrganizacionArchivos = (!rd.IsDBNull(33)) ? rd.GetString(33) : "";
                        informacionAcademica.InteligenciaArtificial = (!rd.IsDBNull(34)) ? rd.GetString(34) : "";
                        informacionAcademica.TallerIntegracion2 = (!rd.IsDBNull(35)) ? rd.GetString(35) : "";
                        informacionAcademica.TallerIntegracion3 = (!rd.IsDBNull(36)) ? rd.GetString(36) : "";
                        informacionAcademica.ProgramacionAvanzada = (!rd.IsDBNull(37)) ? rd.GetString(37) : "";
                        informacionAcademica.ProgramacionDeSistemas = (!rd.IsDBNull(38)) ? rd.GetString(38) : "";
                        informacionAcademica.EticaLegislacionInformatica = (!rd.IsDBNull(39)) ? rd.GetString(39) : "";
                        informacionAcademica.FundamentosAdministracion = (!rd.IsDBNull(40)) ? rd.GetString(40) : "";
                        informacionAcademica.AdministracionProyectos = (!rd.IsDBNull(41)) ? rd.GetString(41) : "";
                        informacionAcademica.Compiladores = (!rd.IsDBNull(42)) ? rd.GetString(42) : "";
                        informacionAcademica.AdministracionRecursosInformaticos = (!rd.IsDBNull(43)) ? rd.GetString(43) : "";
                        informacionAcademica.ServicioSocial = (!rd.IsDBNull(44)) ? rd.GetString(44) : "";
                        informacionAcademica.ExperienciaRecepcional = (!rd.IsDBNull(45)) ? rd.GetString(45) : "";
                        informacionAcademica.DesarrolloAplicacionesEnRed = (!rd.IsDBNull(46)) ? rd.GetString(46) : "";
                        informacionAcademica.IngenieriaSoftware3 = (!rd.IsDBNull(47)) ? rd.GetString(47) : "";
                        informacionAcademica.Graficacion = (!rd.IsDBNull(48)) ? rd.GetString(48) : "";
                        informacionAcademica.SistemasInformacionEmpresarial = (!rd.IsDBNull(49)) ? rd.GetString(49) : "";
                        informacionAcademica.AdministracionSeguridadDeServiciosEnRed = (!rd.IsDBNull(50)) ? rd.GetString(50) : "";
                        informacionAcademica.TopicosSelectos1 = (!rd.IsDBNull(51)) ? rd.GetString(51) : "";
                        informacionAcademica.TopicosSelectos2 = (!rd.IsDBNull(52)) ? rd.GetString(52) : "";
                        informacionAcademica.TopicosSelectos3 = (!rd.IsDBNull(53)) ? rd.GetString(53) : "";
                        informacionAcademica.TopicosSelectos4 = (!rd.IsDBNull(54)) ? rd.GetString(54) : "";
                        informacionAcademica.SistemasInformacionGeografica = (!rd.IsDBNull(55)) ? rd.GetString(55) : "";
                        informacionAcademica.Multimedia = (!rd.IsDBNull(56)) ? rd.GetString(56) : "";
                        informacionAcademica.AuditoriaInformatica = (!rd.IsDBNull(57)) ? rd.GetString(57) : "";
                        informacionAcademica.TallerIntegracion4 = (!rd.IsDBNull(58)) ? rd.GetString(58) : "";
                        informacionAcademica.Redes3 = (!rd.IsDBNull(59)) ? rd.GetString(59) : "";
                        informacionAcademica.IdEgresado = (!rd.IsDBNull(0)) ? rd.GetInt32(0) : 0;
                    }
                    rd.Close();
                    command.Dispose();
                    Console.WriteLine(informacionAcademica);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("No se encontró Información Académica del egresado");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return informacionAcademica;
        }

        public static bool guardar(InformacionAcademica informacionAcademica, bool nuevo)
        {

            String query = "";

            if (nuevo)
            {
                query = "INSERT INTO dbo.InformacionAcademica (ingresoLicenciatura,egresoLicenciatrua,formacionActual,planDeEstudios,desempeñoDocentes,organizacionAdministrativa,instalacion,serviciosApoyo,actCulturalesYDeportivas,ingles1,ingles2,computacionBasica,lecturaRedaccion,habilidadesPensamiento,algebraLineal,probabilidad,matematicasDiscretas,algoritmosEstucturasDatos1,arquitecturaComputadoras1,metodologiaInvestigacion," +
                    "logica,calculo,redes1,redes2,ingenieriaSoftware1,ingenieriaSoftware2,basesDatos1,basesDatos2,tallerIntegracion1,sistemasOperativos,arquitecturaComputadoras2,algoritmosEstructurasDatos2,organizacionArchivos,inteligenciaArtificial,tallerIntegracion2,tallerIntegracion3,programacionAvanzada,programacionDeSistemas,eticaLegislacionInformatica,fundamentosAdministracion,administracionProyectos,compiladores," +
                    "administracionRecursosInformaticos,servicioSocial,experienciaRecepcional,desarrolloAplicacionesEnRed,ingenieriaSoftware3,graficacion,sistemasInformacionEmpresarial,administracionSeguridadDeServiciosEnRed,topicosSelectos1,topicosSelectos2,topicosSelectos3,topicosSelectos4,sistemasInformacionGeografica,multimedia,auditoriaInformatica,tallerIntegracion4,redes3,idEgresado) " +
                    "VALUES(@ingresoLicenciatura,@egresoLicenciatrua,@formacionActual,@planDeEstudios,@desempeñoDocentes,@organizacionAdministrativa,@instalacion,@serviciosApoyo,@actCulturalesYDeportivas,@ingles1,@ingles2,@computacionBasica,@lecturaRedaccion,@habilidadesPensamiento,@algebraLineal,@probabilidad,@matematicasDiscretas,@algoritmosEstucturasDatos1,@arquitecturaComputadoras1,@metodologiaInvestigacion," +
                    "@logica,@calculo,@redes1,@redes2,@ingenieriaSoftware1,@ingenieriaSoftware2,@basesDatos1,@basesDatos2,@tallerIntegracion1,@sistemasOperativos,@arquitecturaComputadoras2,@algoritmosEstructurasDatos2,@organizacionArchivos,@inteligenciaArtificial,@tallerIntegracion2,@tallerIntegracion3,@programacionAvanzada,@programacionDeSistemas,@eticaLegislacionInformatica,@fundamentosAdministracion,@administracionProyectos,@compiladores," +
                    "@administracionRecursosInformaticos,@servicioSocial,@experienciaRecepcional,@desarrolloAplicacionesEnRed,@ingenieriaSoftware3,@graficacion,@sistemasInformacionEmpresarial,@administracionSeguridadDeServiciosEnRed,@topicosSelectos1,@topicosSelectos2,@topicosSelectos3,@topicosSelectos4,@sistemasInformacionGeografica,@multimedia,@auditoriaInformatica,@tallerIntegracion4,@redes3,@idEgresado);";
            }
            else
            {
                query = "UPDATE dbo.InformacionAcademica SET " +
                    "ingresoLicenciatura = @ingresoLicenciatura, " +
                    "egresoLicenciatrua = @egresoLicenciatrua, " +
                    "formacionActual = @formacionActual, " +
                    "planDeEstudios = @planDeEstudios, " +
                    "desempeñoDocentes = @desempeñoDocentes, " +
                    "organizacionAdministrativa = @organizacionAdministrativa, " +
                    "instalacion = @instalacion, " +
                    "serviciosApoyo = @serviciosApoyo, " +
                    "actCulturalesYDeportivas = @actCulturalesYDeportivas, " +
                    "ingles1 = @ingles1, " +
                    "ingles2 = @ingles2, " +
                    "computacionBasica = @computacionBasica, " +
                    "lecturaRedaccion = @lecturaRedaccion, " +
                    "habilidadesPensamiento = @habilidadesPensamiento, " +
                    "algebraLineal = @algebraLineal, " +
                    "probabilidad = @probabilidad, " +
                    "matematicasDiscretas = @matematicasDiscretas, " +
                    "algoritmosEstucturasDatos1 = @algoritmosEstucturasDatos1, " +
                    "arquitecturaComputadoras1 = @arquitecturaComputadoras1, " +
                    "metodologiaInvestigacion = @metodologiaInvestigacion, " +
                    "logica = @logica, " +
                    "calculo = @calculo, " +
                    "redes1 = @redes1, " +
                    "redes2 = @redes2, " +
                    "ingenieriaSoftware1 = @ingenieriaSoftware1, " +
                    "ingenieriaSoftware2 = @ingenieriaSoftware2, " +
                    "basesDatos1 = @basesDatos1, " +
                    "basesDatos2 = @basesDatos2, " +
                    "tallerIntegracion1 = @tallerIntegracion1, " +
                    "sistemasOperativos = @sistemasOperativos, " +
                    "arquitecturaComputadoras2 = @arquitecturaComputadoras2, " +
                    "algoritmosEstructurasDatos2 = @algoritmosEstructurasDatos2, " +
                    "organizacionArchivos = @organizacionArchivos, " +
                    "inteligenciaArtificial = @inteligenciaArtificial, " +
                    "tallerIntegracion2 = @tallerIntegracion2, " +
                    "tallerIntegracion3 = @tallerIntegracion3, " +
                    "programacionAvanzada = @programacionAvanzada, " +
                    "programacionDeSistemas = @programacionDeSistemas, " +
                    "eticaLegislacionInformatica = @eticaLegislacionInformatica, " +
                    "fundamentosAdministracion = @fundamentosAdministracion, " +
                    "administracionProyectos = @administracionProyectos, " +
                    "compiladores = @compiladores, " +
                    "administracionRecursosInformaticos = @administracionRecursosInformaticos, " +
                    "servicioSocial = @servicioSocial, " +
                    "experienciaRecepcional = @experienciaRecepcional, " +
                    "desarrolloAplicacionesEnRed = @desarrolloAplicacionesEnRed, " +
                    "ingenieriaSoftware3 = @ingenieriaSoftware3, " +
                    "graficacion = @graficacion, " +
                    "sistemasInformacionEmpresarial = @sistemasInformacionEmpresarial, " +
                    "administracionSeguridadDeServiciosEnRed = @administracionSeguridadDeServiciosEnRed, " +
                    "topicosSelectos1 = @topicosSelectos1, " +
                    "topicosSelectos2 = @topicosSelectos2, " +
                    "topicosSelectos3 = @topicosSelectos3, " +
                    "topicosSelectos4 = @topicosSelectos4, " +
                    "sistemasInformacionGeografica = @sistemasInformacionGeografica, " +
                    "multimedia = @multimedia, " +
                    "auditoriaInformatica = @auditoriaInformatica, " +
                    "tallerIntegracion4 = @tallerIntegracion4, " +
                    "redes3 = @redes3 " +
                    "WHERE idInformacionAcademica = @idInformacionAcademica;";
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
                    command.Parameters.AddWithValue("@ingresoLicenciatura", informacionAcademica.IngresoLicenciatura);
                    command.Parameters.AddWithValue("@egresoLicenciatrua", informacionAcademica.EgresoLicenciatrua);
                    command.Parameters.AddWithValue("@formacionActual", informacionAcademica.FormacionActual);
                    command.Parameters.AddWithValue("@planDeEstudios", informacionAcademica.PlanDeEstudios);
                    command.Parameters.AddWithValue("@desempeñoDocentes", informacionAcademica.DesempeñoDocentes);
                    command.Parameters.AddWithValue("@organizacionAdministrativa", informacionAcademica.OrganizacionAdministrativa);
                    command.Parameters.AddWithValue("@instalacion", informacionAcademica.Instalacion);
                    command.Parameters.AddWithValue("@serviciosApoyo", informacionAcademica.ServiciosApoyo);
                    command.Parameters.AddWithValue("@actCulturalesYDeportivas", informacionAcademica.ActCulturalesYDeportivas);
                    command.Parameters.AddWithValue("@ingles1", informacionAcademica.Ingles1);
                    command.Parameters.AddWithValue("@ingles2", informacionAcademica.Ingles2);
                    command.Parameters.AddWithValue("@computacionBasica", informacionAcademica.ComputacionBasica);
                    command.Parameters.AddWithValue("@lecturaRedaccion", informacionAcademica.LecturaRedaccion);
                    command.Parameters.AddWithValue("@habilidadesPensamiento", informacionAcademica.HabilidadesPensamiento);
                    command.Parameters.AddWithValue("@algebraLineal", informacionAcademica.AlgebraLineal);
                    command.Parameters.AddWithValue("@probabilidad", informacionAcademica.Probabilidad);
                    command.Parameters.AddWithValue("@matematicasDiscretas", informacionAcademica.MatematicasDiscretas);
                    command.Parameters.AddWithValue("@algoritmosEstucturasDatos1", informacionAcademica.AlgoritmosEstucturasDatos1);
                    command.Parameters.AddWithValue("@arquitecturaComputadoras1", informacionAcademica.ArquitecturaComputadoras1);
                    command.Parameters.AddWithValue("@metodologiaInvestigacion", informacionAcademica.MetodologiaInvestigacion);
                    command.Parameters.AddWithValue("@logica", informacionAcademica.Logica);
                    command.Parameters.AddWithValue("@calculo", informacionAcademica.Calculo);
                    command.Parameters.AddWithValue("@redes1", informacionAcademica.Redes1);
                    command.Parameters.AddWithValue("@redes2", informacionAcademica.Redes2);
                    command.Parameters.AddWithValue("@ingenieriaSoftware1", informacionAcademica.IngenieriaSoftware1);
                    command.Parameters.AddWithValue("@ingenieriaSoftware2", informacionAcademica.IngenieriaSoftware2);
                    command.Parameters.AddWithValue("@basesDatos1", informacionAcademica.BasesDatos1);
                    command.Parameters.AddWithValue("@basesDatos2", informacionAcademica.BasesDatos2);
                    command.Parameters.AddWithValue("@tallerIntegracion1", informacionAcademica.TallerIntegracion1);
                    command.Parameters.AddWithValue("@sistemasOperativos", informacionAcademica.SistemasOperativos);
                    command.Parameters.AddWithValue("@arquitecturaComputadoras2", informacionAcademica.ArquitecturaComputadoras2);
                    command.Parameters.AddWithValue("@algoritmosEstructurasDatos2", informacionAcademica.AlgoritmosEstructurasDatos2);
                    command.Parameters.AddWithValue("@organizacionArchivos", informacionAcademica.OrganizacionArchivos);
                    command.Parameters.AddWithValue("@inteligenciaArtificial", informacionAcademica.InteligenciaArtificial);
                    command.Parameters.AddWithValue("@tallerIntegracion2", informacionAcademica.TallerIntegracion2);
                    command.Parameters.AddWithValue("@tallerIntegracion3", informacionAcademica.TallerIntegracion3);
                    command.Parameters.AddWithValue("@programacionAvanzada", informacionAcademica.ProgramacionAvanzada);
                    command.Parameters.AddWithValue("@programacionDeSistemas", informacionAcademica.ProgramacionDeSistemas);
                    command.Parameters.AddWithValue("@eticaLegislacionInformatica", informacionAcademica.EticaLegislacionInformatica);
                    command.Parameters.AddWithValue("@fundamentosAdministracion", informacionAcademica.FundamentosAdministracion);
                    command.Parameters.AddWithValue("@administracionProyectos", informacionAcademica.AdministracionProyectos);
                    command.Parameters.AddWithValue("@compiladores", informacionAcademica.Compiladores);
                    command.Parameters.AddWithValue("@administracionRecursosInformaticos", informacionAcademica.AdministracionRecursosInformaticos);
                    command.Parameters.AddWithValue("@servicioSocial", informacionAcademica.ServicioSocial);
                    command.Parameters.AddWithValue("@experienciaRecepcional", informacionAcademica.ExperienciaRecepcional);
                    command.Parameters.AddWithValue("@desarrolloAplicacionesEnRed", informacionAcademica.DesarrolloAplicacionesEnRed);
                    command.Parameters.AddWithValue("@ingenieriaSoftware3", informacionAcademica.IngenieriaSoftware3);
                    command.Parameters.AddWithValue("@graficacion", informacionAcademica.Graficacion);
                    command.Parameters.AddWithValue("@sistemasInformacionEmpresarial", informacionAcademica.SistemasInformacionEmpresarial);
                    command.Parameters.AddWithValue("@administracionSeguridadDeServiciosEnRed", informacionAcademica.AdministracionSeguridadDeServiciosEnRed);
                    command.Parameters.AddWithValue("@topicosSelectos1", informacionAcademica.TopicosSelectos1);
                    command.Parameters.AddWithValue("@topicosSelectos2", informacionAcademica.TopicosSelectos2);
                    command.Parameters.AddWithValue("@topicosSelectos3", informacionAcademica.TopicosSelectos3);
                    command.Parameters.AddWithValue("@topicosSelectos4", informacionAcademica.TopicosSelectos4);
                    command.Parameters.AddWithValue("@sistemasInformacionGeografica", informacionAcademica.SistemasInformacionGeografica);
                    command.Parameters.AddWithValue("@multimedia", informacionAcademica.Multimedia);
                    command.Parameters.AddWithValue("@auditoriaInformatica", informacionAcademica.AuditoriaInformatica);
                    command.Parameters.AddWithValue("@tallerIntegracion4", informacionAcademica.TallerIntegracion4);
                    command.Parameters.AddWithValue("@redes3", informacionAcademica.Redes3);

                    if (nuevo)
                    {
                        command.Parameters.AddWithValue("@idEgresado", informacionAcademica.IdEgresado);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@idInformacionAcademica", informacionAcademica.IdInformacionAcademica);
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
