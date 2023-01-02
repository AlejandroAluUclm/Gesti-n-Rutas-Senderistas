using System;
using System.Collections.Generic;

public class Ruta
{
    public string Nombre { get; set; }
    public string Origen { get; set; }
    public string Destino { get; set; }
    public string Fecha { get; set; }
    public string Hora { get; set; }
    public string Guía { get; set; }
    public string TiempoEstimado { get; set; }
    public int dificultad { get; set; }
    public Boolean Material { get; set; }
    public Boolean Comida { get; set; }
    public List<string> PuntosInteres = new List<string>();
    public List<string> Escursionistas = new List<string>();

    public Ruta(string nombre, string origen, string destino, string fecha, string hora, string guía, string tiempoEstimado, int dificultad, bool material, bool comida, List<string> puntosInteres)
    {
        Nombre = nombre;
        Origen = origen;
        Destino = destino;
        Fecha = fecha;
        Hora = hora;
        Guía = guía;
        TiempoEstimado = tiempoEstimado;
        this.dificultad = dificultad;
        Material = material;
        Comida = comida;
        PuntosInteres = puntosInteres;
    }
}