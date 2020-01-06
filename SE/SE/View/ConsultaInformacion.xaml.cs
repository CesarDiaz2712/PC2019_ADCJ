using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SE.model.pocos;

namespace SE.View
{
    /// <summary>
    /// Lógica de interacción para ConsultaInformacion.xaml
    /// </summary>
    public partial class ConsultaInformacion : Window
    {
        private Egresado egresado;
        private FichaPreEgreso ficha;
        private InformacionLaboral informacionLaboral;
        private InformacionAcademica informacionAcademica;
        private bool nuevo;
        public ConsultaInformacion(Egresado egresado, FichaPreEgreso ficha, InformacionLaboral informacionLaboral, InformacionAcademica informacionAcademica, Boolean nuevo)
        {
            this.egresado = egresado;
            this.ficha = ficha;
            this.informacionLaboral = informacionLaboral;
            this.informacionAcademica = informacionAcademica;
            this.nuevo = nuevo;
            InitializeComponent();
            txtIngreso.Text = informacionAcademica.IngresoLicenciatura;
            txtEgreso.Text = informacionAcademica.EgresoLicenciatrua;

            if (informacionAcademica.FormacionActual == "Licenciatura")
            {
                rbLicenciatura.IsChecked=true;
            }
            else
            {
                if (informacionAcademica.FormacionActual == "Especialidad")
                {
                    rbEscpecialidad.IsChecked = true;
                }
                if (informacionAcademica.FormacionActual == "Maestria")
                {
                    rbMaestria.IsChecked = true;
                }
                if (informacionAcademica.FormacionActual == "Doctorado")
                {
                    rbDoctorado.IsChecked = true;
                }
                if (informacionAcademica.FormacionActual == "PosDoctorado")
                {
                    rbPosDoctorado.IsChecked = true;
                }
            }

            if (informacionAcademica.PlanDeEstudios == "Eficiente")
            {
                rbEficientePlanEstudiantil.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.PlanDeEstudios == "Aceptable")
                {
                    rbAceptablePlanEstudiantil.IsChecked = true;
                }
                if (informacionAcademica.PlanDeEstudios == "Regular")
                {
                    rbRegularPlanEstudiantil.IsChecked = true;
                }
                if (informacionAcademica.PlanDeEstudios == "Deficiente")
                {
                    rbDeficientePlanEstudiantil.IsChecked = true;
                }
            }

            if (informacionAcademica.DesempeñoDocentes == "Eficiente")
            {
                rbEficienteDocentes.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.DesempeñoDocentes == "Aceptable")
                {
                    rbAceptableDocentes.IsChecked = true;
                }
                if (informacionAcademica.DesempeñoDocentes == "Regular")
                {
                    rbRegularDocentes.IsChecked = true;
                }
                if (informacionAcademica.DesempeñoDocentes == "Deficiente")
                {
                    rbDeficienteDocentes.IsChecked = true;
                }
            }

