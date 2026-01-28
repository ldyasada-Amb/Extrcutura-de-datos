using System;
using System.Collections.Generic;

namespace ParqueDiversionesActual
{
    class Program
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion(30);

            // Simulación: agregar 30 personas
            for (int i = 1; i <= 30; i++)
            {
                atraccion.AgregarPersona(new Persona("Persona " + i));
            }

            // Intentar agregar una persona extra
            atraccion.AgregarPersona(new Persona("Persona Extra"));

            // Subir personas en orden
            atraccion.SubirPersonas();

            Console.ReadKey();
        }
    }
}