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
    /// Lógica de interacción para MenúInicioEgresado.xaml
    /// </summary>
    public partial class MenúInicioEgresado : Window
    {
        private Egresado usuarioIniciado { get; set; }
        public MenúInicioEgresado(Egresado usuario)
        {
            this.usuarioIniciado = usuario;
            InitializeComponent();
            lblUserName.Content = usuarioIniciado.NombreUsuario;
        }

        private void btn_cuestionario_Click(object sender, RoutedEventArgs e)
        {
            Close();
            FichaPreEgreso ficha = new FichaPreEgreso();
            ficha.Show();
        }
    }
}
