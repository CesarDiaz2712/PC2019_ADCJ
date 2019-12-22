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
using SE.model.dao;
using SE.model.pocos;
using SE.View;

namespace SE
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string usuario;
        private string contrasena;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txt_usuario_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
            txtContrasena.Password = "";
        }

        private void txt_contrasena_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtContrasena.Password == "")
            {
                txtContrasena.Password = "";
            }
            txtUsuario.Text = "USUARIO";
        }

        private void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                usuario = txtUsuario.Text;
                contrasena = txtContrasena.Password;
                Egresado egresado = EgresadoDAO.getLogin(usuario, contrasena);
                if (egresado != null && egresado.IdEgresado > 0)
                {
                    MessageBox.Show(this, "Bienvenido" + egresado.NombreUsuario);
                    MenúInicioEgresado menu = new MenúInicioEgresado(egresado);
                    menu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Sin acceso", "Error");
                    txtUsuario.Text = "";
                    txtContrasena.Password = "";
                    txtUsuario.Focus();
                    Console.WriteLine("this is a test");
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña vacios");
            }
        }

        public bool validarCampos()
        {
            if (txtUsuario.Text == null || txtUsuario.Text.Length == 0)
            {
                return false;
            }
            if (txtContrasena.Password == null || txtContrasena.Password.Length == 0)
            {
                return false;
            }

            if (txtContrasena.Password != null || txtContrasena.Password.Length > 0)
            {
                      
            }
            return true;
        }

    }
}
