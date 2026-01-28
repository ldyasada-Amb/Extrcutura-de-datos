using System;
using System.Collections.Generic;

namespace ParqueDiversionesActual
{
    // Clase Persona
    class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    // Clase Atraccion
    class Atraccion
    {
        private Queue<Persona> cola;   // Cola de personas esperando            
        private int capacidad;         // Número de asientos

        public Atraccion(int capacidad)
        {
            this.capacidad = capacidad;
            cola = new Queue<Persona>();
        }

        // Método para agregar persona a la cola
        public void AgregarPersona(Persona persona)
        {
            if (cola.Count < capacidad)
            {
                cola.Enqueue(persona);
                Console.WriteLine($"{persona.Nombre} ha comprado un asiento.");
            }
            else
            {
                Console.WriteLine("Ya no hay asientos disponibles.");
            }
        }

        // Método para subir personas en orden
        public void SubirPersonas()
        {
            Console.WriteLine("\n--- Subiendo a la atracción ---");
            while (cola.Count > 0)
            {
                Persona persona = cola.Dequeue();
                Console.WriteLine($"{persona.Nombre} subió a la atracción.");
            }
        }
    }
}
 