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
    /// Lógica de interacción para AddGuia.xaml
    /// </summary>
    public partial class AddGuia : Window
    {
        private Uri defecto = new Uri("/Recursos/User_Icon.png", UriKind.Relative);
        private Uri imagGuia = new Uri("/Recursos/Guia.png", UriKind.Relative);
        private List<string> lista = new List<string>();
        Principal principal = new Principal();
        ListBox LstGuias;
        public AddGuia(ListBox lstGuias)
        {
            InitializeComponent();
            LstGuias = lstGuias;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Uri fotoGuia = null;
            if (Fotocombo.SelectedItem.ToString().Equals("Imagen guía 1"))
            {
                fotoGuia = imagGuia;
            }
            else if (Fotocombo.SelectedItem.ToString().Equals("Imagen guía 1"))
            {
                fotoGuia = defecto;
            }
            lista.Add(Idiomastxt.Text.ToString());
            lista.Add(Idiomastxt2.Text.ToString());
            Guia guia = new Guia(Nombretxt.Text.ToString(), Apellidotxt.Text.ToString(), Telefonotxt.Text.ToString(), Emailtxt.Text.ToString(),
                fotoGuia, lista);
            
            LstGuias.Items.Add(guia);
            this.Close();
        }

        private void Fotocombo_Initialized(object sender, EventArgs e)
        {
            Fotocombo.Items.Add("Imagen guía 1");
            Fotocombo.Items.Add("Imagen guía 2");
        }
    }
}
