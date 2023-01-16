using System.Collections.Generic;

public class Guia
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string NotaMedia { get; set; }
    public List<string> Idiomas = new List<string>();

    public Guia(string nombre, string apellido, string telefono, string email, string notaMedia, List<string> idiomas)
    {
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Email = email;
        NotaMedia = notaMedia;
        Idiomas = idiomas;
    }
}