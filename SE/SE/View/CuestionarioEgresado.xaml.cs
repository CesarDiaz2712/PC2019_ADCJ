using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SE.model.dao;
using SE.model.pocos;

namespace SE.View
{
    /*
     * Para los checkbox se crea variables diferentes para diferentes respuestas,
     * para tener cada una de las diferentes respuestas.
     */
    public partial class CuestionarioEgresado : Window
    {
        private InformacionAcademica informacionAcademica;
        private bool nuevo;
        private string trabajoLigadoFormacion = "";
        private string tiempoTranscurridoPrimerEmpleo = "";
        private string promedioIngresoMensual = "";
        private string razonNoEncontrartrabajo = "";
        private string importanciaExperiencia = "";
        private string tipoOrganismo = "";
        private string saberesTeoricosRespuesta1 = "";
        private string saberesTeoricosRespuesta2 = "";
        private string saberesTeoricosRespuesta3 = "";
        private string saberesTeoricosRespuesta4 = "";
        private string saberesTeoricosRespuesta5 = "";
        private string saberesTeoricosRespuesta6 = "";
        private string saberesTeoricosRespuesta7 = "";
        private string saberesTeoricosRespuesta8 = "";
        private string saberesTeoricosRespuesta9 = "";
        private string saberesTeoricosRespuesta10 = "";
        private string saberesHeuristicosRespuesta1 = "";
        private string saberesHeuristicosRespuesta2 = "";
        private string saberesHeuristicosRespuesta3 = "";
        private string saberesHeuristicosRespuesta4 = "";
        private string saberesHeuristicosRespuesta5 = "";
        private string saberesHeuristicosRespuesta6 = "";
        private string saberesHeuristicosRespuesta7 = "";
        private string saberesAxiologicosRespuesta1 = "";
        private string saberesAxiologicosRespuesta2 = "";
        private string saberesAxiologicosRespuesta3 = "";
        private string saberesAxiologicosRespuesta4 = "";
        private string saberesAxiologicosRespuesta5 = "";
        private string saberesAxiologicosRespuesta6 = "";
        private string saberesAxiologicosRespuesta7 = "";
        private string saberesAxiologicosRespuesta8 = "";
        private string saberesAxiologicosRespuesta9 = "";
        private string saberesAxiologicosRespuesta10 = "";
        private string saberesAxiologicosRespuesta11 = "";
        private string saberesAxiologicosRespuesta12 = "";
        private string saberesAxiologicosRespuesta13 = "";
        private string saberesAxiologicosRespuesta14 = "";
        private string saberesAxiologicosRespuesta15 = "";
        private string saberesAxiologicosRespuesta16 = "";
        private string saberesAxiologicosRespuesta17 = "";
        private string saberesAxiologicosRespuesta18 = "";
        private string saberesAxiologicosRespuesta19 = "";
        private string funcionesRealizadasRespuesta1 = "";
        private string funcionesRealizadasRespuesta2 = "";
        private string funcionesRealizadasRespuesta3 = "";
        private string funcionesRealizadasRespuesta4 = "";
        private string funcionesRealizadasRespuesta5 = "";
        private string funcionesRealizadasRespuesta6 = "";
        private string propiaEmpresa = "";
        private string propiaEmpresaPorque = "";
        private string diferenciaConocimientoRespuesta1 = "";
        private string diferenciaConocimientoRespuesta2 = "";
        private string diferenciaConocimientoRespuesta3 = "";
        private string diferenciaConocimientoRespuesta4 = "";
        private string diferenciaConocimientoRespuesta5 = "";
        private string diferenciaConocimientoRespuesta6 = "";
        private string diferenciaConocimientoRespuesta7 = "";
        private string diferenciaConocimientoRespuesta8 = "";
        private string formacionProfesional = "";

        private string formacionActual = "";
        private string planDeEstudios = "";
        private string desempeñoDocentes = "";
        private string organizacionAdministrativa = "";
        private string instalacion = "";
        private string serviciosApoyo = "";
        private string actCulturalesYDeportivas = "";
        private string ingles1 = "";
        private string ingles2 = "";
        private string computacionBasica = "";
        private string lecturaRedaccion = "";
        private string habilidadesPensamiento = "";
        private string algebraLineal = "";
        private string probabilidad = "";
        private string matematicasDiscretas = "";
        private string algoritmosEstucturasDatos1 = "";
        private string arquitecturaComputadoras1 = "";
        private string metodologiaInvestigacion = "";
        private string logica = "";
        private string calculo = "";
        private string redes1 = "";
        private string redes2= "";
        private string ingenieriaSoftware1 = "";
        private string ingenieriaSoftware2 = "";
        private string basesDatos1 = "";
        private string basesDatos2 = "";
        private string tallerIntegracion1 = "";
        private string sistemasOperativos = "";
        private string arquitecturaComputadoras2 = "";
        private string algoritmosEstructurasDatos2 = "";
        private string organizacionArchivos = "";
        private string inteligenciaArtificial = "";
        private string tallerIntegracion2 = "";
        private string tallerIntegracion3 = "";
        private string programacionAvanzada = "";
        private string programacionDeSistemas = "";
        private string eticaLegislacionInformatica = "";
        private string fundamentosAdministracion = "";
        private string administracionProyectos = "";
        private string compiladores = "";
        private string administracionRecursosInformaticos = "";
        private string servicioSocial = "";
        private string experienciaRecepcional = "";
        private string desarrolloAplicacionesEnRed = "";
        private string ingenieriaSoftware3 = "";
        private string graficacion = "";
        private string sistemasInformacionEmpresarial = "";
        private string administracionSeguridadDeServiciosEnRed = "";
        private string topicosSelectos1 = "";
        private string topicosSelectos2 = "";
        private string topicosSelectos3 = "";
        private string topicosSelectos4 = "";
        private string sistemasInformacionGeografica = "";
        private string multimedia = "";
        private string auditoriaInformatica = "";
        private string tallerIntegracion4 = "";
        private string redes3 = "";


        private Boolean resultado;
        private Egresado informacionEgresado;
        private FichaPreEgreso ficha;
        private InformacionLaboral informacionLaboral;

        public CuestionarioEgresado(Egresado informacionEgresado, FichaPreEgreso ficha, InformacionLaboral informacionLaboral, InformacionAcademica informacionAcademica,Boolean nuevo)
        {
            this.nuevo=nuevo;
            this.informacionAcademica = informacionAcademica;
            this.informacionLaboral = informacionLaboral;
            this.informacionEgresado = informacionEgresado;
            this.ficha = ficha;
            InitializeComponent();
            txtNombres.Text = informacionEgresado.Nombre;
            txtApellidos.Text = informacionEgresado.Apellidos;
            txtMatricula.Text = informacionEgresado.Matricula;
            txtCalle.Text = ficha.Calle;
            txtNumeroCasa.Text = ficha.NumeroCasa;
            txtColonia.Text = ficha.Colonia;
            txtCiudad.Text = ficha.Ciudad;
            txtEstado.Text = ficha.Estado;
            txtCP.Text = ficha.CodigoPostal;
            txtTelefono.Text = ficha.Telefono;
            txtEmail.Text = ficha.Email;
        }
        
        public bool Resultado { get => resultado; set => resultado = value; }

