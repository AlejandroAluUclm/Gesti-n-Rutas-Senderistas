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
using System.Xml;

namespace Gestión_Rutas_Senderistas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Principal : Window
    {
        private AddGuia vGuia = new AddGuia();
        private AddRuta vRuta = new AddRuta();
        List<Ruta> listadoRutas;
        List<Excursionista> listadoExcursionistas;
        List<Guia> listadoGuias;
        public Principal()
        {
            InitializeComponent();
            listadoExcursionistas = new List<Excursionista>();
            listadoGuias = new List<Guia>();
            listadoRutas = new List<Ruta>();
            listadoExcursionistas = CargarContenidoXML();
            //listadoGuias = CargarContenidoXML();
            //listadoRutas = CargarContenidoXML();
            lstListaExcursionistas.ItemsSource = listadoExcursionistas;
            lstListaGuias.ItemsSource = listadoGuias;
            lstListaRutas.ItemsSource = listadoRutas;
        }
        private List<Excursionista> CargarContenidoXML()
        {
            List<Excursionista> listado = new List<Excursionista>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Excursionistas.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoExcursionista = new Excursionista("", "", "", "", "");
                nuevoExcursionista.Nombre = node.Attributes["Nombre"].Value;
                nuevoExcursionista.Apellido = node.Attributes["Apellidos"].Value;
                nuevoExcursionista.Edad = node.Attributes["Edad"].Value;
                nuevoExcursionista.Telefono = node.Attributes["Telefono"].Value;
                nuevoExcursionista.Email = node.Attributes["Email"].Value;
                listado.Add(nuevoExcursionista);
            }
            return listado;
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
