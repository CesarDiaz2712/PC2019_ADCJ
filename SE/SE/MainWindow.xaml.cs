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
        String usuario;
        String contrasena;
        public MainWindow()
        {
            InitializeComponent();
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
            if (validarCampos())
            {
                usuario = txt_usuario.Text;
                contrasena = txt_contrasena.Password;
                Usuario u = UsuarioDAO.getLogin(usuario, contrasena);
                if (u != null || u.IdUsuario > 0)
                {
                    MessageBox.Show(this, "Bienvenido" + u.NombreUsuario);
                    MenúInicioEgresado menu = new MenúInicioEgresado();
                    menu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Sin acceso", "Error");
                    txt_usuario.Text = "";
                    txt_contrasena.Password = "";
                    txt_usuario.Focus();
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
            if (txt_usuario.Text == null || txt_usuario.Text.Length == 0)
            {
                return false;
            }
            if (txt_contrasena.Password == null || txt_contrasena.Password.Length == 0)
            {
                return false;
            }

            return true;
        }

    }
}