            if (informacionAcademica.OrganizacionAdministrativa == "Eficiente")
            {
                rbEficienteOrganizacion.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.OrganizacionAdministrativa == "Aceptable")
                {
                    rbAceptableOrganizacion.IsChecked = true;
                }
                if (informacionAcademica.OrganizacionAdministrativa == "Regular")
                {
                    rbRegularOrganizacion.IsChecked = true;
                }
                if (informacionAcademica.OrganizacionAdministrativa == "Deficiente")
                {
                    rbDeficienteOrganizacion.IsChecked = true;
                }
            }

            if (informacionAcademica.Instalacion == "Eficiente")
            {
                rbEficienteInstalacion.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Instalacion == "Aceptable")
                {
                    rbAceptableInstalacion.IsChecked = true;
                }
                if (informacionAcademica.Instalacion == "Regular")
                {
                    rbRegularInstalacion.IsChecked = true;
                }
                if (informacionAcademica.Instalacion == "Deficiente")
                {
                    rbDeficienteInstalacion.IsChecked = true;
                }
            }

            if (informacionAcademica.ServiciosApoyo == "Eficiente")
            {
                rbEficienteServicio.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.ServiciosApoyo == "Aceptable")
                {
                    rbAceptableServicio.IsChecked = true;
                }
                if (informacionAcademica.ServiciosApoyo == "Regular")
                {
                    rbRegularServicio.IsChecked = true;
                }
                if (informacionAcademica.ServiciosApoyo == "Deficiente")
                {
                    rbDeficienteServicio.IsChecked = true;
                }
            }

            if (informacionAcademica.ActCulturalesYDeportivas == "Eficiente")
            {
                rbEficienteActDeportivas.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.ActCulturalesYDeportivas == "Aceptable")
                {
                    rbAceptableActDeportivas.IsChecked = true;
                }
                if (informacionAcademica.ActCulturalesYDeportivas == "Regular")
                {
                    rbRegularActDeportivas.IsChecked = true;
                }
                if (informacionAcademica.ActCulturalesYDeportivas == "Deficiente")
                {
                    rbDeficienteActDeportivas.IsChecked = true;
                }
            }

            if (informacionAcademica.Ingles1 == "Mucho")
            {
                rbMuchoIngles1.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Ingles1 == "Regular")
                {
                    rbRegularIngles1.IsChecked = true;
                }
                if (informacionAcademica.Ingles1 == "Poco")
                {
                    rbPocoIngles1.IsChecked = true;
                }
                if (informacionAcademica.Ingles1 == "Nada")
                {
                    rbNadaIngles1.IsChecked = true;
                }
            }

            if (informacionAcademica.Ingles2 == "Mucho")
            {
                rbMuchoIngles2.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Ingles2 == "Regular")
                {
                    rbRegularIngles2.IsChecked = true;
                }
                if (informacionAcademica.Ingles2 == "Poco")
                {
                    rbPocoIngles2.IsChecked = true;
                }
                if (informacionAcademica.Ingles2 == "Nada")
                {
                    rbNadaIngles2.IsChecked = true;
                }
            }

            if (informacionAcademica.ComputacionBasica == "Mucho")
            {
                rbMuchoComputacionBasica.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.ComputacionBasica == "Regular")
                {
                    rbRegularComputacionBasica.IsChecked = true;
                }
                if (informacionAcademica.ComputacionBasica == "Poco")
                {
                    rbPocoComputacionBasica.IsChecked = true;
                }
                if (informacionAcademica.ComputacionBasica == "Nada")
                {
                    rbNadaComputacionBasica.IsChecked = true;
                }
            }

            if (informacionAcademica.LecturaRedaccion == "Mucho")
            {
                rbMuchoLecturaYRedaccion.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.LecturaRedaccion == "Regular")
                {
                    rbRegularLecturaYRedaccion.IsChecked = true;
                }
                if (informacionAcademica.LecturaRedaccion == "Poco")
                {
                    rbPocoLecturaYRedaccion.IsChecked = true;
                }
                if (informacionAcademica.LecturaRedaccion == "Nada")
                {
                    rbNadaLecturaYRedaccion.IsChecked = true;
                }
            }

            if (informacionAcademica.HabilidadesPensamiento == "Mucho")
            {
                rbMuchoHabilidadesPensamiento.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.HabilidadesPensamiento == "Regular")
                {
                    rbRegularHabilidadesPensamiento.IsChecked = true;
                }
                if (informacionAcademica.HabilidadesPensamiento == "Poco")
                {
                    rbPocoHabilidadesPensamiento.IsChecked = true;
                }
                if (informacionAcademica.HabilidadesPensamiento == "Nada")
                {
                    rbNadaHabilidadesPensamiento.IsChecked = true;
                }
            }

            if (informacionAcademica.AlgebraLineal == "Mucho")
            {
                rbMuchoAlgebraLineal.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.AlgebraLineal == "Regular")
                {
                    rbRegularAlgebraLineal.IsChecked = true;
                }
                if (informacionAcademica.AlgebraLineal == "Poco")
                {
                    rbPocoAlgebraLineal.IsChecked = true;
                }
                if (informacionAcademica.AlgebraLineal == "Nada")
                {
                    rbNadaAlgebraLineal.IsChecked = true;
                }
                if (informacionAcademica.AlgebraLineal == "No la cursé")
                {
                    rbNoCursoAlgebraLineal.IsChecked = true;
                }
            }

            if (informacionAcademica.Probabilidad == "Mucho")
            {
                rbMuchoProbabilidad.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Probabilidad == "Regular")
                {
                    rbRegularProbabilidad.IsChecked = true;
                }
                if (informacionAcademica.Probabilidad == "Poco")
                {
                    rbPocoProbabilidad.IsChecked = true;
                }
                if (informacionAcademica.Probabilidad == "Nada")
                {
                    rbNadaProbabilidad.IsChecked = true;
                }
                if (informacionAcademica.Probabilidad == "No la cursé")
                {
                    rbNoCursoProbabilidad.IsChecked = true;
                }
            }

            if (informacionAcademica.MatematicasDiscretas == "Mucho")
            {
                rbMuchoMatematicasDiscretas.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.MatematicasDiscretas == "Regular")
                {
                    rbRegularMatematicasDiscretas.IsChecked = true;
                }
                if (informacionAcademica.MatematicasDiscretas == "Poco")
                {
                    rbPocoMatematicasDiscretas.IsChecked = true;
                }
                if (informacionAcademica.MatematicasDiscretas == "Nada")
                {
                    rbNadaMatematicasDiscretas.IsChecked = true;
                }
                if (informacionAcademica.MatematicasDiscretas == "No la cursé")
                {
                    rbNoCursoMatematicasDiscretas.IsChecked = true;
                }
            }

            if (informacionAcademica.AlgoritmosEstucturasDatos1 == "Mucho")
            {
                rbMuchoAlgoritmosEstrucutrasDatos1.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.AlgoritmosEstucturasDatos1 == "Regular")
                {
                    rbRegularAlgoritmosEstrucutrasDatos1.IsChecked = true;
                }
                if (informacionAcademica.AlgoritmosEstucturasDatos1 == "Poco")
                {
                    rbPocoAlgoritmosEstrucutrasDatos1.IsChecked = true;
                }
                if (informacionAcademica.AlgoritmosEstucturasDatos1 == "Nada")
                {
                    rbNadaAlgoritmosEstrucutrasDatos1.IsChecked = true;
                }
                if (informacionAcademica.AlgoritmosEstucturasDatos1 == "No la cursé")
                {
                    rbNoCursoAlgoritmosEstrucutrasDatos1.IsChecked = true;
                }
            }

            if (informacionAcademica.ArquitecturaComputadoras1 == "Mucho")
            {
                rbMuchoArquitecturaDeComputadoras1.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.ArquitecturaComputadoras1 == "Regular")
                {
                    rbRegularArquitecturaDeComputadoras1.IsChecked = true;
                }
                if (informacionAcademica.ArquitecturaComputadoras1 == "Poco")
                {
                    rbPocoArquitecturaDeComputadoras1.IsChecked = true;
                }
                if (informacionAcademica.ArquitecturaComputadoras1 == "Nada")
                {
                    rbNadaArquitecturaDeComputadoras1.IsChecked = true;
                }
                if (informacionAcademica.ArquitecturaComputadoras1 == "No la cursé")
                {
                    rbNoCursoArquitecturaDeComputadoras1.IsChecked = true;
                }
            }

            if (informacionAcademica.MetodologiaInvestigacion == "Mucho")
            {
                rbMuchoMetodologiaInv.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.MetodologiaInvestigacion == "Regular")
                {
                    rbRegularMetodologiaInv.IsChecked = true;
                }
                if (informacionAcademica.MetodologiaInvestigacion == "Poco")
                {
                    rbPocoMetodologiaInv.IsChecked = true;
                }
                if (informacionAcademica.MetodologiaInvestigacion == "Nada")
                {
                    rbNadaMetodologiaInv.IsChecked = true;
                }
                if (informacionAcademica.MetodologiaInvestigacion == "No la cursé")
                {
                    rbNoCursoMetodologiaInv.IsChecked = true;
                }
            }

            if (informacionAcademica.Logica == "Mucho")
            {
                rbMuchoLogica.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Logica == "Regular")
                {
                    rbRegularLogica.IsChecked = true;
                }
                if (informacionAcademica.Logica == "Poco")
                {
                    rbPocoLogica.IsChecked = true;
                }
                if (informacionAcademica.Logica == "Nada")
                {
                    rbNadaLogica.IsChecked = true;
                }
                if (informacionAcademica.Logica == "No la cursé")
                {
                    rbNoCursoLogica.IsChecked = true;
                }
            }

            if (informacionAcademica.Calculo == "Mucho")
            {
                rbMuchoCalculo.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Calculo == "Regular")
                {
                    rbRegularCalculo.IsChecked = true;
                }
                if (informacionAcademica.Calculo == "Poco")
                {
                    rbPocoCalculo.IsChecked = true;
                }
                if (informacionAcademica.Calculo == "Nada")
                {
                    rbNadaCalculo.IsChecked = true;
                }
                if (informacionAcademica.Calculo == "No la cursé")
                {
                    rbNoCursoCalculo.IsChecked = true;
                }
            }

            if (informacionAcademica.Redes1 == "Mucho")
            {
                rbMuchoRedes1.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Redes1 == "Regular")
                {
                    rbRegularRedes1.IsChecked = true;
                }
                if (informacionAcademica.Redes1 == "Poco")
                {
                    rbPocoRedes1.IsChecked = true;
                }
                if (informacionAcademica.Redes1 == "Nada")
                {
                    rbNadaRedes1.IsChecked = true;
                }
                if (informacionAcademica.Redes1 == "No la cursé")
                {
                    rbNoCursoRedes1.IsChecked = true;
                }
            }

            if (informacionAcademica.Redes2 == "Mucho")
            {
                rbMuchoRedes2.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Redes2 == "Regular")
                {
                    rbRegularRedes2.IsChecked = true;
                }
                if (informacionAcademica.Redes2 == "Poco")
                {
                    rbPocoRedes2.IsChecked = true;
                }
                if (informacionAcademica.Redes2 == "Nada")
                {
                    rbNadaRedes2.IsChecked = true;
                }
                if (informacionAcademica.Redes2 == "No la cursé")
                {
                    rbNoCursoRedes2.IsChecked = true;
                }
            }

            if (informacionAcademica.IngenieriaSoftware1 == "Mucho")
            {
                rbMuchoIngeniriaSoftware1.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.IngenieriaSoftware1 == "Regular")
                {
                    rbRegularIngeniriaSoftware1.IsChecked = true;
                }
                if (informacionAcademica.IngenieriaSoftware1 == "Poco")
                {
                    rbPocoIngenieriaSoftware1.IsChecked = true;
                }
                if (informacionAcademica.IngenieriaSoftware1 == "Nada")
                {
                    rbNadaIngenieriaSoftware1.IsChecked = true;
                }
                if (informacionAcademica.IngenieriaSoftware1 == "No la cursé")
                {
                    rbNoCursoIngenieriaSoftware1.IsChecked = true;
                }
            }

            if (informacionAcademica.IngenieriaSoftware2 == "Mucho")
            {
                rbMuchoIngenieriaSoftware2.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.IngenieriaSoftware2 == "Regular")
                {
                    rbRegularIngenieriaSoftware2.IsChecked = true;
                }
                if (informacionAcademica.IngenieriaSoftware2 == "Poco")
                {
                    rbPocoIngenieriaSoftware2.IsChecked = true;
                }
                if (informacionAcademica.IngenieriaSoftware2 == "Nada")
                {
                    rbNadaIngenieriaSoftware2.IsChecked = true;
                }
                if (informacionAcademica.IngenieriaSoftware2 == "No la cursé")
                {
                    rbNoCursoIngenieriaSoftware2.IsChecked = true;
                }
            }

            if (informacionAcademica.BasesDatos1 == "Mucho")
            {
                rbMuchoBasesDatos1.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.BasesDatos1 == "Regular")
                {
                    rbRegularBasesDatos1.IsChecked = true;
                }
                if (informacionAcademica.BasesDatos1 == "Poco")
                {
                    rbPocoBasesDatos1.IsChecked = true;
                }
                if (informacionAcademica.BasesDatos1 == "Nada")
                {
                    rbNadaBasesDatos1.IsChecked = true;
                }
                if (informacionAcademica.BasesDatos1 == "No la cursé")
                {
                    rbNoCursoBasesDatos1.IsChecked = true;
                }
            }

            if (informacionAcademica.BasesDatos2 == "Mucho")
            {
                rbMuchoBasesDatos2.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.BasesDatos2 == "Regular")
                {
                    rbRegularBasesDatos2.IsChecked = true;
                }
                if (informacionAcademica.BasesDatos2 == "Poco")
                {
                    rbPocoBasesDatos2.IsChecked = true;
                }
                if (informacionAcademica.BasesDatos2 == "Nada")
                {
                    rbNadaBasesDatos2.IsChecked = true;
                }
                if (informacionAcademica.BasesDatos2 == "No la cursé")
                {
                    rbNoCursoBasesDatos2.IsChecked = true;
                }
            }

            if (informacionAcademica.TallerIntegracion1 == "Mucho")
            {
                rbMuchoTallerIntegracion1.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.TallerIntegracion1 == "Regular")
                {
                    rbRegularTallerIntegracion1.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion1 == "Poco")
                {
                    rbPocoTallerIntegracion1.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion1 == "Nada")
                {
                    rbNadaTallerIntegracion1.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion1 == "No la cursé")
                {
                    rbNoCursoTallerIntegracion1.IsChecked = true;
                }
            }

            if (informacionAcademica.SistemasOperativos == "Mucho")
            {
                rbMuchoSistemasOperativos.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.SistemasOperativos == "Regular")
                {
                    rbRegularSistemasOperativos.IsChecked = true;
                }
                if (informacionAcademica.SistemasOperativos == "Poco")
                {
                    rbPocoSistemasOperativos.IsChecked = true;
                }
                if (informacionAcademica.SistemasOperativos == "Nada")
                {
                    rbNadaSistemasOperativos.IsChecked = true;
                }
                if (informacionAcademica.SistemasOperativos == "No la cursé")
                {
                    rbNoCursoSistemasOperativos.IsChecked = true;
                }
            }

            if (informacionAcademica.ArquitecturaComputadoras2 == "Mucho")
            {
                rbMuchoArquitecturaDeComputadoras2.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.ArquitecturaComputadoras2 == "Regular")
                {
                    rbRegularArquitecturaDeComputadoras2.IsChecked = true;
                }
                if (informacionAcademica.ArquitecturaComputadoras2 == "Poco")
                {
                    rbPocoArquitecturaDeComputadoras2.IsChecked = true;
                }
                if (informacionAcademica.ArquitecturaComputadoras2 == "Nada")
                {
                    rbNadaArquitecturaDeComputadoras2.IsChecked = true;
                }
                if (informacionAcademica.ArquitecturaComputadoras2 == "No la cursé")
                {
                    rbNoCursoArquitecturaDeComputadoras2.IsChecked = true;
                }
            }

            if (informacionAcademica.AlgoritmosEstructurasDatos2 == "Mucho")
            {
                rbMuchoAlgoritmosEstructurasDatos2.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.AlgoritmosEstructurasDatos2 == "Regular")
                {
                    rbRegularAlgoritmosEstructurasDatos2.IsChecked = true;
                }
                if (informacionAcademica.AlgoritmosEstructurasDatos2 == "Poco")
                {
                    rbPocoAlgoritmosEstructurasDatos2.IsChecked = true;
                }
                if (informacionAcademica.AlgoritmosEstructurasDatos2 == "Nada")
                {
                    rbNadaAlgoritmosEstructurasDatos2.IsChecked = true;
                }
                if (informacionAcademica.AlgoritmosEstructurasDatos2 == "No la cursé")
                {
                    rbNoCursoAlgoritmosEstructurasDatos2.IsChecked = true;
                }
            }

            if (informacionAcademica.OrganizacionArchivos == "Mucho")
            {
                rbMuchoOrganizacionArchivos.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.OrganizacionArchivos == "Regular")
                {
                    rbRegularOrganizacionArchivos.IsChecked = true;
                }
                if (informacionAcademica.OrganizacionArchivos == "Poco")
                {
                    rbPocoOrganizacionArchivos.IsChecked = true;
                }
                if (informacionAcademica.OrganizacionArchivos == "Nada")
                {
                    rbNadaOrganizacionArchivos.IsChecked = true;
                }
                if (informacionAcademica.OrganizacionArchivos == "No la cursé")
                {
                    rbNoCursoOrganizacionArchivos.IsChecked = true;
                }
            }

            if (informacionAcademica.InteligenciaArtificial == "Mucho")
            {
                rbMuchoInteligenciaArtificial.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.InteligenciaArtificial == "Regular")
                {
                    rbRegularInteligenciaArtificial.IsChecked = true;
                }
                if (informacionAcademica.InteligenciaArtificial == "Poco")
                {
                    rbPocoInteligenciaArtificial.IsChecked = true;
                }
                if (informacionAcademica.InteligenciaArtificial == "Nada")
                {
                    rbNadaInteligenciaArtificial.IsChecked = true;
                }
                if (informacionAcademica.InteligenciaArtificial == "No la cursé")
                {
                    rbNoCursoInteligenciaArtificial.IsChecked = true;
                }
            }

            if (informacionAcademica.TallerIntegracion2 == "Mucho")
            {
                rbMuchoTallerIntegracion2.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.TallerIntegracion2 == "Regular")
                {
                    rbRegularTallerIntegracion2.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion2 == "Poco")
                {
                    rbPocoTallerIntegracion2.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion2 == "Nada")
                {
                    rbNadaTallerIntegracion2.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion2 == "No la cursé")
                {
                    rbNoCursoTallerIntegracion2.IsChecked = true;
                }
            }

            if (informacionAcademica.TallerIntegracion3 == "Mucho")
            {
                rbMuchoTallerIntegracion3.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.TallerIntegracion3 == "Regular")
                {
                    rbRegularTallerIntegracion3.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion3 == "Poco")
                {
                    rbPocoTallerIntegracion3.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion3 == "Nada")
                {
                    rbNadaTallerIntegracion3.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion3 == "No la cursé")
                {
                    rbNoCursoTallerIntegracion3.IsChecked = true;
                }
            }

            if (informacionAcademica.ProgramacionAvanzada == "Mucho")
            {
                rbMuchoProgramacionAvanzada.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.ProgramacionAvanzada == "Regular")
                {
                    rbRegularProgramacionAvanzada.IsChecked = true;
                }
                if (informacionAcademica.ProgramacionAvanzada == "Poco")
                {
                    rbPocoProgramacionAvanzada.IsChecked = true;
                }
                if (informacionAcademica.ProgramacionAvanzada == "Nada")
                {
                    rbNadaProgramacionAvanzada.IsChecked = true;
                }
                if (informacionAcademica.ProgramacionAvanzada == "No la cursé")
                {
                    rbNoCursoProgramacionAvanzada.IsChecked = true;
                }
            }

            if (informacionAcademica.ProgramacionDeSistemas == "Mucho")
            {
                rbMuchoProgramacionDeSistemas.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.ProgramacionDeSistemas == "Regular")
                {
                    rbRegularProgramacionDeSistemas.IsChecked = true;
                }
                if (informacionAcademica.ProgramacionDeSistemas == "Poco")
                {
                    rbPocoProgramacionDeSistemas.IsChecked = true;
                }
                if (informacionAcademica.ProgramacionDeSistemas == "Nada")
                {
                    rbNadaProgramacionDeSistemas.IsChecked = true;
                }
                if (informacionAcademica.ProgramacionDeSistemas == "No la cursé")
                {
                    rbNoCursoProgramacionDeSistemas.IsChecked = true;
                }
            }

            if (informacionAcademica.EticaLegislacionInformatica == "Mucho")
            {
                rbMuchoEticaLEgislacionInformatica.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.EticaLegislacionInformatica == "Regular")
                {
                    rbRegularEticaLEgislacionInformatica.IsChecked = true;
                }
                if (informacionAcademica.EticaLegislacionInformatica == "Poco")
                {
                    rbPocoEticaLEgislacionInformatica.IsChecked = true;
                }
                if (informacionAcademica.EticaLegislacionInformatica == "Nada")
                {
                    rbNadaEticaLEgislacionInformatica.IsChecked = true;
                }
                if (informacionAcademica.EticaLegislacionInformatica == "No la cursé")
                {
                    rbNoCursoEticaLEgislacionInformatica.IsChecked = true;
                }
            }

            if (informacionAcademica.FundamentosAdministracion == "Mucho")
            {
                rbMuchoFundamentosAdministracion.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.FundamentosAdministracion == "Regular")
                {
                    rbRegularFundamentosAdministracion.IsChecked = true;
                }
                if (informacionAcademica.FundamentosAdministracion == "Poco")
                {
                    rbPocoFundamentosAdministracion.IsChecked = true;
                }
                if (informacionAcademica.FundamentosAdministracion == "Nada")
                {
                    rbNadaFundamentosAdministracion.IsChecked = true;
                }
                if (informacionAcademica.FundamentosAdministracion == "No la cursé")
                {
                    rbNoCursoFundamentosAdministracion.IsChecked = true;
                }
            }

            if (informacionAcademica.AdministracionProyectos == "Mucho")
            {
                rbMuchoAdministracionProyectos.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.AdministracionProyectos == "Regular")
                {
                    rbRegularAdministracionProyectos.IsChecked = true;
                }
                if (informacionAcademica.AdministracionProyectos == "Poco")
                {
                    rbPocoAdministracionProyectos.IsChecked = true;
                }
                if (informacionAcademica.AdministracionProyectos == "Nada")
                {
                    rbNadaAdministracionProyectos.IsChecked = true;
                }
                if (informacionAcademica.AdministracionProyectos == "No la cursé")
                {
                    rbNoCursoAdministracionProyectos.IsChecked = true;
                }
            }

            if (informacionAcademica.Compiladores == "Mucho")
            {
                rbMuchoCompiladores.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Compiladores == "Regular")
                {
                    rbRegularCompiladores.IsChecked = true;
                }
                if (informacionAcademica.Compiladores == "Poco")
                {
                    rbPocoCompiladores.IsChecked = true;
                }
                if (informacionAcademica.Compiladores == "Nada")
                {
                    rbNadaCompiladores.IsChecked = true;
                }
                if (informacionAcademica.Compiladores == "No la cursé")
                {
                    rbNoCursoCompiladores.IsChecked = true;
                }
            }

            if (informacionAcademica.AdministracionRecursosInformaticos == "Mucho")
            {
                rbMuchoAdministracionRecursosInformaticos.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.AdministracionRecursosInformaticos == "Regular")
                {
                    rbRegularAdministracionRecursosInformaticos.IsChecked = true;
                }
                if (informacionAcademica.AdministracionRecursosInformaticos == "Poco")
                {
                    rbPocoAdministracionRecursosInformaticos.IsChecked = true;
                }
                if (informacionAcademica.AdministracionRecursosInformaticos == "Nada")
                {
                    rbNadaAdministracionRecursosInformaticos.IsChecked = true;
                }
                if (informacionAcademica.AdministracionRecursosInformaticos == "No la cursé")
                {
                    rbNoCursoAdministracionRecursosInformaticos.IsChecked = true;
                }
            }

            if (informacionAcademica.ServicioSocial == "Mucho")
            {
                rbMuchoServicioSocial.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.ServicioSocial == "Regular")
                {
                    rbRegularServicioSocial.IsChecked = true;
                }
                if (informacionAcademica.ServicioSocial == "Poco")
                {
                    rbPocoServicioSocial.IsChecked = true;
                }
                if (informacionAcademica.ServicioSocial == "Nada")
                {
                    rbNadaServicioSocial.IsChecked = true;
                }
                if (informacionAcademica.ServicioSocial == "No la cursé")
                {
                    rbNoCursoServicioSocial.IsChecked = true;
                }
            }

            if (informacionAcademica.ExperienciaRecepcional == "Mucho")
            {
                rbMuchoExperienciaRecepcional.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.ExperienciaRecepcional == "Regular")
                {
                    rbRegularExperienciaRecepcional.IsChecked = true;
                }
                if (informacionAcademica.ExperienciaRecepcional == "Poco")
                {
                    rbPocoExperienciaRecepcional.IsChecked = true;
                }
                if (informacionAcademica.ExperienciaRecepcional == "Nada")
                {
                    rbNadaExperienciaRecepcional.IsChecked = true;
                }
                if (informacionAcademica.ExperienciaRecepcional == "No la cursé")
                {
                    rbNoCursoExperienciaRecepcional.IsChecked = true;
                }
            }

            if (informacionAcademica.DesarrolloAplicacionesEnRed == "Mucho")
            {
                rbMuchoDesarrolloAplicacionesEnRed.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.DesarrolloAplicacionesEnRed == "Regular")
                {
                    rbRegularDesarrolloAplicacionesEnRed.IsChecked = true;
                }
                if (informacionAcademica.DesarrolloAplicacionesEnRed == "Poco")
                {
                    rbPocoDesarrolloAplicacionesEnRed.IsChecked = true;
                }
                if (informacionAcademica.DesarrolloAplicacionesEnRed == "Nada")
                {
                    rbNadaDesarrolloAplicacionesEnRed.IsChecked = true;
                }
                if (informacionAcademica.DesarrolloAplicacionesEnRed == "No la cursé")
                {
                    rbNoCursoDesarrolloAplicacionesEnRed.IsChecked = true;
                }
            }

            if (informacionAcademica.IngenieriaSoftware3 == "Mucho")
            {
                rbMuchoIngenieriaSoftware3.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.IngenieriaSoftware3 == "Regular")
                {
                    rbRegularIngenieriaSoftware3.IsChecked = true;
                }
                if (informacionAcademica.IngenieriaSoftware3 == "Poco")
                {
                    rbPocoIngenieriaSoftware3.IsChecked = true;
                }
                if (informacionAcademica.IngenieriaSoftware3 == "Nada")
                {
                    rbNadaIngenieriaSoftware3.IsChecked = true;
                }
                if (informacionAcademica.IngenieriaSoftware3 == "No la cursé")
                {
                    rbNoCursoIngenieriaSoftware3.IsChecked = true;
                }
            }

            if (informacionAcademica.Graficacion == "Mucho")
            {
                rbMuchoGraficacion.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Graficacion == "Regular")
                {
                    rbRegularGraficacion.IsChecked = true;
                }
                if (informacionAcademica.Graficacion == "Poco")
                {
                    rbPocoGraficacion.IsChecked = true;
                }
                if (informacionAcademica.Graficacion == "Nada")
                {
                    rbNadaGraficacion.IsChecked = true;
                }
                if (informacionAcademica.Graficacion == "No la cursé")
                {
                    rbNoCursoGraficacion.IsChecked = true;
                }
            }

            if (informacionAcademica.SistemasInformacionEmpresarial == "Mucho")
            {
                rbMuchoSistemasInformacionEmpresarial.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.SistemasInformacionEmpresarial == "Regular")
                {
                    rbRegularSistemasInformacionEmpresarial.IsChecked = true;
                }
                if (informacionAcademica.SistemasInformacionEmpresarial == "Poco")
                {
                    rbPocoSistemasInformacionEmpresarial.IsChecked = true;
                }
                if (informacionAcademica.SistemasInformacionEmpresarial == "Nada")
                {
                    rbNadaSistemasInformacionEmpresarial.IsChecked = true;
                }
                if (informacionAcademica.SistemasInformacionEmpresarial == "No la cursé")
                {
                    rbNoCursoSistemasInformacionEmpresarial.IsChecked = true;
                }
            }

            if (informacionAcademica.AdministracionSeguridadDeServiciosEnRed == "Mucho")
            {
                rbMuchoAdminsitracionYSeguridadDeServiciosDeRed.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.AdministracionSeguridadDeServiciosEnRed == "Regular")
                {
                    rbRegularAdminsitracionYSeguridadDeServiciosDeRed.IsChecked = true;
                }
                if (informacionAcademica.AdministracionSeguridadDeServiciosEnRed == "Poco")
                {
                    rbPocoAdminsitracionYSeguridadDeServiciosDeRed.IsChecked = true;
                }
                if (informacionAcademica.AdministracionSeguridadDeServiciosEnRed == "Nada")
                {
                    rbNadaAdminsitracionYSeguridadDeServiciosDeRed.IsChecked = true;
                }
                if (informacionAcademica.AdministracionSeguridadDeServiciosEnRed == "No la cursé")
                {
                    rbNoCursoAdminsitracionYSeguridadDeServiciosDeRed.IsChecked = true;
                }
            }

            if(informacionAcademica.TopicosSelectos1 == "Mucho")
            {
                rbMuchoTopicosSelectosComputacion1.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.TopicosSelectos1 == "Regular")
                {
                    rbMRegularTopicosSelectosComputacion1.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos1 == "Poco")
                {
                    rbPocoTopicosSelectosComputacion1.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos1 == "Nada")
                {
                    rbNadaTopicosSelectosComputacion1.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos1 == "No la cursé")
                {
                    rbNoCursoTopicosSelectosComputacion1.IsChecked = true;
                }
            }

            if (informacionAcademica.TopicosSelectos2 == "Mucho")
            {
                rbMuchoTopicosSelectosComputacion2.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.TopicosSelectos2 == "Regular")
                {
                    rbRegularTopicosSelectosComputacion2.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos2 == "Poco")
                {
                    rbPocoTopicosSelectosComputacion2.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos2 == "Nada")
                {
                    rbNadaTopicosSelectosComputacion2.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos2 == "No la cursé")
                {
                    rbNoCursoTopicosSelectosComputacion2.IsChecked = true;
                }
            }

            if (informacionAcademica.TopicosSelectos3 == "Mucho")
            {
                rbMuchoTopicosSelectosComputacion3.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.TopicosSelectos3 == "Regular")
                {
                    rbRegularTopicosSelectosComputacion3.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos3 == "Poco")
                {
                    rbPocoTopicosSelectosComputacion3.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos3 == "Nada")
                {
                    rbNadaTopicosSelectosComputacion3.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos3 == "No la cursé")
                {
                    rbNoCursoTopicosSelectosComputacion3.IsChecked = true;
                }
            }

            if (informacionAcademica.TopicosSelectos4 == "Mucho")
            {
                rbMuchoTopicosSelectosComputacion4.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.TopicosSelectos4 == "Regular")
                {
                    rbRegularTopicosSelectosComputacion4.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos4 == "Poco")
                {
                    rbPocoTopicosSelectosComputacion4.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos4 == "Nada")
                {
                    rbNadaTopicosSelectosComputacion4.IsChecked = true;
                }
                if (informacionAcademica.TopicosSelectos4 == "No la cursé")
                {
                    rbNoCursoTopicosSelectosComputacion4.IsChecked = true;
                }
            }

            if (informacionAcademica.SistemasInformacionGeografica == "Mucho")
            {
                rbMuchoSistemasInformacionGeografica.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.SistemasInformacionGeografica == "Regular")
                {
                    rbRegularSistemasInformacionGeografica.IsChecked = true;
                }
                if (informacionAcademica.SistemasInformacionGeografica == "Poco")
                {
                    rbPocoSistemasInformacionGeografica.IsChecked = true;
                }
                if (informacionAcademica.SistemasInformacionGeografica == "Nada")
                {
                    rbNadaSistemasInformacionGeografica.IsChecked = true;
                }
                if (informacionAcademica.SistemasInformacionGeografica == "No la cursé")
                {
                    rbNoCursoSistemasInformacionGeografica.IsChecked = true;
                }
            }

            if (informacionAcademica.Multimedia == "Mucho")
            {
                rbMuchoMultimedia.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Multimedia == "Regular")
                {
                    rbRegularMultimedia.IsChecked = true;
                }
                if (informacionAcademica.Multimedia == "Poco")
                {
                    rbPocoMultimedia.IsChecked = true;
                }
                if (informacionAcademica.Multimedia == "Nada")
                {
                    rbNadaMultimedia.IsChecked = true;
                }
                if (informacionAcademica.Multimedia == "No la cursé")
                {
                    rbNoCursoMultimedia.IsChecked = true;
                }
            }

            if (informacionAcademica.AuditoriaInformatica == "Mucho")
            {
                rbMuchoAuditoriaInformatica.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.AuditoriaInformatica == "Regular")
                {
                    rbRegularAuditoriaInformatica.IsChecked = true;
                }
                if (informacionAcademica.AuditoriaInformatica == "Poco")
                {
                    rbPocoAuditoriaInformatica.IsChecked = true;
                }
                if (informacionAcademica.AuditoriaInformatica == "Nada")
                {
                    rbNadaAuditoriaInformatica.IsChecked = true;
                }
                if (informacionAcademica.AuditoriaInformatica == "No la cursé")
                {
                    rbNoCursoAuditoriaInformatica.IsChecked = true;
                }
            }

            if (informacionAcademica.TallerIntegracion4 == "Mucho")
            {
                rbMuchoTallerIntegracion4.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.TallerIntegracion4 == "Regular")
                {
                    rbRegularTallerIntegracion4.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion4 == "Poco")
                {
                    rbPocoTallerIntegracion4.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion4 == "Nada")
                {
                    rbNadaTallerIntegracion4.IsChecked = true;
                }
                if (informacionAcademica.TallerIntegracion4 == "No la cursé")
                {
                    rbNoCursoTallerIntegracion4.IsChecked = true;
                }
            }

            if (informacionAcademica.Redes3 == "Mucho")
            {
                rbMuchoRedes3.IsChecked = true;
            }
            else
            {
                if (informacionAcademica.Redes3 == "Regular")
                {
                    rbRegularRedes3.IsChecked = true;
                }
                if (informacionAcademica.Redes3 == "Poco")
                {
                    rbPocoRedes3.IsChecked = true;
                }
                if (informacionAcademica.Redes3 == "Nada")
                {
                    rbNadaRedes3.IsChecked = true;
                }
                if (informacionAcademica.Redes3 == "No la cursé")
                {
                    rbNoCursoRedes3.IsChecked = true;
                }
            }
        }
    }
}
