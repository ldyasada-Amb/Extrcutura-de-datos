using System;
using System.Collections.Generic;

namespace CursoPOO
{
    // Ejercicio 1 
    class Curso
    {
        // Lista de asignaturas del curso
        private List<string> asignaturas;

        // Constructor para inicializar la lista de asignaturas
        public Curso()
        {
            asignaturas = new List<string>()
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };
        }

        // Método para mostrar asignaturas  
        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine("- " + asignatura);
            }
        }
    }
}

// Ejercicio 2


namespace CursoPOO
{
    // Clase CursoConMensaje (ejercicio 2)
    class CursoConMensaje
    {
        // Lista de asignaturas
        private List<string> asignaturas;

        // Constructor
        public CursoConMensaje()
        {
            asignaturas = new List<string>()
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };
        }

        // Método para mostrar mensaje "Yo estudio <asignatura>"
        public void MostrarAsignaturasConMensaje()
        {
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine("Yo estudio " + asignatura);
            }
        }
    }
}

// Ejercicio 3
namespace CursoPOO
{
    // Clase Curso
    class CursoPedidaNotas
    {
        private List<string> asignaturas;
        private Dictionary<string, double> notas;

        // Constructor
        public CursoPedidaNotas()
        {
            asignaturas = new List<string>()
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };

            notas = new Dictionary<string, double>();
        }

        // Método para pedir notas al usuario
        public void PedirNotas()
        {
            foreach (string asignatura in asignaturas)
            {
                Console.Write($"Introduce la nota de {asignatura}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                notas[asignatura] = nota;
            }
        }

        // Método para mostrar resultados
        public void MostrarNotas()
        {
            Console.WriteLine("\nResultados:");
            foreach (var par in notas)
            {
                Console.WriteLine($"En {par.Key} has sacado {par.Value}");
            }
        }
    }
}
