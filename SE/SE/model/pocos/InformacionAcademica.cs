using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.model.pocos
{
    public class InformacionAcademica
    {
        private Int32 idInformacionAcademica;
        private string ingresoLicenciatura;
        private string egresoLicenciatrua;
        private string formacionActual;
        private string planDeEstudios;
        private string desempeñoDocentes;
        private string organizacionAdministrativa;
        private string instalacion;
        private string serviciosApoyo;
        private string actCulturalesYDeportivas;
        private string ingles1;
        private string ingles2;
        private string computacionBasica;
        private string lecturaRedaccion;
        private string habilidadesPensamiento;
        private string algebraLineal;
        private string probabilidad;
        private string matematicasDiscretas;
        private string algoritmosEstucturasDatos1;
        private string arquitecturaComputadoras1;
        private string metodologiaInvestigacion;
        private string logica;
        private string calculo;
        private string redes1;
        private string redes2;
        private string ingenieriaSoftware1;
        private string ingenieriaSoftware2;
        private string basesDatos1;
        private string basesDatos2;
        private string tallerIntegracion1;
        private string sistemasOperativos;
        private string arquitecturaComputadoras2;
        private string algoritmosEstructurasDatos2;
        private string organizacionArchivos;
        private string inteligenciaArtificial;
        private string tallerIntegracion2;
        private string tallerIntegracion3;
        private string programacionAvanzada;
        private string programacionDeSistemas;
        private string eticaLegislacionInformatica;
        private string fundamentosAdministracion;
        private string administracionProyectos;
        private string compiladores;
        private string administracionRecursosInformaticos;
        private string servicioSocial;
        private string experienciaRecepcional;
        private string desarrolloAplicacionesEnRed;
        private string ingenieriaSoftware3;
        private string graficacion;
        private string sistemasInformacionEmpresarial;
        private string administracionSeguridadDeServiciosEnRed;
        private string topicosSelectos1;
        private string topicosSelectos2;
        private string topicosSelectos3;
        private string topicosSelectos4;
        private string sistemasInformacionGeografica;
        private string multimedia;
        private string auditoriaInformatica;
        private string tallerIntegracion4;
        private string redes3;
        private Int32 idEgresado;
   

        public override string ToString()
        {
            return String.Format("idInformacionAcademica: {0} , idEgresado{2}"  , 
                   idInformacionAcademica, idEgresado);
        }
        public int IdInformacionAcademica { get => idInformacionAcademica; set => idInformacionAcademica = value; }
        public int IdEgresado { get => idEgresado; set => idEgresado = value; }
        public string FormacionActual { get => formacionActual; set => formacionActual = value; }
        public string PlanDeEstudios { get => planDeEstudios; set => planDeEstudios = value; }
        public string DesempeñoDocentes { get => desempeñoDocentes; set => desempeñoDocentes = value; }
        public string OrganizacionAdministrativa { get => organizacionAdministrativa; set => organizacionAdministrativa = value; }
        public string Instalacion { get => instalacion; set => instalacion = value; }
        public string ServiciosApoyo { get => serviciosApoyo; set => serviciosApoyo = value; }
        public string ActCulturalesYDeportivas { get => actCulturalesYDeportivas; set => actCulturalesYDeportivas = value; }
        public string Ingles1 { get => ingles1; set => ingles1 = value; }
        public string Ingles2 { get => ingles2; set => ingles2 = value; }
        public string ComputacionBasica { get => computacionBasica; set => computacionBasica = value; }
        public string LecturaRedaccion { get => lecturaRedaccion; set => lecturaRedaccion = value; }
        public string HabilidadesPensamiento { get => habilidadesPensamiento; set => habilidadesPensamiento = value; }
        public string AlgebraLineal { get => algebraLineal; set => algebraLineal = value; }
        public string Probabilidad { get => probabilidad; set => probabilidad = value; }
        public string MatematicasDiscretas { get => matematicasDiscretas; set => matematicasDiscretas = value; }
        public string AlgoritmosEstucturasDatos1 { get => algoritmosEstucturasDatos1; set => algoritmosEstucturasDatos1 = value; }
        public string ArquitecturaComputadoras1 { get => arquitecturaComputadoras1; set => arquitecturaComputadoras1 = value; }
        public string MetodologiaInvestigacion { get => metodologiaInvestigacion; set => metodologiaInvestigacion = value; }
        public string Logica { get => logica; set => logica = value; }
        public string Calculo { get => calculo; set => calculo = value; }
        public string Redes1 { get => redes1; set => redes1 = value; }
        public string Redes2 { get => redes2; set => redes2 = value; }
        public string IngenieriaSoftware1 { get => ingenieriaSoftware1; set => ingenieriaSoftware1 = value; }
        public string IngenieriaSoftware2 { get => ingenieriaSoftware2; set => ingenieriaSoftware2 = value; }
        public string BasesDatos1 { get => basesDatos1; set => basesDatos1 = value; }
        public string BasesDatos2 { get => basesDatos2; set => basesDatos2 = value; }
        public string TallerIntegracion1 { get => tallerIntegracion1; set => tallerIntegracion1 = value; }
        public string SistemasOperativos { get => sistemasOperativos; set => sistemasOperativos = value; }
        public string ArquitecturaComputadoras2 { get => arquitecturaComputadoras2; set => arquitecturaComputadoras2 = value; }
        public string AlgoritmosEstructurasDatos2 { get => algoritmosEstructurasDatos2; set => algoritmosEstructurasDatos2 = value; }
        public string OrganizacionArchivos { get => organizacionArchivos; set => organizacionArchivos = value; }
        public string InteligenciaArtificial { get => inteligenciaArtificial; set => inteligenciaArtificial = value; }
        public string TallerIntegracion2 { get => tallerIntegracion2; set => tallerIntegracion2 = value; }
        public string TallerIntegracion3 { get => tallerIntegracion3; set => tallerIntegracion3 = value; }
        public string ProgramacionAvanzada { get => programacionAvanzada; set => programacionAvanzada = value; }
        public string ProgramacionDeSistemas { get => programacionDeSistemas; set => programacionDeSistemas = value; }
        public string EticaLegislacionInformatica { get => eticaLegislacionInformatica; set => eticaLegislacionInformatica = value; }
        public string FundamentosAdministracion { get => fundamentosAdministracion; set => fundamentosAdministracion = value; }
        public string AdministracionProyectos { get => administracionProyectos; set => administracionProyectos = value; }
        public string Compiladores { get => compiladores; set => compiladores = value; }
        public string AdministracionRecursosInformaticos { get => administracionRecursosInformaticos; set => administracionRecursosInformaticos = value; }
        public string ServicioSocial { get => servicioSocial; set => servicioSocial = value; }
        public string ExperienciaRecepcional { get => experienciaRecepcional; set => experienciaRecepcional = value; }
        public string DesarrolloAplicacionesEnRed { get => desarrolloAplicacionesEnRed; set => desarrolloAplicacionesEnRed = value; }
        public string IngenieriaSoftware3 { get => ingenieriaSoftware3; set => ingenieriaSoftware3 = value; }
        public string Graficacion { get => graficacion; set => graficacion = value; }
        public string SistemasInformacionEmpresarial { get => sistemasInformacionEmpresarial; set => sistemasInformacionEmpresarial = value; }
        public string AdministracionSeguridadDeServiciosEnRed { get => administracionSeguridadDeServiciosEnRed; set => administracionSeguridadDeServiciosEnRed = value; }
        public string TopicosSelectos1 { get => topicosSelectos1; set => topicosSelectos1 = value; }
        public string TopicosSelectos2 { get => topicosSelectos2; set => topicosSelectos2 = value; }
        public string TopicosSelectos3 { get => topicosSelectos3; set => topicosSelectos3 = value; }
        public string TopicosSelectos4 { get => topicosSelectos4; set => topicosSelectos4 = value; }
        public string SistemasInformacionGeografica { get => sistemasInformacionGeografica; set => sistemasInformacionGeografica = value; }
        public string Multimedia { get => multimedia; set => multimedia = value; }
        public string AuditoriaInformatica { get => auditoriaInformatica; set => auditoriaInformatica = value; }
        public string TallerIntegracion4 { get => tallerIntegracion4; set => tallerIntegracion4 = value; }
        public string Redes3 { get => redes3; set => redes3 = value; }
        public string IngresoLicenciatura { get => ingresoLicenciatura; set => ingresoLicenciatura = value; }
        public string EgresoLicenciatrua { get => egresoLicenciatrua; set => egresoLicenciatrua = value; }
    }
}
