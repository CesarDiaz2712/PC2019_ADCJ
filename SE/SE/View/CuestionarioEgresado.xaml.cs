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

namespace SE.View
{
    /// <summary>
    /// Lógica de interacción para CuestionarioSatisfaccion.xaml
    /// </summary>
    public partial class CuestionarioEgresado : Window
    {
        private  ficha;
        private Boolean resultado;
        public VentanaFichaPreEgreso(FichaPreEgreso ficha)
        {
            this.ficha = ficha;
            InitializeComponent();
        }
    }
}
