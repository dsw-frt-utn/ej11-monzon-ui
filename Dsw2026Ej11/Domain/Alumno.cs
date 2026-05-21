namespace Dsw2026Ej11.Domain;

public class Alumno
{
    public int Legajo { get; }
    public string Nombre { get; }
    public double Promedio { get; }

    public Alumno(int id, string nombre, double promedio)
    {
        Legajo = id;
        Nombre = nombre;
        Promedio = promedio;
    }

    public override string ToString()
    {
        return $"{Legajo} - {Nombre} - Promedio: {Promedio}";
    }

    
}
