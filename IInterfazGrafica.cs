using System.Collections.Generic;

// Interfaz para el módulo de interfaz gráfica
public interface IInterfazGrafica
{
    void MostrarMenu();
    int LeerOpcion();
    void MostrarTareas(List<string> tareas);
    string LeerTarea();
}
