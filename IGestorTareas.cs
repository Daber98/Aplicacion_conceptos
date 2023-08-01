using System.Collections.Generic;

// Definición de la interfaz para el gestor de tareas
public interface IGestorTareas
{
    void AgregarTarea(string tarea);
    void ModificarTarea(int indice, string nuevaTarea);
    void EliminarTarea(int indice);
    List<string> ObtenerTareasPendientes();
    List<string> ObtenerTareasCompletadas();
    void MarcarTareaComoCompletada(int indice);
}
