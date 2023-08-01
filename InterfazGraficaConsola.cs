using System;

// Implementación del módulo de interfaz gráfica
public class InterfazGraficaConsola : IInterfazGrafica
{
    public void MostrarMenu()
    {
        Console.WriteLine("**************");
        Console.WriteLine("1. Agregar tarea");
        Console.WriteLine("2. Modificar tarea");
        Console.WriteLine("3. Eliminar tarea");
        Console.WriteLine("4. Ver tareas pendientes");
        Console.WriteLine("5. Ver tareas completadas");
        Console.WriteLine("6. Salir");
        Console.WriteLine("**************");
    }

    public int LeerOpcion()
    {
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());
        return opcion;
    }

    public void MostrarTareas(List<string> tareas)
    {
        foreach (var tarea in tareas)
        {
            Console.WriteLine(tarea);
        }
    }

    public string LeerTarea()
    {
        Console.Write("Ingrese la tarea: ");
        string tarea = Console.ReadLine();
        return tarea;
    }
}