        private void btn_Guardar_Click_Laboral(object sender, RoutedEventArgs e)
        {
            if (rbSi.IsChecked == true)
            {
                this.trabajoLigadoFormacion = "Sí";
            } 
            else
            {
                this.trabajoLigadoFormacion = "No";
            }


            if( rbMenosDe6Meses.IsChecked == true)
            {
                this.tiempoTranscurridoPrimerEmpleo = "Menos de 6 meses";
            } 
            else
            {
                if (rb6a12Meses.IsChecked == true)
                {
                    this.tiempoTranscurridoPrimerEmpleo = "6 a 12 meses";
                }
                if (rb12a18Meses.IsChecked == true)
                {
                    this.tiempoTranscurridoPrimerEmpleo = "12 a 18 meses";
                }                 
                if (rb18a24Meses.IsChecked == true)
                {
                    this.tiempoTranscurridoPrimerEmpleo = "18 a 24 meses";
                }           
                if(rbMasDe24Meses.IsChecked == true)
                {
                    this.tiempoTranscurridoPrimerEmpleo = "Mas de 24 meses";
                }
                if(rbSinTrabajo.IsChecked == true)
                {
                    this.tiempoTranscurridoPrimerEmpleo = "No he trabajado";
                }
            }

            if(rb5000.IsChecked == true)
            {
                this.promedioIngresoMensual = "Menos de 5000";
            }
            else
            {
                if(rb5001a10000.IsChecked == true)
                {
                    this.promedioIngresoMensual = "De 5000 a 10000";
                }
                if(rb10001a15000.IsChecked == true)
                {
                    this.promedioIngresoMensual = "De 10001 a 15000";
                }
                if(rb15001a20000.IsChecked == true)
                {
                    this.promedioIngresoMensual = "De 15001 a 20000";
                }
                if(rb20001oMas.IsChecked == true)
                {
                    this.promedioIngresoMensual = "20001 o mas";
                }
            }

            if (rbPersonales.IsChecked==true)
            {
                this.razonNoEncontrartrabajo = "Personales";
            }
            else
            {
                if (rbNoPerfil.IsChecked==true)
                {
                    this.razonNoEncontrartrabajo = "No cumplir perfil solicitado";
                }
                if (rbFaltaOferta.IsChecked==true)
                {
                    this.razonNoEncontrartrabajo = "Falta de oferta de trabajo";
                }
                if (txtOtraRazon.Text.Length>0 || txtOtraRazon.Text != null)
                {
                    this.razonNoEncontrartrabajo = txtOtraRazon.Text;
                }
            }

            if (rbMucha.IsChecked==true)
            {
                this.importanciaExperiencia = "Mucha";
            }
            else
            {
                if (rbPoca.IsChecked==true)
                {
                    this.importanciaExperiencia = "Poca";
                }
                if (rbNinguna.IsChecked==true)
                {
                    this.importanciaExperiencia = "Ninguna";
                }
            }

            if (rbPrivada.IsChecked==true)
            {
                this.tipoOrganismo = "Privada";
            }
            else
            {
                if (rbPublica.IsChecked==true)
                {
                    this.tipoOrganismo = "Publica";
                }
                if (rbIndependiente.IsChecked==true)
                {
                    this.tipoOrganismo = "Ejerce en forma Independiente";
                }
                if (rbGubernamental.IsChecked==true)
                {
                    this.tipoOrganismo = "Gubernamental";
                }
                if (rbEducativa.IsChecked==true)
                {
                    this.tipoOrganismo = "Educativa";
                }
            }

            if (chkAlgoritmiaAdquirida.IsChecked==true)
            {
                this.saberesTeoricosRespuesta1 = "Algoritmia";
            }
            if (chkProgramacionEstructuradaAdquirida.IsChecked==true)
            {
                this.saberesTeoricosRespuesta2 = "Programacion Estructurada";
            }
            if (chkProgramacionConcurrenteAdquirida.IsChecked==true)
            {
                this.saberesTeoricosRespuesta3 = "Programacion Concurrente";
            }
            if (chkSistemasInteligentesAdquirida.IsChecked==true)
            {
                this.saberesTeoricosRespuesta4 = "Sistemas Inteligentes";
            }
            if (chkRedesAdquirida.IsChecked==true)
            {
                this.saberesTeoricosRespuesta5 = "Redes";
            }
            if (chkEstructuraDatosAdquirida.IsChecked==true)
            {
                this.saberesTeoricosRespuesta6 = "Estructura de Datos";
            }
            if (chkIngenieriaSoftwareAdquirida.IsChecked==true)
            {
                this.saberesTeoricosRespuesta7 = "Ingenieria de Software";
            }
            if (chkBasesDatosAdquirida.IsChecked==true)
            {
                this.saberesTeoricosRespuesta8 = "Base de Datos";
            }
            if (chkProcesosAdquirida.IsChecked==true)
            {
                this.saberesTeoricosRespuesta9 = "Procesos de Desarrollo de Software";
            }
            if (chkProgramacionObjetosAdquirida.IsChecked==true)
            {
                this.saberesTeoricosRespuesta10 = "Programacion Orientada a Objetos";
            }

            if (chkProblemasAlgoritmicosAdquirido.IsChecked==true)
            {
                this.saberesHeuristicosRespuesta1 = "Planteamiento y Solucion a Problemas algoritmicos";
            }
            if (chkDiseñoImplantacionProgramasAdquirido.IsChecked==true)
            {
                this.saberesHeuristicosRespuesta2 = "Diseño e Implantacion de Programas";
            }
            if (chkDiseñoImplantacionBaseDatos.IsChecked==true)
            {
                this.saberesHeuristicosRespuesta3 = "Diseño e implementacion de base de datos";
            }
            if (chkDiseñoRedesAdquirido.IsChecked==true)
            {
                this.saberesHeuristicosRespuesta4 = "Diseño e implementacion de redes";
            }
            if (chkDiseñoImplantacionSistemas.IsChecked==true)
            {
                this.saberesHeuristicosRespuesta5 = "Diseño e implementacion de sistemas inteligentes";
            }
            if (chkUsoLenguaje.IsChecked==true)
            {
                this.saberesHeuristicosRespuesta6 = "Uso de un lenguaje de programación y su entorno de desarrollo para codificar y probar algoritmos";
            }
            if (chkAplicacionMetodologiaAdquirido.IsChecked==true)
            {
                this.saberesHeuristicosRespuesta7 = "Aplicación de una metodología para la obtención de modelos de análisis y diseño de un sistema de software";
            }

            if (chkCreatividad.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta1 = "Creatividad";
            }
            if (chkResponsabilidad.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta2 = "Responsabilidad";
            }
            if (chkPaciencia.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta3 = "Paciencia";
            }
            if (chkTrabajoEquipo.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta4 = "Trabajo en Equipo";
            }
            if (chkColaboracion.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta5 = "Colaboracion";
            }
            if (chkOriginalidad.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta6 = "Originalidad";
            }
            if (chkHonestidad.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta7 = "Honetidad";
            }
            if (chkRespeto.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta8 = "Respeto";
            }
            if (chkDiscrecion.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta9 = "Discrecion";
            }
            if (chkMeticulosidad.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta10 = "Meticulosidad";
            }
            if (chkCooperacion.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta11 = "Cooperacion";
            }
            if (chkIniciativa.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta12 = "Iniciativa";
            }
            if (chkInteres.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta13 = "Interes";
            }
            if (chkAutoAprendizaje.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta14 = "AutoAprendizaje";
            }
            if (chkCoherencia.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta15 = "Coherencia";
            }
            if (chkCuriosidad.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta16 = "Curiosidad";
            }
            if (chkImaginacion.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta17 = "Imaginacion";
            }
            if (chkTolerencia.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta18 = "Tolerancia";
            }
            if (chkConstancia.IsChecked==true)
            {
                this.saberesAxiologicosRespuesta19 = "Constancia";
            }

            if (chkOrganizacionRealizada.IsChecked==true)
            {
                this.funcionesRealizadasRespuesta1 = "Organizacion";
            }
            if (chkPlaneacionRealizada.IsChecked==true)
            {
                this.funcionesRealizadasRespuesta2 = "Planeacion";
            }
            if (chkDiagnosticoRealizado.IsChecked==true)
            {
                this.funcionesRealizadasRespuesta3 = "Diagnostico";
            }
            if (chkCooperacionRealizada.IsChecked==true)
            {
                this.funcionesRealizadasRespuesta4 = "Cooperacion";
            }
            if (chkDiscrecionRealizada.IsChecked==true)
            {
                this.funcionesRealizadasRespuesta5 = "Discrecion";
            }
            if (chkControlRealizado.IsChecked==true)
            {
                this.funcionesRealizadasRespuesta6 = "Control";
            }

            if (rbSiPregunta16.IsChecked==true && txtPropiaEmpresa.Text.Length>0)
            {
                this.propiaEmpresa = "Si";
                this.propiaEmpresaPorque = txtPropiaEmpresa.Text;
            }
            else
            {
                if (rbNoPregunta16.IsChecked==true && txtPropiaEmpresa.Text.Length>0)
                {
                    this.propiaEmpresa = "No";
                    this.propiaEmpresaPorque = txtPropiaEmpresa.Text;
                }
            }

            if (chkManejoBaseDatos.IsChecked==true)
            {
                this.diferenciaConocimientoRespuesta1 = "Manejo de Bases de Datos";
            }
            if (chkSistemas.IsChecked==true)
            {
                this.diferenciaConocimientoRespuesta2 = "Programacion de Sistemas";
            }
            if (chkManejoRedes.IsChecked==true)
            {
                this.diferenciaConocimientoRespuesta3 = "Manejo de Redes";
            }
            if (chkManejoPaquetes.IsChecked==true)
            {
                this.diferenciaConocimientoRespuesta4 = "Manejo de Paquetes";
            }
            if (chkDiseñoWebsites.IsChecked==true)
            {
                this.diferenciaConocimientoRespuesta5 = "Disdeño de Websites";
            }
            if (chkManejoIdioma.IsChecked==true)
            {
                this.diferenciaConocimientoRespuesta6 = "Manejo de otro Idioma";
            }
            if (chkMantenimientoComputo.IsChecked==true)
            {
                this.diferenciaConocimientoRespuesta7 = "Mantenimiento de equipos de computo";
            }
            if (chkManejoMultimedia.IsChecked==true)
            {
                this.diferenciaConocimientoRespuesta8 = "Manejo de Multimedia";
            }

            if (rbExcelenteFormacion.IsChecked==true)
            {
                this.formacionProfesional = "Excelente";
            }
            else
            {
                if (rbMuyBuenaFormacion.IsChecked==true)
                {
                    this.formacionProfesional = "Muy Buena";
                }
                if (rbBuenaFormacion.IsChecked==true)
                {
                    this.formacionProfesional = "Buena";
                }
                if (rbRegularFormacion.IsChecked==true)
                {
                    this.formacionProfesional = "Regular";
                }
                if (rbMalaFormacion.IsChecked==true)
                {
                    this.formacionProfesional = "Mala";
                }
                if (rbMuyMalaFormacion.IsChecked==true)
                {
                    this.formacionProfesional = "Muy mala";
                }
            }


             this.informacionLaboral.CargoDesempenado = txtCargoDesempenado.Text;
             this.informacionLaboral.TipoContratacion = txtTipoContratacion.Text;
             this.informacionLaboral.TrabajoLigadoFormacion = trabajoLigadoFormacion;
             this.informacionLaboral.TiempoTranscurridoPrimerEmpleo = tiempoTranscurridoPrimerEmpleo;
             this.informacionLaboral.RazonNoEncontrartrabajo = razonNoEncontrartrabajo;
             this.informacionLaboral.ImportanciaExperiencia = importanciaExperiencia;
             this.informacionLaboral.TipoOrganismo = tipoOrganismo;
             this.informacionLaboral.ConocimientosTeoricos = txtConocimientosTeoricos.Text;
             this.informacionLaboral.SaberesHeuristicos = txtSaberesHeuristicos.Text;
             this.informacionLaboral.ExperienciaEducativaCursada = txtExperienciaEducativaCursadas.Text;
             this.informacionLaboral.SaberesTeoricosRespuesta1 = saberesTeoricosRespuesta1;
             this.informacionLaboral.SaberesTeoricosRespuesta2 = saberesTeoricosRespuesta2;
             this.informacionLaboral.SaberesTeoricosRespuesta3 = saberesTeoricosRespuesta3;
             this.informacionLaboral.SaberesTeoricosRespuesta4 = saberesTeoricosRespuesta4;
             this.informacionLaboral.SaberesTeoricosRespuesta5 = saberesTeoricosRespuesta5;
             this.informacionLaboral.SaberesTeoricosRespuesta6 = saberesTeoricosRespuesta6;
             this.informacionLaboral.SaberesTeoricosRespuesta7 = saberesTeoricosRespuesta7;
             this.informacionLaboral.SaberesTeoricosRespuesta8 = saberesTeoricosRespuesta8;
             this.informacionLaboral.SaberesTeoricosRespuesta9 = saberesTeoricosRespuesta9;
             this.informacionLaboral.SaberesTeoricosRespuesta10 = saberesTeoricosRespuesta10;
             this.informacionLaboral.SaberesHeuristicosRespuesta1 = saberesHeuristicosRespuesta1;
             this.informacionLaboral.SaberesHeuristicosRespuesta2 = saberesHeuristicosRespuesta2;
             this.informacionLaboral.SaberesHeuristicosRespuesta3 = saberesHeuristicosRespuesta3;
             this.informacionLaboral.SaberesHeuristicosRespuesta4 = saberesHeuristicosRespuesta4;
             this.informacionLaboral.SaberesHeuristicosRespuesta5 = saberesHeuristicosRespuesta5;
             this.informacionLaboral.SaberesHeuristicosRespuesta6 = saberesHeuristicosRespuesta6;
             this.informacionLaboral.SaberesHeuristicosRespuesta7 = saberesHeuristicosRespuesta7;
             this.informacionLaboral.SaberesAxiologicosRespuesta1 = saberesAxiologicosRespuesta1;
             this.informacionLaboral.SaberesAxiologicosRespuesta2 = saberesAxiologicosRespuesta2;
             this.informacionLaboral.SaberesAxiologicosRespuesta3 = saberesAxiologicosRespuesta3;
             this.informacionLaboral.SaberesAxiologicosRespuesta4 = saberesAxiologicosRespuesta4;
             this.informacionLaboral.SaberesAxiologicosRespuesta5 = saberesAxiologicosRespuesta5;
             this.informacionLaboral.SaberesAxiologicosRespuesta6 = saberesAxiologicosRespuesta6;
             this.informacionLaboral.SaberesAxiologicosRespuesta7 = saberesAxiologicosRespuesta7;
             this.informacionLaboral.SaberesAxiologicosRespuesta8 = saberesAxiologicosRespuesta8;
             this.informacionLaboral.SaberesAxiologicosRespuesta9 = saberesAxiologicosRespuesta9;
             this.informacionLaboral.SaberesAxiologicosRespuesta10 = saberesAxiologicosRespuesta10;
             this.informacionLaboral.SaberesAxiologicosRespuesta11 = saberesAxiologicosRespuesta11;
             this.informacionLaboral.SaberesAxiologicosRespuesta12 = saberesAxiologicosRespuesta12;
             this.informacionLaboral.SaberesAxiologicosRespuesta13 = saberesAxiologicosRespuesta13;
             this.informacionLaboral.SaberesAxiologicosRespuesta14 = saberesAxiologicosRespuesta14;
             this.informacionLaboral.SaberesAxiologicosRespuesta15 = saberesAxiologicosRespuesta15;
             this.informacionLaboral.SaberesAxiologicosRespuesta16 = saberesAxiologicosRespuesta16;
             this.informacionLaboral.SaberesAxiologicosRespuesta17 = saberesAxiologicosRespuesta17;
             this.informacionLaboral.SaberesAxiologicosRespuesta18 = saberesAxiologicosRespuesta18;
             this.informacionLaboral.SaberesAxiologicosRespuesta19 = saberesAxiologicosRespuesta19;
             this.informacionLaboral.FuncionesRealizadasRespuesta1 = funcionesRealizadasRespuesta1;
             this.informacionLaboral.FuncionesRealizadasRespuesta2 = funcionesRealizadasRespuesta2;
             this.informacionLaboral.FuncionesRealizadasRespuesta3 = funcionesRealizadasRespuesta3;
             this.informacionLaboral.FuncionesRealizadasRespuesta4 = funcionesRealizadasRespuesta4;
             this.informacionLaboral.FuncionesRealizadasRespuesta5 = funcionesRealizadasRespuesta5;
             this.informacionLaboral.FuncionesRealizadasRespuesta6 = funcionesRealizadasRespuesta6;
             this.informacionLaboral.FuncionesDesempenadas = txtFuncionesDesempeñadas.Text;
             this.informacionLaboral.ProblematicasSolucionadas = txtProblematicasSolucionadas.Text;
             this.informacionLaboral.PromedioIngresoMensual = promedioIngresoMensual;
             this.informacionLaboral.PropiaEmpresa = propiaEmpresa;
             this.informacionLaboral.PropiaEmpresaPorque = propiaEmpresaPorque;
             this.informacionLaboral.DiferenciaConocimientoRespuesta1 = diferenciaConocimientoRespuesta1;
             this.informacionLaboral.DiferenciaConocimientoRespuesta2 = diferenciaConocimientoRespuesta2;
             this.informacionLaboral.DiferenciaConocimientoRespuesta3 = diferenciaConocimientoRespuesta3;
             this.informacionLaboral.DiferenciaConocimientoRespuesta4 = diferenciaConocimientoRespuesta4;
             this.informacionLaboral.DiferenciaConocimientoRespuesta5 = diferenciaConocimientoRespuesta5;
             this.informacionLaboral.DiferenciaConocimientoRespuesta6 = diferenciaConocimientoRespuesta6;
             this.informacionLaboral.DiferenciaConocimientoRespuesta7 = diferenciaConocimientoRespuesta7;
             this.informacionLaboral.DiferenciaConocimientoRespuesta8 = diferenciaConocimientoRespuesta8;
             this.informacionLaboral.FormacionProfesional = formacionProfesional;

            this.Resultado = InformaciónLaboralDAO.guardar(this.informacionLaboral,this.nuevo);
        }


