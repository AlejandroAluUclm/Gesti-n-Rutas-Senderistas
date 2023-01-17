using System;
using System.Collections.Generic;
using System.Windows.Documents;

public class Excursionista
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Edad { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public Uri Foto { get; set; }
    public List<string> ListadoRutas { get; set; }

    public Excursionista(string nombre, string apellido, string edad, string telefono, string email, Uri foto, List<string> listadoRutas)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Telefono = telefono;
        Email = email;
        Foto = foto;
        ListadoRutas = listadoRutas;
    }
}