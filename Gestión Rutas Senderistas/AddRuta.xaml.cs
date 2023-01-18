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
    /// Lógica de interacción para AddRuta.xaml
    /// </summary>
    public partial class AddRuta : Window
    {
        ListBox LstRutas;
        private Uri imagPI = new Uri("/Recursos/Sendero.jpg", UriKind.Relative);
        private Uri imagPI2 = new Uri("/Recursos/Mirador.jpg", UriKind.Relative);
        private List<PuntoInteres> lista = new List<PuntoInteres>();
        public AddRuta(ListBox lstRutas)
        {
            InitializeComponent();
            LstRutas = lstRutas;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri fotoPI = null;
            if (Fotocombo.SelectedItem.ToString().Equals("Punto interés 1"))
            {
                fotoPI = imagPI;
            }
            else if (Fotocombo.SelectedItem.ToString().Equals("Punto interés 2"))
            {
                fotoPI = imagPI2;
            }

            PuntoInteres pi = new PuntoInteres(NombrePuntoInterestxt.Text.ToString(),
                Descripciontxt.Text.ToString(), Topologiatxt.Text.ToString(), fotoPI);
                lista.Add(pi);

            Ruta ruta = new Ruta(Nombretxt.Text.ToString(), Origentxt.Text.ToString(),
                Destinotxt.Text.ToString(), Fechatxt.Text.ToString(), Horatxt.Text.ToString(),
                Guiatxt.Text.ToString(), Duraciontxt.Text.ToString(), Dificultadtxt.Text.ToString(), 
                Materialtxt.Text.ToString(), Comidatxt.Text.ToString(), lista);

            LstRutas.Items.Add(ruta);
            this.Close();
        }

        private void Fotocombo_Initialized(object sender, EventArgs e)
        {
            Fotocombo.Items.Add("Punto interés 1");
            Fotocombo.Items.Add("Punto interés 2");
        }
    }
}
