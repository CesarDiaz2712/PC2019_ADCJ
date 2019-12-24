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
using SE.model.dao;
using SE.model.pocos;

namespace SE.View
{
    /// <summary>
    /// Lógica de interacción para CuestionarioSatisfaccion.xaml
    /// </summary>
    public partial class CuestionarioEgresado : Window
    {

        private InformacionPersonal cuestionarioPersonal;
        private InformacionLaboral cuestionarioLaboral;
        private InformacionPersonal cuestionarioAcademico;
        private string trabajoLigadoFormacion;
        private string tiempoTranscurridoPrimerEmpleo;
        private string promedioIngresoMensual;
        private string razonNoEncontrartrabajo;
        private string importanciaExperiencia;
        private string tipoOrganismo;
        private string saberesTeoricosRespuesta1;
        private string saberesTeoricosRespuesta2;
        private string saberesTeoricosRespuesta3;
        private string saberesTeoricosRespuesta4;
        private string saberesTeoricosRespuesta5;
        private string saberesTeoricosRespuesta6;
        private string saberesTeoricosRespuesta7;
        private string saberesTeoricosRespuesta8;
        private string saberesTeoricosRespuesta9;
        private string saberesTeoricosRespuesta10;
        private string saberesHeuristicosRespuesta1;
        private string saberesHeuristicosRespuesta2;
        private string saberesHeuristicosRespuesta3;
        private string saberesHeuristicosRespuesta4;
        private string saberesHeuristicosRespuesta5;
        private string saberesHeuristicosRespuesta6;
        private string saberesHeuristicosRespuesta7;
        private string saberesAxiologicosRespuesta1;
        private string saberesAxiologicosRespuesta2;
        private string saberesAxiologicosRespuesta3;
        private string saberesAxiologicosRespuesta4;
        private string saberesAxiologicosRespuesta5;
        private string saberesAxiologicosRespuesta6;
        private string saberesAxiologicosRespuesta7;
        private string saberesAxiologicosRespuesta8;
        private string saberesAxiologicosRespuesta9;
        private string saberesAxiologicosRespuesta10;
        private string saberesAxiologicosRespuesta11;
        private string saberesAxiologicosRespuesta12;
        private string saberesAxiologicosRespuesta13;
        private string saberesAxiologicosRespuesta14;
        private string saberesAxiologicosRespuesta15;
        private string saberesAxiologicosRespuesta16;
        private string saberesAxiologicosRespuesta17;
        private string saberesAxiologicosRespuesta18;
        private string saberesAxiologicosRespuesta19;


        private string formacionActual;
        private string planDeEstudios;
        private string desempeñoDocentes;
        private string organizacionAdmin;
        private string instalacion;
        private string serviciosApoyo;
        private string actDeportivas;
        private bool resultado;
        private Egresado informacionEgresado;
        private FichaPreEgreso ficha;
       
        public CuestionarioEgresado(Egresado informacionEgresado, FichaPreEgreso ficha)
        {
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
                this.saberesTeoricosRespuesta4="Sistemas Inteligentes":
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
                this.saberesHeuristicosRespuesta4="Diseño e implementacion de redes":
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

            this.cuestionarioLaboral.Respuesta = txtCargoDesempeñado.Text;
            this.cuestionarioLaboral.Respuesta = txtTipoContratacion.Text;
            this.cuestionarioLaboral.Respuesta = trabajoLigadoFormacion;
            this.cuestionarioLaboral.Respuesta = tiempoTranscurridoPrimerEmpleo;
            this.cuestionarioLaboral.Respuesta = razonNoEncontrartrabajo;
            this.cuestionarioLaboral.Respuesta = importanciaExperiencia;
            this.cuestionarioLaboral.Respuesta = tipoOrganismo;
            this.cuestionarioLaboral.Respuesta = txtConocimientosTeoricos.Text;
            this.cuestionarioLaboral.Respuesta = txtSaberesHeuristicos.Text;
            this.cuestionarioLaboral.Respuesta = txtExperienciaEducativaCursadas.Text;
            this.cuestionarioLaboral.Respuesta = saberesTeoricosRespuesta1;
            this.cuestionarioLaboral.Respuesta = saberesTeoricosRespuesta2;
            this.cuestionarioLaboral.Respuesta = saberesTeoricosRespuesta3;
            this.cuestionarioLaboral.Respuesta = saberesTeoricosRespuesta4;
            this.cuestionarioLaboral.Respuesta = saberesTeoricosRespuesta5;
            this.cuestionarioLaboral.Respuesta = saberesTeoricosRespuesta6;
            this.cuestionarioLaboral.Respuesta = saberesTeoricosRespuesta7;
            this.cuestionarioLaboral.Respuesta = saberesTeoricosRespuesta8;
            this.cuestionarioLaboral.Respuesta = saberesTeoricosRespuesta9;
            this.cuestionarioLaboral.Respuesta = saberesTeoricosRespuesta10;
            this.cuestionarioLaboral.Respuesta = saberesHeuristicosRespuesta1;
            this.cuestionarioLaboral.Respuesta = saberesHeuristicosRespuesta2;
            this.cuestionarioLaboral.Respuesta = saberesHeuristicosRespuesta3;
            this.cuestionarioLaboral.Respuesta = saberesHeuristicosRespuesta4;
            this.cuestionarioLaboral.Respuesta = saberesHeuristicosRespuesta5;
            this.cuestionarioLaboral.Respuesta = saberesHeuristicosRespuesta6;
            this.cuestionarioLaboral.Respuesta = saberesHeuristicosRespuesta7;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta1;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta2;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta3;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta4;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta5;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta6;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta7;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta8;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta9;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta10;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta11;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta12;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta13;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta14;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta15;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta16;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta17;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta18;
            this.cuestionarioLaboral.Respuesta = saberesAxiologicosRespuesta19;

            this.cuestionarioLaboral.Respuesta = txtFuncionesDesempeñadas.Text;
            this.cuestionarioLaboral.Respuesta = txtProblematicasSolucionadas.Text;
            this.cuestionarioLaboral.Respuesta = promedioIngresoMensual;
            this.resultado = InformaciónLaboralDAO.guardar(this.cuestionarioLaboral,true);

            
        }


