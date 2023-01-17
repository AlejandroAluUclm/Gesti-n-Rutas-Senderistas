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
        private Uri imagCross = new Uri("/Recursos/cross.png", UriKind.Relative);
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
            principal.Show();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            lista = Idiomastxt.ToString().Split(',').ToList<string>();
           
            Guia guia = new Guia(Nombretxt.Text.ToString(), Apellidotxt.Text.ToString(), Telefonotxt.Text.ToString(), Emailtxt.Text.ToString(),
                imagCross, lista);
            
            LstGuias.Items.Add(guia);
            this.Close();
        }
    }
}
