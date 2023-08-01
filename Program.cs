using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        IGestorTareas gestorTareas = new GestorTareas();
        IInterfazGrafica interfaz = new InterfazGraficaConsola();

        bool salir = false;

        while (!salir)
        {
            interfaz.MostrarMenu();
            int opcion = interfaz.LeerOpcion();

            switch (opcion)
            {
                case 1:
                    string tareaNueva = interfaz.LeerTarea();
                    gestorTareas.AgregarTarea(tareaNueva);
                    break;
                case 2:
                    ListarTareasPendientes(gestorTareas, interfaz);
                    int indiceModificar = LeerIndiceTarea(interfaz, "Ingrese el índice de la tarea a modificar: ");
                    string nuevaTarea = interfaz.LeerTarea();
                    gestorTareas.ModificarTarea(indiceModificar, nuevaTarea);
                    break;
                case 3:
                    ListarTareasPendientes(gestorTareas, interfaz);
                    int indiceEliminar = LeerIndiceTarea(interfaz, "Ingrese el índice de la tarea a eliminar: ");
                    gestorTareas.EliminarTarea(indiceEliminar);
                    break;
                case 4:
                    ListarTareasPendientes(gestorTareas, interfaz);
                    break;
                case 5:
                    ListarTareasCompletadas(gestorTareas, interfaz);
                    break;
                case 6:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ListarTareasPendientes(IGestorTareas gestorTareas, IInterfazGrafica interfaz)
    {
        List<string> tareasPendientes = gestorTareas.ObtenerTareasPendientes();
        Console.WriteLine("Tareas Pendientes:");
        interfaz.MostrarTareas(tareasPendientes);
    }

    static void ListarTareasCompletadas(IGestorTareas gestorTareas, IInterfazGrafica interfaz)
    {
        List<string> tareasCompletadas = gestorTareas.ObtenerTareasCompletadas();
        Console.WriteLine("Tareas Completadas:");
        interfaz.MostrarTareas(tareasCompletadas);
    }

    static int LeerIndiceTarea(IInterfazGrafica interfaz, string mensaje)
    {
        Console.Write(mensaje);
        int indice = int.Parse(Console.ReadLine());
        return indice;
    }
}
