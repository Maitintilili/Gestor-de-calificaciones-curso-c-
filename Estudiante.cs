
using System;
using System.Collections.Generic;

namespace SistemaCalificaciones
{
    public class Estudiante
    {
        public string Matricula { get; private set; }
        public string Nombre { get; private set; }

        public List<double> Calificaciones { get; private set; }

        public Estudiante(string matricula, string nombre)
        {
            Matricula = matricula;
            Nombre = nombre;
            Calificaciones = new List<double>();
        }

        public void AgregarCalificacion(double calificacion)
        {
            Calificaciones.Add(calificacion);
        }

        public double CalcularPromedio()
        {
            if (Calificaciones.Count == 0)
            {
                return 0;
            }

            double suma = 0;

            foreach (double nota in Calificaciones)
            {
                suma += nota;
            }

            return suma / Calificaciones.Count;
        }
    }
}
