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

    public partial class MenúInicioEgresado : Window
    {
        private Egresado usuarioIniciado { get; set; }
        private Egresado egresado;
        private FichaPreEgreso informacionPersonal;
        public MenúInicioEgresado(Egresado usuario)
        {
            this.usuarioIniciado = usuario;
            InitializeComponent();
            lblUserName.Content=usuario.NombreUsuario;
        }

        //Carga la Informacion del Egresado
        private void cargarInformacionEgresado()
        {
            egresado = EgresadoDAO.consultaInformacionEgresado(usuarioIniciado.IdEgresado);
        }

        private void cargarInformacionPersonal()
        {
            egresado = EgresadoDAO.consultaInformacionEgresado(usuarioIniciado.IdEgresado);
            informacionPersonal = FichaPreEgresoDAO.obtenerFichaPreEgreso(usuarioIniciado.IdEgresado);
        }

        private void btn_FichaPreEgreso_Click(object sender, RoutedEventArgs e)
        {
            FichaPreEgreso ficha = new FichaPreEgreso();
            ficha.IdEgresado = this.usuarioIniciado.IdEgresado;
            this.cargarInformacionEgresado();
            VentanaFichaPreEgreso ventanaFicha = new VentanaFichaPreEgreso(egresado, ficha);
            ventanaFicha.Show();
        }

        private void btnCuestionario_Click(object sender, RoutedEventArgs e)
        {
            this.cargarInformacionPersonal();
            CuestionarioEgresado cuestionario = new CuestionarioEgresado(egresado,informacionPersonal);
            cuestionario.Show();
        }
    }
}
