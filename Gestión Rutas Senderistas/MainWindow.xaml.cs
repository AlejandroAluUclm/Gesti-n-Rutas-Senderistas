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

namespace Gestión_Rutas_Senderistas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Principal principal = new Principal();
        private string usuario = "admin";
        private string password = "ipo1";
        private BitmapImage imagCheck = new BitmapImage(new Uri("/Recursos/check.png", UriKind.Relative));
        private BitmapImage imagCross = new BitmapImage(new Uri("/Recursos/cross.png", UriKind.Relative));

        public MainWindow()
        {
            InitializeComponent();

            
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (ComprobarEntrada(txtUsuario.Text, usuario, txtUsuario, imgCheckUsuario))
                {
                    passPwd.IsEnabled = true;
                    passPwd.Focus();
                }
            }
        }
        private void passPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (ComprobarEntrada(passPwd.Password, password, passPwd, imgCheckContrasena))
                btnEntrar.Focus();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Gracias por usar nuestra aplicación...", "Despedida");
        }

        private Boolean ComprobarUsuario(string user)
        {
            Boolean valido = false;
            txtUsuario.BorderThickness = new Thickness(2);
            if (user.Equals(usuario))
            {
                // borde y background en verde
                txtUsuario.BorderBrush = Brushes.Green;
                txtUsuario.Background = Brushes.LightGreen;
                // imagen al lado de la entrada de usuario --> check
                imgCheckUsuario.Source = imagCheck;
                valido = true;
            }
            else
            {
                // marcamos borde en rojo
                txtUsuario.BorderBrush = Brushes.Red;
                txtUsuario.Background = Brushes.LightCoral;
                // imagen al lado de la entrada de usuario --> cross
                imgCheckUsuario.Source = imagCross;
                valido = false;
            }
            return valido;
        }
        private Boolean ComprobarPassword(string pass)
        {
            Boolean valido = false;
            passPwd.BorderThickness = new Thickness(2);
            if (pass.Equals(password))
            {
                // borde y background en verde
                passPwd.BorderBrush = Brushes.Green;
                passPwd.Background = Brushes.LightGreen;
                // imagen al lado de la entrada de password --> check
                imgCheckContrasena.Source = imagCheck;
                valido = true;
            }
            else
            {
                // marcamos borde en rojo
                passPwd.BorderBrush = Brushes.Red;
                passPwd.Background = Brushes.LightCoral;
                // imagen al lado de la entrada de password --> cross
                imgCheckContrasena.Source = imagCross;
                valido = false;
            }
            return valido;
        }
        private Boolean ComprobarEntrada(string valorIntroducido, string valorValido, Control componenteEntrada, Image imagenFeedBack)
        {
            Boolean valido = false;
            if (valorIntroducido.Equals(valorValido))
            {
                // borde y background en verde
                componenteEntrada.BorderBrush = Brushes.Green;
                componenteEntrada.Background = Brushes.LightGreen;
                // imagen al lado de la entrada de usuario --> check
                imagenFeedBack.Source = imagCheck;
                valido = true;
            }
            else
            {
                // marcamos borde en rojo
                componenteEntrada.BorderBrush = Brushes.Red;
                componenteEntrada.Background = Brushes.LightCoral;
                // imagen al lado de la entrada de usuario --> cross
                imagenFeedBack.Source = imagCross;
                valido = false;
            }
            return valido;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text.Equals(usuario) && passPwd.Password.Equals(password)){
                principal.Show();
                this.Close();
            }
            
        }

    }
}
