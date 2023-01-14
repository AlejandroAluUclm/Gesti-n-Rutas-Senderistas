using System;
using System.Collections.Generic;

public class Guia
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public int NotaMedia { get; set; }
    public List<string> Idiomas = new List<string>();
    Random rnd = new Random();
    public Guia(string nombre, string apellido, string telefono, string email, List<string> idiomas)
    {
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Email = email;
        NotaMedia = rnd.Next(0,10);
        Idiomas = idiomas;
    }
}