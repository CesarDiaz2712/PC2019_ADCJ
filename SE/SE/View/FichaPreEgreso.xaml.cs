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
    /// Lógica de interacción para FichaPreEgreso.xaml
    /// </summary>
    public partial class FichaPreEgreso : Window
    {
        private bool nuevo;
        private bool resultado;
        private FichaPreEgreso ficha;
        public FichaPreEgreso(bool nuevo, FichaPreEgreso ficha)
        {
            this.ficha = ficha;
            this.nuevo = nuevo;

            InitializeComponent();
            if (!nuevo)
            {
            }

        }
    }
}