        private void btnFinalizarAcademica_Click(object sender, RoutedEventArgs e)
        {
            if (rbLicenciatura.IsChecked == true)
            {
                this.formacionActual = "Licenciatura";
            }
            else
            {
                if(rbEscpecialidad.IsChecked == true)
                {
                    this.formacionActual = "Especialidad";
                }
                else
                {
                    if(rbMaestria.IsChecked == true)
                    {
                        this.formacionActual = "Maestría";
                    }
                    else
                    {
                        if(rbDoctorado.IsChecked == true)
                        {
                            this.formacionActual = "Doctorado";
                        }
                        else
                        {
                            if(rbPostDoctorado.IsChecked == true)
                            {
                                this.formacionActual = "PostDoctorado";
                            }
                       }
                    }
                }
            }

            if(rbEficientePlanEstudiantil.IsChecked == true)
            {
                this.planDeEstudios = "Eficiente";
            }
            else
            {
                if(rbAceptablePlanEstudiantil.IsChecked == true)
                {
                    this.planDeEstudios = "Aceptable";
                }
                else
                {
                    if(rbRegularPlanEstudiantil.IsChecked == true)
                    {
                        this.planDeEstudios = "Regular";
                    }
                    else
                    {
                        if(rbDeficientePlanEstudiantil.IsChecked == true)
                        {
                            this.planDeEstudios = "Deficiente";
                        }
                    }
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
                else
                {
                    if (rbRegularDocentes.IsChecked == true)
                    {
                        this.desempeñoDocentes = "Regular";
                    }
                    else
                    {
                        if (rbDeficienteDocentes.IsChecked == true)
                        {
                            this.desempeñoDocentes = "Deficiente";
                        }
                    }
                }
            }

            if (rbEficienteOrganizacion.IsChecked == true)
            {
                this.organizacionAdmin = "Eficiente";
            }
            else
            {
                if (rbAceptableOrganizacion.IsChecked == true)
                {
                    this.organizacionAdmin = "Aceptable";
                }
                else
                {
                    if (rbRegularOrganizacion.IsChecked == true)
                    {
                        this.organizacionAdmin = "Regular";
                    }
                    else
                    {
                        if (rbDeficienteOrganizacion.IsChecked == true)
                        {
                            this.organizacionAdmin = "Deficiente";
                        }
                    }
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
                else
                {
                    if (rbRegularInstalacion.IsChecked == true)
                    {
                        this.instalacion = "Regular";
                    }
                    else
                    {
                        if (rbDeficienteInstalacion.IsChecked == true)
                        {
                            this.instalacion = "Deficiente";
                        }
                    }
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
                else
                {
                    if (rbRegularServicio.IsChecked == true)
                    {
                        this.serviciosApoyo = "Regular";
                    }
                    else
                    {
                        if (rbDeficienteServicio.IsChecked == true)
                        {
                            this.serviciosApoyo = "Deficiente";
                        }
                    }
                }
            }

            if (rbEficienteActDeportivas.IsChecked == true)
            {
                this.actDeportivas = "Eficiente";
            }
            else
            {
                if (rbAceptableActDeportivas.IsChecked == true)
                {
                    this.actDeportivas = "Aceptable";
                }
                else
                {
                    if (rbRegularActDeportivas.IsChecked == true)
                    {
                        this.actDeportivas = "Regular";
                    }
                    else
                    {
                        if (rbDeficienteActDeportivas.IsChecked == true)
                        {
                            this.actDeportivas = "Deficiente";
                        }
                    }
                }
            }

            /*
            this.cuestionarioAcademico.Respuesta = txtIngreso.Text;
            this.cuestionarioAcademico.Respuesta = txtEgreso.Text;
            this.cuestionarioAcademico.Respuesta = formacionActual;
            this.cuestionarioAcademico.Respuesta = planDeEstudios;
            this.cuestionarioAcademico.Respuesta = organizacionAdmin;
            this.cuestionarioAcademico.Respuesta = desempeñoDocentes;
            this.cuestionarioAcademico.Respuesta = instalacion;
            this.cuestionarioAcademico.Respuesta = serviciosApoyo;
            this.cuestionarioAcademico.Respuesta = actDeportivas;
            this.resultado = InformaciónAcadémicaDAO.guardar(this.cuestionarioAcademico);
            */
        }

    }
}
