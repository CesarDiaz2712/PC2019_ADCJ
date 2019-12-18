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
        
        private InformaciónPersonal cuestionarioPersonal;
        private string trabajoLigadoFormacion;
        private string tiempoTranscurridoPrimerEmpleo;
        private string promedioIngresoMensual;

        private string formacionActual;
        private string planDeEstudios;
        private string desempeñoDocentes;
        private string organizacionAdmin;
        private string instalacion;
        private string serviciosApoyo;
        private string actDeportivas;
        private bool resultado;

       /*
        public CuestionarioEgresado()
        {
            InitializeComponent();
        }
        */
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
                else
                {
                    if (rb12a18Meses.IsChecked == true)
                    {
                        this.tiempoTranscurridoPrimerEmpleo = "12 a 18 meses";
                    }
                    else
                    {
                        if (rb18a24Meses.IsChecked == true)
                        {
                            this.tiempoTranscurridoPrimerEmpleo = "18 a 24 meses";
                        } 
                        else
                        {
                            if(rbMasDe24Meses.IsChecked == true)
                            {
                                this.tiempoTranscurridoPrimerEmpleo = "Mas de 24 meses";
                            }
                            else
                            {
                                if(rbSinTrabajo.IsChecked == true)
                                {
                                    this.tiempoTranscurridoPrimerEmpleo = "No he trabajado";
                                }
                            }
                        }
                    }
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
                else
                {
                    if(rb10001a15000.IsChecked == true)
                    {
                        this.promedioIngresoMensual = "De 10001 a 15000";
                    }
                    else
                    {
                        if(rb15001a20000.IsChecked == true)
                        {
                            this.promedioIngresoMensual = "De 15001 a 20000";
                        }
                        else
                        {
                            if(rb20001oMas.IsChecked == true)
                            {
                                this.promedioIngresoMensual = "20001 o mas";
                            }
                        }
                    }
                }
            }

            this.cuestionarioLaboral.Respuesta = trabajoLigadoFormacion;
            this.cuestionarioLaboral.Respuesta = txtCargoDesempeñado.Text;
            this.cuestionarioLaboral.Respuesta = txtTipoContratacion.Text;
            this.cuestionarioLaboral.Respuesta = tiempoTranscurridoPrimerEmpleo;
            this.cuestionarioLaboral.Respuesta = txtConocimientosTeoricos.Text;
            this.cuestionarioLaboral.Respuesta = txtSaberesHeuristicos.Text;
            this.cuestionarioLaboral.Respuesta = txtEECursadas.Text;
            this.cuestionarioLaboral.Respuesta = txtFuncionesDesempeñadas.Text;
            this.cuestionarioLaboral.Respuesta = txtProblematicasSolucionadas.Text;
            this.cuestionarioLaboral.Respuesta = promedioIngresoMensual;
            this.resultado = InformaciónLaboralDAO.guardar(this.cuestionarioLaboral);


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
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
