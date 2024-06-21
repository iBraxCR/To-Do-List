using System.Collections.Generic;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Tareas
    {
        // Lista para almacenar las tareas
        public List<string> ListaTareas { get; set; }

        // Constructor que inicializa la lista de tareas
        public Tareas()
        {
            ListaTareas = new List<string>();
        }

        // Método para manejar las opciones del menú principal
        public void ManejarOpcion(int op)
        {
            switch (op)
            {
                case 1:
                    // Opción para agregar una nueva tarea
                    AgregarTarea();
                    break;
                case 2:
                    // Opción para borrar una tarea existente
                    BorrarTarea();
                    break;
                case 3:
                    // Opción para mostrar todas las tareas pendientes
                    MostrarTareas();
                    break;
                case 4:
                    // Opción para salir del sistema
                    Console.WriteLine("Saliendo del sistema.");
                    break;
                default:
                    // Opción para manejar entradas no válidas
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }
        }

        // Método para agregar una nueva tarea
        public void AgregarTarea()
        {
            Console.WriteLine("Ingrese la tarea:");
            // Lee la nueva tarea desde la entrada del usuario
            string nuevaTarea = Console.ReadLine();
            // Agrega la nueva tarea a la lista
            ListaTareas.Add(nuevaTarea);
            // Confirma al usuario que la tarea fue agregada
            Console.WriteLine($"Tarea '{nuevaTarea}' agregada.");
        }

        // Método para borrar una tarea existente
        public void BorrarTarea()
        {
            Console.WriteLine("Ingrese el número de la tarea a borrar:");
            // Muestra la lista de tareas para que el usuario pueda elegir
            MostrarTareas();
            // Lee el número de la tarea a borrar desde la entrada del usuario
            string input = Console.ReadLine();
            int index;
            // Verifica que la entrada sea un número válido y que esté en el rango correcto
            if (int.TryParse(input, out index) && index > 0 && index <= ListaTareas.Count)
            {
                // Obtiene y elimina la tarea correspondiente
                string tareaEliminada = ListaTareas[index - 1];
                ListaTareas.RemoveAt(index - 1);
                // Confirma al usuario que la tarea fue eliminada
                Console.WriteLine($"Tarea '{tareaEliminada}' eliminada.");
            }
            else
            {
                // Informa al usuario que el número de tarea no es válido
                Console.WriteLine("Número de tarea no válido.");
            }
        }

        // Método para mostrar todas las tareas pendientes
        public void MostrarTareas()
        {
            Console.WriteLine("Tareas Pendientes:");
            // Recorre la lista de tareas y las muestra al usuario
            for (int i = 0; i < ListaTareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ListaTareas[i]}");
            }
        }
    }
}