        private void btnFinalizarAcademica_Click(object sender, RoutedEventArgs e)
        {
            if (rbLicenciatura.IsChecked == true)
            {
                this.formacionActual = "Licenciatura";
            }
            else
            {
                if (rbEscpecialidad.IsChecked == true)
                {
                    this.formacionActual = "Especialidad";
                }
                if (rbMaestria.IsChecked == true)
                {
                    this.formacionActual = "Maestria";
                }
                if (rbDoctorado.IsChecked == true)
                {
                    this.formacionActual = "Doctorado";
                }
                if (rbPosDoctorado.IsChecked == true)
                {
                    this.formacionActual = "Posdoctorado";
                }
            }

            if (rbEficientePlanEstudiantil.IsChecked == true)
            {
                this.planDeEstudios = "Eficiente";
            }
            else
            {
                if (rbAceptablePlanEstudiantil.IsChecked == true)
                {
                    this.planDeEstudios = "Aceptable";
                }
                if (rbRegularPlanEstudiantil.IsChecked == true)
                {
                    this.planDeEstudios = "Regular";
                }
                if (rbDeficientePlanEstudiantil.IsChecked == true)
                {
                    this.planDeEstudios = "Deficiente";
                }
            }

            if (rbEficienteDocentes.IsChecked == true)
            {
                this.desempeñoDocentes = "Eficiente";
            }
            else
            {
                if (rbAceptableDocentes.IsChecked == true)
                {
                    this.desempeñoDocentes = "Aceptable";
                }
                if (rbRegularDocentes.IsChecked == true)
                {
                    this.desempeñoDocentes = "Regular";
                }
                if (rbDeficienteDocentes.IsChecked == true)
                {
                    this.desempeñoDocentes = "Deficiente";
                }
            }

            if (rbEficienteOrganizacion.IsChecked == true)
            {
                this.organizacionAdministrativa = "Eficiente";
            }
            else
            {
                if (rbAceptableOrganizacion.IsChecked == true)
                {
                    this.organizacionAdministrativa = "Aceptable";
                }
                if (rbRegularOrganizacion.IsChecked == true)
                {
                    this.organizacionAdministrativa = "Regular";
                }
                if (rbDeficienteOrganizacion.IsChecked == true)
                {
                    this.organizacionAdministrativa = "Deficiente";
                }
            }

            if (rbEficienteInstalacion.IsChecked == true)
            {
                this.instalacion = "Eficiente";
            }
            else
            {
                if (rbAceptableInstalacion.IsChecked == true)
                {
                    this.instalacion = "Aceptable";
                }
                if (rbRegularInstalacion.IsChecked == true)
                {
                    this.instalacion = "Regular";
                }
                if (rbDeficienteInstalacion.IsChecked == true)
                {
                    this.instalacion = "Deficiente";
                }
            }

            if (rbEficienteServicio.IsChecked == true)
            {
                this.serviciosApoyo = "Eficiente";
            }
            else
            {
                if (rbAceptableServicio.IsChecked == true)
                {
                    this.serviciosApoyo = "Aceptable";
                }
                if (rbRegularServicio.IsChecked == true)
                {
                    this.serviciosApoyo = "Regular";
                }
                if (rbDeficienteServicio.IsChecked == true)
                {
                    this.serviciosApoyo = "Deficiente";
                }
            }

            if (rbEficienteActDeportivas.IsChecked == true)
            {
                this.actCulturalesYDeportivas = "Eficiente";
            }
            else
            {
                if (rbAceptableActDeportivas.IsChecked == true)
                {
                    this.actCulturalesYDeportivas = "Aceptable";
                }
                if (rbRegularActDeportivas.IsChecked == true)
                {
                    this.actCulturalesYDeportivas = "Regular";
                }
                if (rbDeficienteActDeportivas.IsChecked == true)
                {
                    this.actCulturalesYDeportivas = "Deficiente";
                }
            }

            if (rbMuchoIngles1.IsChecked == true)
            {
                this.ingles1 = "Mucho";
            }
            else
            {
                if (rbRegularIngles1.IsChecked == true)
                {
                    this.ingles1 = "Regular";
                }
                if (rbPocoIngles1.IsChecked == true)
                {
                    this.ingles1 = "Poco";
                }
                if (rbNadaIngles1.IsChecked == true)
                {
                    this.ingles1 = "Nada";
                }
            }

            if (rbMuchoIngles2.IsChecked == true)
            {
                this.ingles2 = "Mucho";
            }
            else
            {
                if (rbRegularIngles2.IsChecked == true)
                {
                    this.ingles2 = "Regular";
                }
                if (rbPocoIngles2.IsChecked == true)
                {
                    this.ingles2 = "Poco";
                }
                if (rbNadaIngles2.IsChecked == true)
                {
                    this.ingles2 = "Nada";
                }
            }

            if (rbMuchoComputacionBasica.IsChecked == true)
            {
                this.computacionBasica = "Mucho";
            }
            else
            {
                if (rbRegularComputacionBasica.IsChecked == true)
                {
                    this.computacionBasica = "Regular";
                }
                if (rbPocoComputacionBasica.IsChecked == true)
                {
                    this.computacionBasica = "Poco";
                }
                if (rbNadaComputacionBasica.IsChecked == true)
                {
                    this.computacionBasica = "Nada";
                }
            }

            if (rbMuchoLecturaYRedaccion.IsChecked == true)
            {
                this.lecturaRedaccion = "Mucho";
            }
            else
            {
                if (rbRegularLecturaYRedaccion.IsChecked == true)
                {
                    this.lecturaRedaccion = "Regular";
                }
                if (rbPocoLecturaYRedaccion.IsChecked == true)
                {
                    this.lecturaRedaccion = "Poco";
                }
                if (rbNadaLecturaYRedaccion.IsChecked == true)
                {
                    this.lecturaRedaccion = "Nada";
                }
            }

            if (rbMuchoHabilidadesPensamiento.IsChecked == true)
            {
                this.habilidadesPensamiento = "Mucho";
            }
            else
            {
                if (rbRegularHabilidadesPensamiento.IsChecked == true)
                {
                    this.habilidadesPensamiento = "Regular";
                }
                if (rbPocoHabilidadesPensamiento.IsChecked == true)
                {
                    this.habilidadesPensamiento = "Poco";
                }
                if (rbNadaHabilidadesPensamiento.IsChecked == true)
                {
                    this.habilidadesPensamiento = "Nada";
                }
            }

            if (rbMuchoAlgebraLineal.IsChecked == true)
            {
                this.algebraLineal = "Mucho";
            }
            else
            {
                if (rbRegularAlgebraLineal.IsChecked == true)
                {
                    this.algebraLineal = "Regular";
                }
                if (rbPocoAlgebraLineal.IsChecked == true)
                {
                    this.algebraLineal = "Poco";
                }
                if (rbNadaAlgebraLineal.IsChecked == true)
                {
                    this.algebraLineal = "Nada";
                }
                if (rbNoCursoAlgebraLineal.IsChecked == true)
                {
                    this.algebraLineal = "No la cursé";
                }
            }

            if (rbMuchoProbabilidad.IsChecked == true)
            {
                this.probabilidad = "Mucho";
            }
            else
            {
                if (rbRegularProbabilidad.IsChecked == true)
                {
                    this.probabilidad = "Regular";
                }
                if (rbPocoProbabilidad.IsChecked == true)
                {
                    this.probabilidad = "Poco";
                }
                if (rbNadaProbabilidad.IsChecked == true)
                {
                    this.probabilidad = "Nada";
                }
                if (rbNoCursoProbabilidad.IsChecked == true)
                {
                    this.probabilidad = "No la cursé";
                }
            }

            if (rbMuchoMatematicasDiscretas.IsChecked == true)
            {
                this.matematicasDiscretas = "Mucho";
            }
            else
            {
                if (rbRegularMatematicasDiscretas.IsChecked == true)
                {
                    this.matematicasDiscretas = "Regular";
                }
                if (rbPocoMatematicasDiscretas.IsChecked == true)
                {
                    this.matematicasDiscretas = "Poco";
                }
                if (rbNadaMatematicasDiscretas.IsChecked == true)
                {
                    this.matematicasDiscretas = "Nada";
                }
                if (rbNoCursoMatematicasDiscretas.IsChecked == true)
                {
                    this.matematicasDiscretas = "No la cursé";
                }
            }

            if (rbMuchoAlgoritmosEstrucutrasDatos1.IsChecked == true)
            {
                this.algoritmosEstucturasDatos1 = "Mucho";
            }
            else
            {
                if (rbRegularAlgoritmosEstrucutrasDatos1.IsChecked == true)
                {
                    this.algoritmosEstucturasDatos1 = "Regular";
                }
                if (rbPocoAlgoritmosEstrucutrasDatos1.IsChecked == true)
                {
                    this.algoritmosEstucturasDatos1 = "Poco";
                }
                if (rbNadaAlgoritmosEstrucutrasDatos1.IsChecked == true)
                {
                    this.algoritmosEstucturasDatos1 = "Nada";
                }
                if (rbNoCursoAlgoritmosEstrucutrasDatos1.IsChecked == true)
                {
                    this.algoritmosEstucturasDatos1 = "No la cursé";
                }
            }

            if (rbMuchoArquitecturaDeComputadoras1.IsChecked == true)
            {
                this.arquitecturaComputadoras1 = "Mucho";
            }
            else
            {
                if (rbRegularArquitecturaDeComputadoras1.IsChecked == true)
                {
                    this.arquitecturaComputadoras1 = "Regular";
                }
                if (rbPocoArquitecturaDeComputadoras1.IsChecked == true)
                {
                    this.arquitecturaComputadoras1 = "Poco";
                }
                if (rbNadaArquitecturaDeComputadoras1.IsChecked == true)
                {
                    this.arquitecturaComputadoras1 = "Nada";
                }
                if (rbNoCursoArquitecturaDeComputadoras1.IsChecked == true)
                {
                    this.arquitecturaComputadoras1 = "No la cursé";
                }
            }

            if (rbMuchoMetodologiaInv.IsChecked == true)
            {
                this.metodologiaInvestigacion = "Mucho";
            }
            else
            {
                if (rbRegularMetodologiaInv.IsChecked == true)
                {
                    this.metodologiaInvestigacion = "Regular";
                }
                if (rbPocoMetodologiaInv.IsChecked == true)
                {
                    this.metodologiaInvestigacion = "Poco";
                }
                if (rbNadaMetodologiaInv.IsChecked == true)
                {
                    this.metodologiaInvestigacion = "Nada";
                }
                if (rbNoCursoMetodologiaInv.IsChecked == true)
                {
                    this.metodologiaInvestigacion = "No la cursé";
                }
            }

            if (rbMuchoLogica.IsChecked == true)
            {
                this.logica = "Mucho";
            }
            else
            {
                if (rbRegularLogica.IsChecked == true)
                {
                    this.logica = "Regular";
                }
                if (rbPocoLogica.IsChecked == true)
                {
                    this.logica = "Poco";
                }
                if (rbNadaLogica.IsChecked == true)
                {
                    this.logica = "Nada";
                }
                if (rbNoCursoLogica.IsChecked == true)
                {
                    this.logica = "No la cursé";
                }
            }

            if (rbMuchoCalculo.IsChecked == true)
            {
                this.calculo = "Mucho";
            }
            else
            {
                if (rbRegularCalculo.IsChecked == true)
                {
                    this.calculo = "Regular";
                }
                if (rbPocoCalculo.IsChecked == true)
                {
                    this.calculo = "Poco";
                }
                if (rbNadaCalculo.IsChecked == true)
                {
                    this.calculo = "Nada";
                }
                if (rbNoCursoCalculo.IsChecked == true)
                {
                    this.calculo = "No la cursé";
                }
            }

            if (rbMuchoRedes1.IsChecked == true)
            {
                this.redes1 = "Mucho";
            }
            else
            {
                if (rbRegularRedes1.IsChecked == true)
                {
                    this.redes1 = "Regular";
                }
                if (rbPocoRedes1.IsChecked == true)
                {
                    this.redes1 = "Poco";
                }
                if (rbNadaRedes1.IsChecked == true)
                {
                    this.redes1 = "Nada";
                }
                if (rbNoCursoRedes1.IsChecked == true)
                {
                    this.redes1 = "No la cursé";
                }
            }

            if (rbMuchoRedes2.IsChecked == true)
            {
                this.redes2 = "Mucho";
            }
            else
            {
                if (rbRegularRedes2.IsChecked == true)
                {
                    this.redes2 = "Regular";
                }
                if (rbPocoRedes2.IsChecked == true)
                {
                    this.redes2 = "Poco";
                }
                if (rbNadaRedes2.IsChecked == true)
                {
                    this.redes2 = "Nada";
                }
                if (rbNoCursoRedes2.IsChecked == true)
                {
                    this.redes2 = "No la cursé";
                }
            }

            if (rbMuchoIngeniriaSoftware1.IsChecked == true)
            {
                this.ingenieriaSoftware1 = "Mucho";
            }
            else
            {
                if (rbRegularIngeniriaSoftware1.IsChecked == true)
                {
                    this.ingenieriaSoftware1 = "Regular";
                }
                if (rbPocoIngenieriaSoftware1.IsChecked == true)
                {
                    this.ingenieriaSoftware1 = "Poco";
                }
                if (rbNadaIngenieriaSoftware1.IsChecked == true)
                {
                    this.ingenieriaSoftware1 = "Nada";
                }
                if (rbNoCursoIngenieriaSoftware1.IsChecked == true)
                {
                    this.ingenieriaSoftware1 = "No la cursé";
                }
            }

            if (rbMuchoIngenieriaSoftware2.IsChecked == true)
            {
                this.ingenieriaSoftware2 = "Mucho";
            }
            else
            {
                if (rbRegularIngenieriaSoftware2.IsChecked == true)
                {
                    this.ingenieriaSoftware2 = "Regular";
                }
                if (rbPocoIngenieriaSoftware2.IsChecked == true)
                {
                    this.ingenieriaSoftware2 = "Poco";
                }
                if (rbNadaIngenieriaSoftware2.IsChecked == true)
                {
                    this.ingenieriaSoftware2 = "Nada";
                }
                if (rbNoCursoIngenieriaSoftware2.IsChecked == true)
                {
                    this.ingenieriaSoftware2 = "No la cursé";
                }
            }

            if (rbMuchoBasesDatos1.IsChecked == true)
            {
                this.basesDatos1 = "Mucho";
            }
            else
            {
                if (rbRegularBasesDatos1.IsChecked == true)
                {
                    this.basesDatos1 = "Regular";
                }
                if (rbPocoBasesDatos1.IsChecked == true)
                {
                    this.basesDatos1 = "Poco";
                }
                if (rbNadaBasesDatos1.IsChecked == true)
                {
                    this.basesDatos1 = "Nada";
                }
                if (rbNoCursoBasesDatos1.IsChecked == true)
                {
                    this.basesDatos1 = "No la cursé";
                }
            }

            if (rbMuchoBasesDatos2.IsChecked == true)
            {
                this.basesDatos2 = "Mucho";
            }
            else
            {
                if (rbRegularBasesDatos2.IsChecked == true)
                {
                    this.basesDatos2 = "Regular";
                }
                if (rbPocoBasesDatos2.IsChecked == true)
                {
                    this.basesDatos2 = "Poco";
                }
                if (rbNadaBasesDatos2.IsChecked == true)
                {
                    this.basesDatos2 = "Nada";
                }
                if (rbNoCursoBasesDatos2.IsChecked == true)
                {
                    this.basesDatos2 = "No la cursé";
                }
            }

            if (rbMuchoTallerIntegracion1.IsChecked == true)
            {
                this.tallerIntegracion1 = "Mucho";
            }
            else
            {
                if (rbRegularTallerIntegracion1.IsChecked == true)
                {
                    this.tallerIntegracion1 = "Regular";
                }
                if (rbPocoTallerIntegracion1.IsChecked == true)
                {
                    this.tallerIntegracion1 = "Poco";
                }
                if (rbNadaTallerIntegracion1.IsChecked == true)
                {
                    this.tallerIntegracion1 = "Nada";
                }
                if (rbNoCursoTallerIntegracion1.IsChecked == true)
                {
                    this.tallerIntegracion1 = "No la cursé";
                }
            }

            if (rbMuchoSistemasOperativos.IsChecked == true)
            {
                this.sistemasOperativos = "Mucho";
            }
            else
            {
                if (rbRegularSistemasOperativos.IsChecked == true)
                {
                    this.sistemasOperativos = "Regular";
                }
                if (rbPocoSistemasOperativos.IsChecked == true)
                {
                    this.sistemasOperativos = "Poco";
                }
                if (rbNadaSistemasOperativos.IsChecked == true)
                {
                    this.sistemasOperativos = "Nada";
                }
                if (rbNoCursoSistemasOperativos.IsChecked == true)
                {
                    this.sistemasOperativos = "No la cursé";
                }
            }

            if (rbMuchoArquitecturaDeComputadoras2.IsChecked == true)
            {
                this.arquitecturaComputadoras2 = "Mucho";
            }
            else
            {
                if (rbRegularArquitecturaDeComputadoras2.IsChecked == true)
                {
                    this.arquitecturaComputadoras2 = "Regular";
                }
                if (rbPocoArquitecturaDeComputadoras2.IsChecked == true)
                {
                    this.arquitecturaComputadoras2 = "Poco";
                }
                if (rbNadaArquitecturaDeComputadoras2.IsChecked == true)
                {
                    this.arquitecturaComputadoras2 = "Nada";
                }
                if (rbNoCursoArquitecturaDeComputadoras2.IsChecked == true)
                {
                    this.arquitecturaComputadoras2 = "No la cursé";
                }
            }

            if (rbMuchoAlgoritmosEstructurasDatos2.IsChecked == true)
            {
                this.algoritmosEstructurasDatos2 = "Mucho";
            }
            else
            {
                if (rbRegularAlgoritmosEstructurasDatos2.IsChecked == true)
                {
                    this.algoritmosEstructurasDatos2 = "Regular";
                }
                if (rbPocoAlgoritmosEstructurasDatos2.IsChecked == true)
                {
                    this.algoritmosEstructurasDatos2 = "Poco";
                }
                if (rbNadaAlgoritmosEstructurasDatos2.IsChecked == true)
                {
                    this.algoritmosEstructurasDatos2 = "Nada";
                }
                if (rbNoCursoAlgoritmosEstructurasDatos2.IsChecked == true)
                {
                    this.algoritmosEstructurasDatos2 = "No la cursé";
                }
            }

            if (rbMuchoOrganizacionArchivos.IsChecked == true)
            {
                this.organizacionArchivos = "Mucho";
            }
            else
            {
                if (rbRegularOrganizacionArchivos.IsChecked == true)
                {
                    this.organizacionArchivos = "Regular";
                }
                if (rbPocoOrganizacionArchivos.IsChecked == true)
                {
                    this.organizacionArchivos = "Poco";
                }
                if (rbNadaOrganizacionArchivos.IsChecked == true)
                {
                    this.organizacionArchivos = "Nada";
                }
                if (rbNoCursoOrganizacionArchivos.IsChecked == true)
                {
                    this.organizacionArchivos = "No la cursé";
                }
            }

            if (rbMuchoInteligenciaArtificial.IsChecked == true)
            {
                this.inteligenciaArtificial = "Mucho";
            }
            else
            {
                if (rbRegularInteligenciaArtificial.IsChecked == true)
                {
                    this.inteligenciaArtificial = "Regular";
                }
                if (rbPocoInteligenciaArtificial.IsChecked == true)
                {
                    this.inteligenciaArtificial = "Poco";
                }
                if (rbNadaInteligenciaArtificial.IsChecked == true)
                {
                    this.inteligenciaArtificial = "Nada";
                }
                if (rbNoCursoInteligenciaArtificial.IsChecked == true)
                {
                    this.inteligenciaArtificial = "No la cursé";
                }
            }

            if (rbMuchoTallerIntegracion2.IsChecked == true)
            {
                this.tallerIntegracion2 = "Mucho";
            }
            else
            {
                if (rbRegularTallerIntegracion2.IsChecked == true)
                {
                    this.tallerIntegracion2 = "Regular";
                }
                if (rbPocoTallerIntegracion2.IsChecked == true)
                {
                    this.tallerIntegracion2 = "Poco";
                }
                if (rbNadaTallerIntegracion2.IsChecked == true)
                {
                    this.tallerIntegracion2 = "Nada";
                }
                if (rbNoCursoTallerIntegracion2.IsChecked == true)
                {
                    this.tallerIntegracion2 = "No la cursé";
                }
            }

            if (rbMuchoTallerIntegracion3.IsChecked == true)
            {
                this.tallerIntegracion3 = "Mucho";
            }
            else
            {
                if (rbRegularTallerIntegracion3.IsChecked == true)
                {
                    this.tallerIntegracion3 = "Regular";
                }
                if (rbPocoTallerIntegracion3.IsChecked == true)
                {
                    this.tallerIntegracion3 = "Poco";
                }
                if (rbNadaTallerIntegracion3.IsChecked == true)
                {
                    this.tallerIntegracion3 = "Nada";
                }
                if (rbNoCursoTallerIntegracion3.IsChecked == true)
                {
                    this.tallerIntegracion3 = "No la cursé";
                }
            }

            if (rbMuchoProgramacionAvanzada.IsChecked == true)
            {
                this.programacionAvanzada = "Mucho";
            }
            else
            {
                if (rbRegularProgramacionAvanzada.IsChecked == true)
                {
                    this.programacionAvanzada = "Regular";
                }
                if (rbPocoProgramacionAvanzada.IsChecked == true)
                {
                    this.programacionAvanzada = "Poco";
                }
                if (rbNadaProgramacionAvanzada.IsChecked == true)
                {
                    this.programacionAvanzada = "Nada";
                }
                if (rbNoCursoProgramacionAvanzada.IsChecked == true)
                {
                    this.programacionAvanzada = "No la cursé";
                }
            }

            if (rbMuchoProgramacionDeSistemas.IsChecked == true)
            {
                this.programacionDeSistemas = "Mucho";
            }
            else
            {
                if (rbRegularProgramacionDeSistemas.IsChecked == true)
                {
                    this.programacionDeSistemas = "Regular";
                }
                if (rbPocoProgramacionDeSistemas.IsChecked == true)
                {
                    this.programacionDeSistemas = "Poco";
                }
                if (rbNadaProgramacionDeSistemas.IsChecked == true)
                {
                    this.programacionDeSistemas = "Nada";
                }
                if (rbNoCursoProgramacionDeSistemas.IsChecked == true)
                {
                    this.programacionDeSistemas = "No la cursé";
                }
            }

            if (rbMuchoEticaLEgislacionInformatica.IsChecked == true)
            {
                this.eticaLegislacionInformatica = "Mucho";
            }
            else
            {
                if (rbRegularEticaLEgislacionInformatica.IsChecked == true)
                {
                    this.eticaLegislacionInformatica = "Regular";
                }
                if (rbPocoEticaLEgislacionInformatica.IsChecked == true)
                {
                    this.eticaLegislacionInformatica = "Poco";
                }
                if (rbNadaEticaLEgislacionInformatica.IsChecked == true)
                {
                    this.eticaLegislacionInformatica = "Nada";
                }
                if (rbNoCursoEticaLEgislacionInformatica.IsChecked == true)
                {
                    this.eticaLegislacionInformatica = "No la cursé";
                }
            }

            if (rbMuchoFundamentosAdministracion.IsChecked == true)
            {
                this.fundamentosAdministracion = "Mucho";
            }
            else
            {
                if (rbRegularFundamentosAdministracion.IsChecked == true)
                {
                    this.fundamentosAdministracion = "Regular";
                }
                if (rbPocoFundamentosAdministracion.IsChecked == true)
                {
                    this.fundamentosAdministracion = "Poco";
                }
                if (rbNadaFundamentosAdministracion.IsChecked == true)
                {
                    this.fundamentosAdministracion = "Nada";
                }
                if (rbNoCursoFundamentosAdministracion.IsChecked == true)
                {
                    this.fundamentosAdministracion = "No la cursé";
                }
            }

            if (rbMuchoAdministracionProyectos.IsChecked == true)
            {
                this.administracionProyectos = "Mucho";
            }
            else
            {
                if (rbRegularAdministracionProyectos.IsChecked == true)
                {
                    this.administracionProyectos = "Regular";
                }
                if (rbPocoAdministracionProyectos.IsChecked == true)
                {
                    this.administracionProyectos = "Poco";
                }
                if (rbNadaAdministracionProyectos.IsChecked == true)
                {
                    this.administracionProyectos = "Nada";
                }
                if (rbNoCursoAdministracionProyectos.IsChecked == true)
                {
                    this.administracionProyectos = "No la cursé";
                }
            }

            if (rbMuchoCompiladores.IsChecked == true)
            {
                this.compiladores = "Mucho";
            }
            else
            {
                if (rbRegularCompiladores.IsChecked == true)
                {
                    this.compiladores = "Regular";
                }
                if (rbPocoCompiladores.IsChecked == true)
                {
                    this.compiladores = "Poco";
                }
                if (rbNadaCompiladores.IsChecked == true)
                {
                    this.compiladores = "Nada";
                }
                if (rbNoCursoCompiladores.IsChecked == true)
                {
                    this.compiladores = "No la cursé";
                }
            }

            if (rbMuchoAdministracionRecursosInformaticos.IsChecked == true)
            {
                this.administracionRecursosInformaticos = "Mucho";
            }
            else
            {
                if (rbRegularAdministracionRecursosInformaticos.IsChecked == true)
                {
                    this.administracionRecursosInformaticos = "Regular";
                }
                if (rbPocoAdministracionRecursosInformaticos.IsChecked == true)
                {
                    this.administracionRecursosInformaticos = "Poco";
                }
                if (rbNadaAdministracionRecursosInformaticos.IsChecked == true)
                {
                    this.administracionRecursosInformaticos = "Nada";
                }
                if (rbNoCursoAdministracionRecursosInformaticos.IsChecked == true)
                {
                    this.administracionRecursosInformaticos = "No la cursé";
                }
            }

            if (rbMuchoServicioSocial.IsChecked == true)
            {
                this.servicioSocial = "Mucho";
            }
            else
            {
                if (rbRegularServicioSocial.IsChecked == true)
                {
                    this.servicioSocial = "Regular";
                }
                if (rbPocoServicioSocial.IsChecked == true)
                {
                    this.servicioSocial = "Poco";
                }
                if (rbNadaServicioSocial.IsChecked == true)
                {
                    this.servicioSocial = "Nada";
                }
                if (rbNoCursoServicioSocial.IsChecked == true)
                {
                    this.servicioSocial = "No la cursé";
                }
            }

            if (rbMuchoExperienciaRecepcional.IsChecked == true)
            {
                this.experienciaRecepcional = "Mucho";
            }
            else
            {
                if (rbRegularExperienciaRecepcional.IsChecked == true)
                {
                    this.experienciaRecepcional = "Regular";
                }
                if (rbPocoExperienciaRecepcional.IsChecked == true)
                {
                    this.experienciaRecepcional = "Poco";
                }
                if (rbNadaExperienciaRecepcional.IsChecked == true)
                {
                    this.experienciaRecepcional = "Nada";
                }
                if (rbNoCursoExperienciaRecepcional.IsChecked == true)
                {
                    this.experienciaRecepcional = "No la cursé";
                }
            }

            if (rbMuchoDesarrolloAplicacionesEnRed.IsChecked == true)
            {
                this.desarrolloAplicacionesEnRed = "Mucho";
            }
            else
            {
                if (rbRegularDesarrolloAplicacionesEnRed.IsChecked == true)
                {
                    this.desarrolloAplicacionesEnRed = "Regular";
                }
                if (rbPocoDesarrolloAplicacionesEnRed.IsChecked == true)
                {
                    this.desarrolloAplicacionesEnRed = "Poco";
                }
                if (rbNadaDesarrolloAplicacionesEnRed.IsChecked == true)
                {
                    this.desarrolloAplicacionesEnRed = "Nada";
                }
                if (rbNoCursoDesarrolloAplicacionesEnRed.IsChecked == true)
                {
                    this.desarrolloAplicacionesEnRed = "No la cursé";
                }
            }

            if (rbMuchoIngenieriaSoftware3.IsChecked == true)
            {
                this.ingenieriaSoftware3 = "Mucho";
            }
            else
            {
                if (rbRegularIngenieriaSoftware3.IsChecked == true)
                {
                    this.ingenieriaSoftware3 = "Regular";
                }
                if (rbPocoIngenieriaSoftware3.IsChecked == true)
                {
                    this.ingenieriaSoftware3 = "Poco";
                }
                if (rbNadaIngenieriaSoftware3.IsChecked == true)
                {
                    this.ingenieriaSoftware3 = "Nada";
                }
                if (rbNoCursoIngenieriaSoftware3.IsChecked == true)
                {
                    this.ingenieriaSoftware3 = "No la cursé";
                }
            }

            if (rbMuchoGraficacion.IsChecked == true)
            {
                this.graficacion = "Mucho";
            }
            else
            {
                if (rbRegularGraficacion.IsChecked == true)
                {
                    this.graficacion = "Regular";
                }
                if (rbPocoGraficacion.IsChecked == true)
                {
                    this.graficacion = "Poco";
                }
                if (rbNadaGraficacion.IsChecked == true)
                {
                    this.graficacion = "Nada";
                }
                if (rbNoCursoGraficacion.IsChecked == true)
                {
                    this.graficacion = "No la cursé";
                }
            }

            if (rbMuchoSistemasInformacionEmpresarial.IsChecked == true)
            {
                this.sistemasInformacionEmpresarial = "Mucho";
            }
            else
            {
                if (rbRegularSistemasInformacionEmpresarial.IsChecked == true)
                {
                    this.sistemasInformacionEmpresarial = "Regular";
                }
                if (rbPocoSistemasInformacionEmpresarial.IsChecked == true)
                {
                    this.sistemasInformacionEmpresarial = "Poco";
                }
                if (rbNadaSistemasInformacionEmpresarial.IsChecked == true)
                {
                    this.sistemasInformacionEmpresarial = "Nada";
                }
                if (rbNoCursoSistemasInformacionEmpresarial.IsChecked == true)
                {
                    this.sistemasInformacionEmpresarial = "No la cursé";
                }
            }

            if (rbMuchoAdminsitracionYSeguridadDeServiciosDeRed.IsChecked == true)
            {
                this.administracionSeguridadDeServiciosEnRed = "Mucho";
            }
            else
            {
                if (rbRegularAdminsitracionYSeguridadDeServiciosDeRed.IsChecked == true)
                {
                    this.administracionSeguridadDeServiciosEnRed = "Regular";
                }
                if (rbPocoAdminsitracionYSeguridadDeServiciosDeRed.IsChecked == true)
                {
                    this.administracionSeguridadDeServiciosEnRed = "Poco";
                }
                if (rbNadaAdminsitracionYSeguridadDeServiciosDeRed.IsChecked == true)
                {
                    this.administracionSeguridadDeServiciosEnRed = "Nada";
                }
                if (rbNoCursoAdminsitracionYSeguridadDeServiciosDeRed.IsChecked == true)
                {
                    this.administracionSeguridadDeServiciosEnRed = "No la cursé";
                }
            }

            if (rbMuchoTopicosSelectosComputacion1.IsChecked == true)
            {
                this.topicosSelectos1 = "Mucho";
            }
            else
            {
                if (rbMRegularTopicosSelectosComputacion1.IsChecked == true)
                {
                    this.topicosSelectos1 = "Regular";
                }
                if (rbPocoTopicosSelectosComputacion1.IsChecked == true)
                {
                    this.topicosSelectos1 = "Poco";
                }
                if (rbNadaTopicosSelectosComputacion1.IsChecked == true)
                {
                    this.topicosSelectos1 = "Nada";
                }
                if (rbNoCursoTopicosSelectosComputacion1.IsChecked == true)
                {
                    this.topicosSelectos1 = "No la cursé";
                }
            }


            if (rbMuchoTopicosSelectosComputacion2.IsChecked == true)
            {
                this.topicosSelectos2 = "Mucho";
            }
            else
            {
                if (rbRegularTopicosSelectosComputacion2.IsChecked == true)
                {
                    this.topicosSelectos2 = "Regular";
                }
                if (rbPocoTopicosSelectosComputacion2.IsChecked == true)
                {
                    this.topicosSelectos2 = "Poco";
                }
                if (rbNadaTopicosSelectosComputacion2.IsChecked == true)
                {
                    this.topicosSelectos2 = "Nada";
                }
                if (rbNoCursoTopicosSelectosComputacion2.IsChecked == true)
                {
                    this.topicosSelectos2 = "No la cursé";
                }
            }

            if (rbMuchoTopicosSelectosComputacion3.IsChecked == true)
            {
                this.topicosSelectos3 = "Mucho";
            }
            else
            {
                if (rbRegularTopicosSelectosComputacion3.IsChecked == true)
                {
                    this.topicosSelectos3 = "Regular";
                }
                if (rbPocoTopicosSelectosComputacion3.IsChecked == true)
                {
                    this.topicosSelectos3 = "Poco";
                }
                if (rbNadaTopicosSelectosComputacion3.IsChecked == true)
                {
                    this.topicosSelectos3 = "Nada";
                }
                if (rbNoCursoTopicosSelectosComputacion3.IsChecked == true)
                {
                    this.topicosSelectos3 = "No la cursé";
                }
            }

            if (rbMuchoTopicosSelectosComputacion4.IsChecked == true)
            {
                this.topicosSelectos4= "Mucho";
            }
            else
            {
                if (rbRegularTopicosSelectosComputacion4.IsChecked == true)
                {
                    this.topicosSelectos4 = "Regular";
                }
                if (rbPocoTopicosSelectosComputacion4.IsChecked == true)
                {
                    this.topicosSelectos4 = "Poco";
                }
                if (rbNadaTopicosSelectosComputacion4.IsChecked == true)
                {
                    this.topicosSelectos4 = "Nada";
                }
                if (rbNoCursoTopicosSelectosComputacion4.IsChecked == true)
                {
                    this.topicosSelectos4 = "No la cursé";
                }
            }

            if (rbMuchoSistemasInformacionGeografica.IsChecked == true)
            {
                this.sistemasInformacionGeografica = "Mucho";
            }
            else
            {
                if (rbRegularSistemasInformacionGeografica.IsChecked == true)
                {
                    this.sistemasInformacionGeografica = "Regular";
                }
                if (rbPocoSistemasInformacionGeografica.IsChecked == true)
                {
                    this.sistemasInformacionGeografica = "Poco";
                }
                if (rbNadaSistemasInformacionGeografica.IsChecked == true)
                {
                    this.sistemasInformacionGeografica = "Nada";
                }
                if (rbNoCursoSistemasInformacionGeografica.IsChecked == true)
                {
                    this.sistemasInformacionGeografica = "No la cursé";
                }
            }

            if (rbMuchoMultimedia.IsChecked == true)
            {
                this.multimedia = "Mucho";
            }
            else
            {
                if (rbRegularMultimedia.IsChecked == true)
                {
                    this.multimedia = "Regular";
                }
                if (rbPocoMultimedia.IsChecked == true)
                {
                    this.multimedia = "Poco";
                }
                if (rbNadaMultimedia.IsChecked == true)
                {
                    this.multimedia = "Nada";
                }
                if (rbNoCursoMultimedia.IsChecked == true)
                {
                    this.multimedia = "No la cursé";
                }
            }

            if (rbMuchoAuditoriaInformatica.IsChecked == true)
            {
                this.auditoriaInformatica = "Mucho";
            }
            else
            {
                if (rbRegularAuditoriaInformatica.IsChecked == true)
                {
                    this.auditoriaInformatica = "Regular";
                }
                if (rbPocoAuditoriaInformatica.IsChecked == true)
                {
                    this.auditoriaInformatica = "Poco";
                }
                if (rbNadaAuditoriaInformatica.IsChecked == true)
                {
                    this.auditoriaInformatica = "Nada";
                }
                if (rbNoCursoAuditoriaInformatica.IsChecked == true)
                {
                    this.auditoriaInformatica = "No la cursé";
                }
            }

            if (rbMuchoTallerIntegracion4.IsChecked == true)
            {
                this.tallerIntegracion4 = "Mucho";
            }
            else
            {
                if (rbRegularTallerIntegracion4.IsChecked == true)
                {
                    this.tallerIntegracion4 = "Regular";
                }
                if (rbPocoTallerIntegracion4.IsChecked == true)
                {
                    this.tallerIntegracion4 = "Poco";
                }
                if (rbNadaTallerIntegracion4.IsChecked == true)
                {
                    this.tallerIntegracion4 = "Nada";
                }
                if (rbNoCursoTallerIntegracion4.IsChecked == true)
                {
                    this.tallerIntegracion4 = "No la cursé";
                }
            }

            if (rbMuchoRedes3.IsChecked == true)
            {
                this.redes3 = "Mucho";
            }
            else
            {
                if (rbRegularRedes3.IsChecked == true)
                {
                    this.redes3 = "Regular";
                }
                if (rbPocoRedes3.IsChecked == true)
                {
                    this.redes3 = "Poco";
                }
                if (rbNadaRedes3.IsChecked == true)
                {
                    this.redes3 = "Nada";
                }
                if (rbNoCursoRedes3.IsChecked == true)
                {
                    this.redes3 = "No la cursé";
                }
            }

            this.informacionAcademica.IngresoLicenciatura = txtIngreso.Text;
            this.informacionAcademica.EgresoLicenciatrua = txtEgreso.Text;
            this.informacionAcademica.FormacionActual = formacionActual;
            this.informacionAcademica.PlanDeEstudios = planDeEstudios;
            this.informacionAcademica.DesempeñoDocentes = desempeñoDocentes;
            this.informacionAcademica.OrganizacionAdministrativa = organizacionAdministrativa;
            this.informacionAcademica.Instalacion = instalacion;
            this.informacionAcademica.ServiciosApoyo = serviciosApoyo;
            this.informacionAcademica.ActCulturalesYDeportivas = actCulturalesYDeportivas;
            this.informacionAcademica.Ingles1 = ingles1;
            this.informacionAcademica.Ingles2 = ingles2;
            this.informacionAcademica.ComputacionBasica = computacionBasica;
            this.informacionAcademica.LecturaRedaccion = lecturaRedaccion;
            this.informacionAcademica.HabilidadesPensamiento = habilidadesPensamiento;
            this.informacionAcademica.AlgebraLineal = algebraLineal;
            this.informacionAcademica.Probabilidad = probabilidad;
            this.informacionAcademica.MatematicasDiscretas = matematicasDiscretas;
            this.informacionAcademica.AlgoritmosEstucturasDatos1 = algoritmosEstucturasDatos1;
            this.informacionAcademica.ArquitecturaComputadoras1 = arquitecturaComputadoras1;
            this.informacionAcademica.MetodologiaInvestigacion = metodologiaInvestigacion;
            this.informacionAcademica.Logica = logica;
            this.informacionAcademica.Calculo = calculo;
            this.informacionAcademica.Redes1 = redes1;
            this.informacionAcademica.Redes2 = redes2;
            this.informacionAcademica.IngenieriaSoftware1 = ingenieriaSoftware1;
            this.informacionAcademica.IngenieriaSoftware2 = ingenieriaSoftware2;
            this.informacionAcademica.BasesDatos1 = basesDatos1;
            this.informacionAcademica.BasesDatos2 = basesDatos2;
            this.informacionAcademica.TallerIntegracion1 = tallerIntegracion1;
            this.informacionAcademica.SistemasOperativos = sistemasOperativos;
            this.informacionAcademica.ArquitecturaComputadoras2 = arquitecturaComputadoras2;
            this.informacionAcademica.AlgoritmosEstructurasDatos2 = algoritmosEstructurasDatos2;
            this.informacionAcademica.OrganizacionArchivos = organizacionArchivos;
            this.informacionAcademica.InteligenciaArtificial = inteligenciaArtificial;
            this.informacionAcademica.TallerIntegracion2 = tallerIntegracion2;
            this.informacionAcademica.TallerIntegracion3 = tallerIntegracion3;
            this.informacionAcademica.ProgramacionAvanzada = programacionAvanzada;
            this.informacionAcademica.ProgramacionDeSistemas = programacionDeSistemas;
            this.informacionAcademica.EticaLegislacionInformatica = eticaLegislacionInformatica;
            this.informacionAcademica.FundamentosAdministracion = fundamentosAdministracion;
            this.informacionAcademica.AdministracionProyectos = administracionProyectos;
            this.informacionAcademica.Compiladores = compiladores;
            this.informacionAcademica.AdministracionRecursosInformaticos = administracionRecursosInformaticos;
            this.informacionAcademica.ServicioSocial = servicioSocial;
            this.informacionAcademica.ExperienciaRecepcional = experienciaRecepcional;
            this.informacionAcademica.DesarrolloAplicacionesEnRed = desarrolloAplicacionesEnRed;
            this.informacionAcademica.IngenieriaSoftware3 = ingenieriaSoftware3;
            this.informacionAcademica.Graficacion = graficacion;
            this.informacionAcademica.SistemasInformacionEmpresarial = sistemasInformacionEmpresarial;
            this.informacionAcademica.AdministracionSeguridadDeServiciosEnRed = administracionSeguridadDeServiciosEnRed;
            this.informacionAcademica.TopicosSelectos1 = topicosSelectos1;
            this.informacionAcademica.TopicosSelectos2 = topicosSelectos2;
            this.informacionAcademica.TopicosSelectos3 = topicosSelectos3;
            this.informacionAcademica.TopicosSelectos4 = topicosSelectos4;
            this.informacionAcademica.SistemasInformacionGeografica = sistemasInformacionGeografica;
            this.informacionAcademica.Multimedia = multimedia;
            this.informacionAcademica.AuditoriaInformatica = auditoriaInformatica;
            this.informacionAcademica.TallerIntegracion4 = tallerIntegracion4;
            this.informacionAcademica.Redes3 = redes3;

            if (this.informacionAcademica.IngresoLicenciatura == "" || this.informacionAcademica.EgresoLicenciatrua == "" || this.informacionAcademica.FormacionActual == "" || this.informacionAcademica.PlanDeEstudios == "" || this.informacionAcademica.DesempeñoDocentes == "" || this.informacionAcademica.OrganizacionAdministrativa == "" || this.informacionAcademica.Instalacion == "" || this.informacionAcademica.ServiciosApoyo == "" || this.informacionAcademica.ActCulturalesYDeportivas == "" || this.informacionAcademica.Ingles1 == "" || this.informacionAcademica.Ingles2 == "" ||
                this.informacionAcademica.ComputacionBasica == "" || this.informacionAcademica.HabilidadesPensamiento == "" || this.informacionAcademica.AlgebraLineal == "" || this.informacionAcademica.Probabilidad == "" || this.informacionAcademica.MatematicasDiscretas == "" || this.informacionAcademica.AlgoritmosEstucturasDatos1 == "" || this.informacionAcademica.ArquitecturaComputadoras1 == "" || this.informacionAcademica.MetodologiaInvestigacion == "" || this.informacionAcademica.Logica == "" || this.informacionAcademica.Redes1 == "" || this.informacionAcademica.Redes2 == "" ||
                this.informacionAcademica.IngenieriaSoftware1 == "" || this.informacionAcademica.IngenieriaSoftware2 == "" || this.informacionAcademica.BasesDatos1 == "" || this.informacionAcademica.BasesDatos2 == "" || this.informacionAcademica.TallerIntegracion1 == "" || this.informacionAcademica.SistemasOperativos == "" || this.informacionAcademica.ArquitecturaComputadoras2 == "" || this.informacionAcademica.AlgoritmosEstructurasDatos2 == "" || this.informacionAcademica.OrganizacionArchivos == "" || this.informacionAcademica.InteligenciaArtificial == "" || this.informacionAcademica.TallerIntegracion2 == "" ||
                this.informacionAcademica.TallerIntegracion3 == "" || this.informacionAcademica.ProgramacionAvanzada == "" || this.informacionAcademica.ProgramacionDeSistemas == "" || this.informacionAcademica.EticaLegislacionInformatica == "" || this.informacionAcademica.FundamentosAdministracion == "" || this.informacionAcademica.AdministracionProyectos == "" || this.informacionAcademica.Compiladores == "" || this.informacionAcademica.AdministracionRecursosInformaticos == "" || this.informacionAcademica.ServicioSocial == "" || this.informacionAcademica.ExperienciaRecepcional == "" || this.informacionAcademica.DesarrolloAplicacionesEnRed == "" ||
                this.informacionAcademica.IngenieriaSoftware3 == "" || this.informacionAcademica.Graficacion == "" || this.informacionAcademica.SistemasInformacionEmpresarial == "" || this.informacionAcademica.AdministracionSeguridadDeServiciosEnRed == "" || this.informacionAcademica.TopicosSelectos1 == "" || this.informacionAcademica.TopicosSelectos2 == "" || this.informacionAcademica.TopicosSelectos3 == "" || this.informacionAcademica.TopicosSelectos4 == "" || this.informacionAcademica.SistemasInformacionGeografica == "" || this.informacionAcademica.Multimedia == "" || this.informacionAcademica.AuditoriaInformatica == "" ||
                this.informacionAcademica.TallerIntegracion4 == "" || this.informacionAcademica.Redes3 == "")
            {
                System.Windows.MessageBox.Show(this, "LLena todos los campos");
            }
            else
            {
                this.Resultado = InformaciónAcadémicaDAO.guardar(this.informacionAcademica, this.nuevo);
            }
        }
    
        private void btnCancelarInformacionLaboral_Click(object sender, RoutedEventArgs e)
        {
            this.Resultado = false;
            this.Close();
        }


    }
}
