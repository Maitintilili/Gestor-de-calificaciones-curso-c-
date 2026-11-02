
# Sistema de Calificaciones

## Descripción

Aplicación de consola desarrollada en C# con .NET 10 para gestionar estudiantes y sus calificaciones.

El sistema permite registrar estudiantes, agregar calificaciones, calcular promedios y consultar si cada estudiante está aprobado o reprobado.

## Requisitos

- .NET 10 SDK
- Visual Studio 2022 o Visual Studio Code

## Estructura del proyecto

```text
SistemaCalificaciones/
│
├── Program.cs
├── Estudiante.cs
├── GestorCalificaciones.cs
└── README.md
```

## Explicación de las clases

### 1. Estudiante.cs

Representa a cada estudiante del sistema.

Contiene las siguientes propiedades:

- Matricula: identificador único del estudiante.
- Nombre: nombre del estudiante.
- Calificaciones: lista de notas obtenidas.

Métodos principales:

- AgregarCalificacion(): agrega una nota al estudiante.
- CalcularPromedio(): calcula el promedio de sus calificaciones.

### 2. GestorCalificaciones.cs

Se encarga de administrar los estudiantes.

Métodos principales:

- RegistrarEstudiante(): registra un estudiante y verifica que su matrícula no exista.
- BuscarEstudiante(): busca un estudiante mediante su matrícula.
- AgregarCalificacion(): valida y agrega una calificación.
- MostrarEstudiantes(): muestra los estudiantes, sus promedios y estados académicos.

### 3. Program.cs

Contiene el método Main y el menú principal de la aplicación.

Permite realizar las siguientes operaciones:

1. Registrar estudiante.
2. Agregar calificación.
3. Mostrar estudiantes.
4. Salir del sistema.

Utiliza un ciclo while para mantener el menú activo y una estructura switch para ejecutar las opciones seleccionadas.

## Instrucciones para ejecutar

### Opción 1: Visual Studio

1. Abrir el proyecto en Visual Studio.
2. Verificar que esté seleccionado .NET 10.
3. Ejecutar utilizando Ctrl + F5.

### Opción 2: Terminal

1. Abrir una terminal en la carpeta del proyecto.
2. Ejecutar el siguiente comando para compilar:

```bash
dotnet build
```

3. Ejecutar la aplicación:

```bash
dotnet run
```

## Reglas del sistema

- Cada estudiante debe tener una matrícula única.
- Las calificaciones deben estar entre 0 y 100.
- El promedio se calcula utilizando todas las calificaciones registradas.
- Un estudiante está aprobado cuando su promedio es mayor o igual a 70.
- Un estudiante está reprobado cuando su promedio es menor que 70.
- Si un estudiante no tiene calificaciones, se muestra el estado Pendiente.
- El sistema valida los datos para evitar errores durante la ejecución.

## Tecnologías utilizadas

- Lenguaje: C#
- Framework: .NET 10
- Tipo de aplicación: Consola
- Paradigma: Programación Orientada a Objetos (POO)

## Almacenamiento

Los datos se mantienen en memoria mediante colecciones List<T>.

No se utiliza base de datos ni almacenamiento permanente.
