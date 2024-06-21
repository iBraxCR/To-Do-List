# To-Do-List (Lista De Pendientes)

Esta es una aplicación simple de lista de tareas basada en consola escrita en C#. La aplicación permite a los usuarios agregar, eliminar y ver tareas. Está estructurada en varias clases para manejar diferentes funcionalidades como agregar tareas, eliminar tareas y gestionar la lista de tareas.

## Clases y Métodos

### Tareas

Esta clase gestiona la lista de tareas y proporciona métodos para manejar varias opciones en el menú.

#### Propiedades

- `public List<string> ListaTareas { get; set; }`: Una lista para almacenar las tareas.

#### Constructor

- `public Tareas()`: Inicializa la lista de tareas.

#### Métodos

- `public void ManejarOpcion(int op)`: Maneja las opciones del menú principal.
  - `case 1`: Llama a `AgregarTarea()` para agregar una nueva tarea.
  - `case 2`: Llama a `BorrarTarea()` para eliminar una tarea.
  - `case 3`: Llama a `MostrarTareas()` para mostrar todas las tareas pendientes.
  - `case 4`: Sale del sistema.

- `public void AgregarTarea()`: Agrega una nueva tarea a la lista.
  - Solicita al usuario que ingrese una tarea.
  - Agrega la tarea a la lista y confirma la adición.

- `public void BorrarTarea()`: Elimina una tarea existente de la lista.
  - Solicita al usuario que ingrese el número de la tarea a borrar.
  - Valida la entrada y elimina la tarea si la entrada es válida.
  - Confirma la eliminación o muestra un mensaje de error si la entrada no es válida.

- `public void MostrarTareas()`: Muestra todas las tareas pendientes.
  - Itera a través de la lista de tareas y las muestra al usuario con sus números correspondientes.

### Program

Esta clase contiene el método `Main`, que es el punto de entrada de la aplicación.

#### Métodos

- `static void Main(string[] args)`: El método principal que ejecuta la aplicación.
  - Crea una instancia de la clase `Tareas`.
  - Ejecuta un bucle para mostrar el menú y manejar la entrada del usuario hasta que el usuario elija salir.
  - Llama a `ManejarOpcion(int op)` para manejar la elección del usuario.

### AgregarTarea

Esta clase es responsable de agregar tareas.

#### Propiedades

- `public string Tarea { get; set; }`: Una propiedad para almacenar la descripción de la tarea.

#### Métodos

- `public void agregarTarea()`: Agrega una nueva tarea.
  - Solicita al usuario que ingrese una tarea.
  - Asigna la tarea ingresada a la propiedad `Tarea`.
  - Confirma la adición de la tarea.

### BorrarTarea

Esta clase es responsable de eliminar tareas.

#### Propiedades

- `public string Tarea { get; set; }`: Una propiedad para almacenar la descripción de la tarea.

#### Métodos

- `public void borrarTarea()`: Elimina una tarea.
  - Solicita al usuario que ingrese el número de la tarea a borrar.
  - Valida la entrada y confirma la eliminación si es válida.
  - Muestra un mensaje de error si la entrada no es válida.

## Uso

1. Ejecuta la aplicación.
2. Sigue las instrucciones en pantalla para:
   - Agregar una tarea: Presiona `1` y ingresa la descripción de la tarea.
   - Eliminar una tarea: Presiona `2`, visualiza la lista de tareas e ingresa el número de la tarea a eliminar.
   - Ver todas las tareas: Presiona `3` para ver la lista de tareas pendientes.
   - Salir de la aplicación: Presiona `4`.

## Ejemplo

```
Bienvenido al sistema que desea hacer
1. Agregar tareas
2. Borrar Tareas
3. Tareas pendientes
4. Salir

Ingrese la opción: 1
Ingrese la tarea: Comprar leche
Tarea 'Comprar leche' agregada.

Bienvenido al sistema que desea hacer
1. Agregar tareas
2. Borrar Tareas
3. Tareas pendientes
4. Salir

Ingrese la opción: 3
Tareas Pendientes:
1. Comprar leche
```

## Notas

- Asegúrate de manejar entradas no válidas de manera adecuada.
- La aplicación se ejecuta en un bucle hasta que el usuario elija salir presionando `4`.

