using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia de la clase Tareas para manejar la lista de tareas
            Tareas tareas = new Tareas();

            // Bucle infinito para mantener el programa en ejecución hasta que el usuario decida salir
            while (true)
            {
                // Muestra el menú principal al usuario
                Console.WriteLine("Bienvenido al sistema que desea hacer");
                Console.WriteLine("1. Agregar tareas\n2. Borrar Tareas\n3. Tareas pendientes\n4. Salir");

                // Lee la entrada del usuario
                string input = Console.ReadLine();
                int op;

                // Intenta convertir la entrada a un número entero
                if (int.TryParse(input, out op))
                {
                    // Llama al método ManejarOpcion con la opción del usuario
                    tareas.ManejarOpcion(op);

                    // Si el usuario elige la opción de salir (4), se rompe el bucle
                    if (op == 4) break;
                }
                else
                {
                    // Si la entrada no es un número válido, muestra un mensaje de error
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                }
            }
        }
    }
}
