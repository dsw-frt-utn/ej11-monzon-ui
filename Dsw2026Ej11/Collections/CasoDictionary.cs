namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnos;

    public CasoDictionary()
    {
        alumnos = new Dictionary<int, Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno.Legajo, alumno);
    }

    public Alumno? BuscarAlumnoPorClave(int Legajo)
    {
        return alumnos.GetValueOrDefault(Legajo);
    }

    public Dictionary<int, Alumno> ObtenerAlumnos()
    {
        return alumnos;
    }

    public bool EliminarAlumnoPorClave(int Legajo)
    {
        return alumnos.Remove(Legajo);
    }
}
