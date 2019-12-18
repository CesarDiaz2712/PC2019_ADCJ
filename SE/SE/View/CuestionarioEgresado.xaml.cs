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
        
        private InformacionLaboral cuestionarioLaboral;
        private InformacionAcademica cuestionarioAcademico;
        private InformaciónPersonal cuestionarioPersonal;
        private bool resultado;

       
        public CuestionarioEgresado(InformacionLaboral cuestionarioLaboral, InformaciónPersonal cuestionarioPersonal, InformacionAcademica cuestionarioAcademico)
        {
            this.cuestionarioLaboral = cuestionarioLaboral;
            this.cuestionarioAcademico = cuestionarioAcademico;
            this.cuestionarioPersonal = cuestionarioPersonal;
            InitializeComponent();
        }
        public bool Resultado { get => resultado; set => resultado = value; }
                        if(rb15001a20000.IsChecked == true)
    }
}
