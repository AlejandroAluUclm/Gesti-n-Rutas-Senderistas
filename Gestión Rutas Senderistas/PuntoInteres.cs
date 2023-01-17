using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PuntoInteres
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Tipologia { get; set; }
    public Uri Foto { get; set; }

    public PuntoInteres(string nombre, string descripcion, string tipologia, Uri foto)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Tipologia = tipologia;
        Foto = foto;
    }
}
