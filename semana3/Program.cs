using System;

namespace RegistroAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datos del estudiante
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la carrera: ");
            string carrera = Console.ReadLine();

            Console.Write("Ingrese el nivel: ");
            string nivel = Console.ReadLine();

            Console.Write("Ingrese el correo: ");
            string correo = Console.ReadLine();

            // Array para almacenar 3 teléfonos del estudiante
            string[] telefonos = new string[3];
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.Write($"Ingrese el teléfono {i + 1}: ");
                telefonos[i] = Console.ReadLine();
            }

            // Mostrar datos en la consola
            Console.WriteLine("\n--- Datos del Estudiante ---");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Carrera: {carrera}");
            Console.WriteLine($"Nivel: {nivel}");
            Console.WriteLine($"Correo: {correo}");
            Console.WriteLine("Teléfonos:");
            foreach (string tel in telefonos)
            {
                Console.WriteLine($"- {tel}");
            }
        }
    }
}