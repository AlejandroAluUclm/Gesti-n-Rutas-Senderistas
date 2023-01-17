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
        public List<Guia> listadoGuias;
        public Principal()
        {
            InitializeComponent();
            listadoExcursionistas = new List<Excursionista>();
            listadoGuias = new List<Guia>();
            listadoRutas = new List<Ruta>();
            listadoExcursionistas = CargarContenidoXML();
            listadoGuias = CargarContenido();
            listadoRutas = CargarXML();
            lstListaExcursionistas.ItemsSource = listadoExcursionistas;
            lstListaGuias.ItemsSource = listadoGuias;
            lstListaRutas.ItemsSource = listadoRutas;
        }
        private List<Excursionista> CargarContenidoXML()
        {
            List<Excursionista> listado = new List<Excursionista>();
            List<string> rutas = new List<string>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Recursos/InfoExcursionista.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoExcursionista = new Excursionista("", "", "", "", "", null, rutas);
                nuevoExcursionista.Nombre = node.Attributes["Nombre"].Value;
                nuevoExcursionista.Apellido = node.Attributes["Apellido"].Value;
                nuevoExcursionista.Edad = node.Attributes["Edad"].Value;
                nuevoExcursionista.Telefono = node.Attributes["Telefono"].Value;
                nuevoExcursionista.Email = node.Attributes["Email"].Value;
                nuevoExcursionista.Foto = new Uri(node.Attributes["Foto"].Value, UriKind.Relative);
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    rutas.Add(node2.Attributes["Nombre"].Value);
                }
                nuevoExcursionista.ListadoRutas = rutas;
                listado.Add(nuevoExcursionista);
            }
            return listado;
        }
        private List<Guia> CargarContenido()
        {
            List<Guia> listado = new List<Guia>();

            List<string> idiomas = new List<string>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Recursos/InfoGuia.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoGuia = new Guia("", "", "", "", null, idiomas);
                nuevoGuia.Nombre = node.Attributes["Nombre"].Value;
                nuevoGuia.Apellido = node.Attributes["Apellido"].Value;
                nuevoGuia.Telefono = node.Attributes["Telefono"].Value;
                nuevoGuia.Email = node.Attributes["Email"].Value;
                nuevoGuia.Foto = new Uri(node.Attributes["Foto"].Value, UriKind.Relative);
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    idiomas.Add(node2.Attributes["Nombre"].Value);
                }
                nuevoGuia.Idiomas = idiomas;
                listado.Add(nuevoGuia);
            }
            return listado;
        }
        private List<Ruta> CargarXML()
        {
            List<Ruta> listado = new List<Ruta>();

            List<PuntoInteres> puntosInteres = new List<PuntoInteres>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Recursos/InfoRuta.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevaRuta = new Ruta("", "", "", "", "", "", "", "", "", "", puntosInteres);
                nuevaRuta.Nombre = node.Attributes["Nombre"].Value;
                nuevaRuta.Origen = node.Attributes["Origen"].Value;
                nuevaRuta.Destino = node.Attributes["Destino"].Value;
                nuevaRuta.Fecha = node.Attributes["Fecha"].Value;
                nuevaRuta.Hora = node.Attributes["Hora"].Value;
                nuevaRuta.Guía = node.Attributes["Guia"].Value;
                nuevaRuta.TiempoEstimado = node.Attributes["TiempoEstimado"].Value;
                nuevaRuta.Dificultad = node.Attributes["Dificultad"].Value;
                nuevaRuta.Material = node.Attributes["Material"].Value;
                nuevaRuta.Comida = node.Attributes["Comida"].Value;
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    var nuevoPunto = new PuntoInteres("", "", "", null);
                    nuevoPunto.Nombre = node2.Attributes["Nombre"].Value;
                    nuevoPunto.Descripcion = node2.Attributes["Descripcion"].Value;
                    nuevoPunto.Tipologia = node2.Attributes["Tipologia"].Value;
                    nuevoPunto.Foto = new Uri(node2.Attributes["Foto"].Value, UriKind.Relative);
                    puntosInteres.Add(nuevoPunto);
                }
                nuevaRuta.LPuntosInteres = puntosInteres;
                listado.Add(nuevaRuta);
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
