using System.Collections.Generic;

// Implementación del gestor de tareas
public class GestorTareas : IGestorTareas
{
    private List<string> tareasPendientes;
    private List<string> tareasCompletadas;

    public GestorTareas()
    {
        tareasPendientes = new List<string>();
        tareasCompletadas = new List<string>();
    }

    public void AgregarTarea(string tarea)
    {
        tareasPendientes.Add(tarea);
    }

    public void ModificarTarea(int indice, string nuevaTarea)
    {
        if (indice >= 0 && indice < tareasPendientes.Count)
        {
            tareasPendientes[indice] = nuevaTarea;
        }
    }

    public void EliminarTarea(int indice)
    {
        if (indice >= 0 && indice < tareasPendientes.Count)
        {
            tareasPendientes.RemoveAt(indice);
        }
    }

    public List<string> ObtenerTareasPendientes()
    {
        return new List<string>(tareasPendientes);
    }

    public List<string> ObtenerTareasCompletadas()
    {
        return new List<string>(tareasCompletadas);
    }

    public void MarcarTareaComoCompletada(int indice)
    {
        if (indice >= 0 && indice < tareasPendientes.Count)
        {
            string tareaCompletada = tareasPendientes[indice];
            tareasPendientes.RemoveAt(indice);
            tareasCompletadas.Add(tareaCompletada);
        }
    }
}
