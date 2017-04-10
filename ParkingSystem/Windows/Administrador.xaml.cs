using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ParkingSystem
{
    /// <summary>
    /// Interaction logic for Administrador.xaml
    /// </summary>
    public partial class Administrador : Window
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void BtnClose(object sender, RoutedEventArgs e){ this.Close(); }

        private void BtnMin(object sender, RoutedEventArgs e){ this.WindowState = WindowState.Minimized; }

        private void PageUsuarios(object sender, RoutedEventArgs e){ MainFrame.Content = new PageUsuarios(); }

        private void PageResidentes(object sender, RoutedEventArgs e) { MainFrame.Content = new PageResidentes(); }

        private void PageVehiculos(object sender, RoutedEventArgs e) { MainFrame.Content = new PageVehiculos(); }
    }
}
