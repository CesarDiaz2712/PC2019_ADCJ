﻿using System;
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
    /// Lógica de interacción para VentanaFichaPreEgreso.xaml
    /// </summary>
    public partial class VentanaFichaPreEgreso : Window
    {
        private FichaPreEgreso ficha;
        public VentanaFichaPreEgreso(FichaPreEgreso ficha)
        {
            this.ficha = ficha;
            InitializeComponent();
        }

        private void Btn_Guardar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
