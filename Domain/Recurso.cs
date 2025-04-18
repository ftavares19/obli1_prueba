namespace Domain;

public class Recurso
{
    public string nombre { get; set; }
    public string tipo { get; set; }
    public string descripcion { get; set; }

    public Recurso(string nombre, string tipo, string descripcion)
    {
        this.nombre = nombre;
        this.tipo = tipo;
        this.descripcion = descripcion;
    }
}