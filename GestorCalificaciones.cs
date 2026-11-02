
using System;
using System.Collections.Generic;

namespace SistemaCalificaciones
{
    public class GestorCalificaciones
    {
        private List<Estudiante> estudiantes;

        public GestorCalificaciones()
        {
            estudiantes = new List<Estudiante>();
        }

        public bool RegistrarEstudiante(string matricula, string nombre)
        {
            if (BuscarEstudiante(matricula) != null)
            {
                return false;
            }

            Estudiante estudiante = new Estudiante(matricula, nombre);

            estudiantes.Add(estudiante);

            return true;
        }

        public Estudiante BuscarEstudiante(string matricula)
        {
            foreach (Estudiante estudiante in estudiantes)
            {
                if (estudiante.Matricula == matricula)
                {
                    return estudiante;
                }
            }

            return null;
        }

        public bool AgregarCalificacion(string matricula, double calificacion)
        {
            Estudiante estudiante = BuscarEstudiante(matricula);

            if (estudiante == null)
            {
                return false;
            }

            if (calificacion < 0 || calificacion > 100)
            {
                return false;
            }

            estudiante.AgregarCalificacion(calificacion);

            return true;
        }

        public void MostrarEstudiantes()
        {
            if (estudiantes.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
                return;
            }

            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Matricula: " + estudiante.Matricula);
                Console.WriteLine("Nombre: " + estudiante.Nombre);

                if (estudiante.Calificaciones.Count == 0)
                {
                    Console.WriteLine("Promedio: Sin calificaciones");
                    Console.WriteLine("Estado: Pendiente");
                }
                else
                {
                    double promedio = estudiante.CalcularPromedio();

                    Console.WriteLine("Promedio: " + promedio.ToString("F2"));

                    if (promedio >= 70)
                    {
                        Console.WriteLine("Estado: Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("Estado: Reprobado");
                    }
                }
            }

            Console.WriteLine("--------------------------------");
        }
    }
}
