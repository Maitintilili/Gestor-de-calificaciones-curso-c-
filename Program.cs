
using System;

namespace SistemaCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorCalificaciones gestor = new GestorCalificaciones();

            int opcion = 0;

            while (opcion != 4)
            {
                Console.WriteLine("\n===== SISTEMA DE CALIFICACIONES =====");
                Console.WriteLine("1. Registrar estudiante");
                Console.WriteLine("2. Agregar calificacion");
                Console.WriteLine("3. Mostrar estudiantes");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe introducir un numero valido.");
                    opcion = 0;
                    continue;
                }

                switch (opcion)
                {
                    case 1:

                        Console.Write("\nIngrese la matricula: ");
                        string matricula = Console.ReadLine();

                        Console.Write("Ingrese el nombre: ");
                        string nombre = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(matricula) ||
                            string.IsNullOrWhiteSpace(nombre))
                        {
                            Console.WriteLine("Los datos no pueden estar vacios.");
                            break;
                        }

                        if (gestor.RegistrarEstudiante(matricula, nombre))
                        {
                            Console.WriteLine("Estudiante registrado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("La matricula ya existe.");
                        }

                        break;

                    case 2:

                        Console.Write("\nIngrese la matricula del estudiante: ");
                        string matriculaBuscar = Console.ReadLine();

                        Console.Write("Ingrese la calificacion (0-100): ");

                        if (!double.TryParse(Console.ReadLine(), out double calificacion))
                        {
                            Console.WriteLine("Debe introducir una calificacion numerica.");
                            break;
                        }

                        if (gestor.AgregarCalificacion(matriculaBuscar, calificacion))
                        {
                            Console.WriteLine("Calificacion agregada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo agregar la calificacion.");
                            Console.WriteLine("Verifique la matricula y el rango de la nota.");
                        }

                        break;

                    case 3:

                        gestor.MostrarEstudiantes();

                        break;

                    case 4:

                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:

                        Console.WriteLine("Opcion incorrecta. Intente nuevamente.");

                        break;
                }
            }
        }
    }
}

