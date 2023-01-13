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

namespace Gestión_Rutas_Senderistas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Principal : Window
    {
        private AddGuia vGuia = new AddGuia();
        private AddRuta vRuta = new AddRuta();
        public Principal()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAddGuia_Click(object sender, RoutedEventArgs e)
        {
            vGuia.Show();
        }

        private void BtnAddRuta_Click(object sender, RoutedEventArgs e)
        {
            vRuta.Show();
        }
    }
}
