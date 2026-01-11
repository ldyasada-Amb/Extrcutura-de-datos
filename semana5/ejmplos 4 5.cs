using System;
using System.Collections.Generic;

namespace LoteriEjemploPOO
{
    // Clase Loteria
    class LoteriaSorteo
    {
        private List<int> numeros;

        // Constructor
        public LoteriaSorteo()
        {
            numeros = new List<int>();
        }

        // Método para pedir números al usuario
        public void PedirNumeros(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Introduce el número ganador de la loteria {i + 1}: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                numeros.Add(numero);
            }
        }

        // Método para mostrar números ordenados
        public void MostrarNumeros()
        {
            numeros.Sort(); // Ordena de menor a mayor
            Console.WriteLine("\nNúmeros ganadores en orden:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}

// ejercicio 5

namespace NumerosPOOCollecion
{
    // Clase que representa una colección de números
    class NumerosAlmacenados
    {
        private List<int> lista;

        // Constructor: inicializa la lista con números del 1 al 10
        public NumerosAlmacenados()
        {
            lista = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                lista.Add(i);
            }
        }

        // Método para mostrar los números en orden inverso separados por comas
        public void MostrarInverso()
        {
            lista.Reverse(); // invierte la lista
            Console.WriteLine(string.Join(", ", lista));
        }
    }

}
