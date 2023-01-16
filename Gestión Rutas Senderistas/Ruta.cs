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
    public string Dificultad { get; set; }
    public string Material { get; set; }
    public string Comida { get; set; }
    public List<string> PuntosInteres = new List<string>();
    public List<string> Escursionistas = new List<string>();

    public Ruta(string nombre, string origen, string destino, string fecha, string hora, string guía, string tiempoEstimado, string dificultad, string material, string comida, List<string> puntosInteres)
    {
        Nombre = nombre;
        Origen = origen;
        Destino = destino;
        Fecha = fecha;
        Hora = hora;
        Guía = guía;
        TiempoEstimado = tiempoEstimado;
        Dificultad = dificultad;
        Material = material;
        Comida = comida;
        PuntosInteres = puntosInteres;
    }
}