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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SE.View;

namespace SE
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txt_contrasena_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_usuario_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txt_usuario.Text == "USUARIO")
            {
                txt_usuario.Text = "";
            }
            txt_contrasena.Password = "";
        }

        private void txt_contrasena_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txt_contrasena.Password == "")
            {
                txt_contrasena.Password = "";
            }
            txt_usuario.Text = "USUARIO";
        }

        private void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            MenúInicioEgresado menu = new MenúInicioEgresado();
            menu.Show();
        }
    }
}
