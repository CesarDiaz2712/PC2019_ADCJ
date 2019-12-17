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
    /// Lógica de interacción para VentanaFichaPreEgreso.xaml
    /// </summary>
    public partial class VentanaFichaPreEgreso : Window
    {
        private FichaPreEgreso ficha;
        private Boolean resultado;
        public VentanaFichaPreEgreso(FichaPreEgreso ficha)
        {
            this.ficha = ficha;
            InitializeComponent();
        }

        public bool Resultado { get => resultado; set => resultado = value; }
        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            string sexo = "";
            string nacionalidad = "";
            if (rbHombre.IsChecked==true)
            {
                sexo = "Hombre";
            }
            else
            {
                sexo = "Mujer";
            }

            if (rbMexicana.IsChecked==true)
            {
                nacionalidad = "Mexicana";
            }
            else
            {
                nacionalidad = txtNacionalidad.Text;
            }

            this.ficha.Sexo = sexo;
            this.ficha.Nacionalidad = nacionalidad;
            this.ficha.Telefono = txtTelefono.Text;
            this.ficha.Calle = txtCalle.Text;
            this.ficha.Email = txtEmail.Text;
            this.ficha.NumeroCasa = txtNumeroCasa.Text;
            this.ficha.Colonia = txtColonia.Text;
            this.ficha.Ciudad = txtCiudad.Text;
            this.ficha.Estado = txtEstado.Text;
            this.ficha.CodigoPostal = txtCP.Text;
            this.resultado = FichaPreEgresoDAO.guardar(this.ficha);
            this.Close();
        }
     }
    
 }

