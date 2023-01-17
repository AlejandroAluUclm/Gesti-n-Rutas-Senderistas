using System.Collections.Generic;
using System;

public class Guia
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public int NotaMedia { get; set; }
    public List<string> Idiomas { get; set; }
    public Uri Foto { get; set; }
    Random rnd = new Random();
    public Guia(string nombre, string apellido, string telefono, string email, Uri foto, List<string> idiomas)
    {
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Email = email;
        NotaMedia = rnd.Next(0,10);
        Foto = foto;
        Idiomas = idiomas;
    }
}