using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class BorrarTarea
    {
        // Propiedad para almacenar la descripción de la tarea
        public string Tarea { get; set; }

        // Método para borrar una tarea existente
        public void borrarTarea()
        {
            // Solicita al usuario que ingrese el número de la tarea a borrar
            Console.WriteLine("Ingrese el número de la tarea a borrar:");

            // Lee la entrada del usuario como una cadena
            string input = Console.ReadLine();
            int index;

            // Intenta convertir la entrada a un número entero
            if (int.TryParse(input, out index))
            {
                // Si la conversión es exitosa, muestra un mensaje confirmando la eliminación de la tarea
                Console.WriteLine($"Tarea '{Tarea}' eliminada.");
            }
            else
            {
                // Si la conversión falla, muestra un mensaje de error
                Console.WriteLine("Número de tarea no válido.");
            }
        }
    }
}

