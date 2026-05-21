using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();
        casoList.AgregarAlumno(new Alumno(57890, "Jose Maria", 7.5));
        casoList.AgregarAlumno(new Alumno(67859, "Maria Jose", 7));
        casoList.AgregarAlumno(new Alumno(45789, "Martin Velasquez", 6));
        List<Alumno> lista = casoList.GetAlumnos();

        foreach (Alumno a in lista)
        {
            Console.WriteLine($"\n {a.ToString()}");
        }
        Console.WriteLine($"\n{casoList.AlumnoPorNombre("Jose Maria")}");
        
        Alumno a1= casoList.AlumnoPorNombre("Alejandro Magno");
        if (a1 == null)
        {
            Console.WriteLine("\nNo existe");
        }
        else
        {
            Console.WriteLine($"\n{a1}");
        }

        casoList.EliminarAlumno(casoList.AlumnoPorNombre("Jose Maria"));
        foreach (Alumno a in lista)
        {
            Console.WriteLine($"\n {a.ToString()}");
        }

        casoList.EliminarAlumnoEnPosicion(0);
        foreach (Alumno a in lista)
        {
            Console.WriteLine($"\n {a.ToString()}");
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoD = new CasoDictionary();
        casoD.AgregarAlumno(new Alumno(57890, "Jose Maria", 7.5));
        casoD.AgregarAlumno(new Alumno(67859, "Maria Jose", 7));
        casoD.AgregarAlumno(new Alumno(45789, "Martin Velasquez", 6));

        Dictionary<int,Alumno> diccionario = casoD.ObtenerAlumnos();
        foreach (Alumno a in diccionario.Values)
        {
            Console.WriteLine($"\n {a.ToString()}");
        }
        Console.WriteLine("\n");
        Console.WriteLine(casoD.BuscarAlumnoPorClave(67859));
        Alumno alumno1 = casoD.BuscarAlumnoPorClave(23456);
        if (alumno1 != null)
        {
            Console.WriteLine(alumno1);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        casoD.EliminarAlumnoPorClave(45789);
        foreach (Alumno a in diccionario.Values)
        {
            Console.WriteLine($"\n {a.ToString()}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        Console.WriteLine(CasoLinq.GetPrimero());
        Console.WriteLine(CasoLinq.GetUltimo());
        Console.WriteLine("\n");
        Console.WriteLine(CasoLinq.GetTotalPrecios());
        Console.WriteLine("\n");
        Console.WriteLine(CasoLinq.GetPromedioPrecios());
        Console.WriteLine("\n");
        List<Libro> lista = CasoLinq.GetListById();
        foreach (Libro a in lista)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine("\n");
        List<string> listaString = CasoLinq.GetLibros();
        foreach (string s in listaString)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("\n");
        Console.WriteLine(CasoLinq.GetMayorPrecio());
        Console.WriteLine(CasoLinq.GetMenorPrecio());
        Console.WriteLine("\n");
        List<Libro> listaMayorPromedio = CasoLinq.GetMayorPromedio();
        foreach (Libro a in listaMayorPromedio)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine("\n");
        List<Libro> listaOrdenada = CasoLinq.ObtenerLibrosOrdenados();
        foreach (Libro a in listaOrdenada)
        {
            Console.WriteLine(a);
        }

    }
}
