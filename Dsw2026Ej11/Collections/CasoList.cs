namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> alumnos { get; set; }

    public CasoList()
    {
        alumnos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public List<Alumno> GetAlumnos()
    {
        return alumnos;
    }
    public Alumno? AlumnoPorNombre(string nombre)
    {
        return alumnos.Find((Alumno alumno) => 
        {

            return alumno.Nombre == nombre;

        });
    }

    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }

    public void EliminarAlumnoEnPosicion(int index)
    {
        if (index >= 0 && index < alumnos.Count)
        {
            alumnos.RemoveAt(index);
        }
    }


}
