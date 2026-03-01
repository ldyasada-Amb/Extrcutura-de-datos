using System;
using System.Collections.Generic;

class Program // Traductor de español a inglés
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"camino", "way"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"parte", "part"},
        {"niño", "child"},
        {"ojo", "eye"},
        {"mujer", "woman"},
        {"lugar", "place"},
        {"trabajo", "work"},
        {"semana", "week"},
        {"caso", "case"},
        {"punto", "point"},
        {"gobierno", "government"},
        {"empresa", "company"}
    };

    static void Main() //menu para traducir frases o agregar palabras al diccionario
    {
        string opcion;
        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                TraducirFrase();
            }
            else if (opcion == "2")
            {
                AgregarPalabra();
            }
            else if (opcion == "0")
            {
                Console.WriteLine("Saliendo...");
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }

        } while (opcion != "0");
    }

    static void TraducirFrase() // Traduce una frase ingresada por el usuario utilizando el diccionario
    {
        Console.Write("Ingrese la frase: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.Split(' ');

        for (int i = 0; i < palabras.Length; i++)
        {
            string limpia = palabras[i].Trim(",.;:!?".ToCharArray()).ToLower();
            if (diccionario.ContainsKey(limpia))
            {
                palabras[i] = palabras[i].Replace(limpia, diccionario[limpia]);
            }
        }

        Console.WriteLine("Traducción: " + string.Join(" ", palabras));
    }

    static void AgregarPalabra() // Permite al usuario agregar una nueva palabra al diccionario con su traducción correspondiente|
    {
        Console.Write("Palabra en español: ");
        string esp = Console.ReadLine().ToLower();

        Console.Write("Traducción en inglés: ");
        string eng = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(esp))
        {
            diccionario.Add(esp, eng);
            Console.WriteLine("Agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe.");
        }
    }
}

