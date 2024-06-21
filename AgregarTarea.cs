using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class AgregarTarea
    {
        // Propiedad para almacenar la descripción de la tarea
        public string Tarea { get; set; }

        // Método para agregar una nueva tarea
        public void agregarTarea()
        {
            // Solicita al usuario que ingrese la descripción de la tarea
            Console.WriteLine("Ingrese la tarea:");

            // Lee la descripción de la tarea desde la entrada del usuario y la asigna a la propiedad Tarea
            Tarea = Console.ReadLine();

            // Muestra un mensaje confirmando que la tarea ha sido agregada
            Console.WriteLine($"Tarea '{Tarea}' agregada.");
        }
    }
}

