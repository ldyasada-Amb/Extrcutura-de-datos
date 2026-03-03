using System;
using System.Collections.Generic;

public class Deportista
{
    public string Nombre { get; set; }
    public string Disciplina { get; set; }
    public string Medalla { get; set; }

    public Deportista(string nombre, string disciplina, string medalla)
    {
        Nombre = nombre;
        Disciplina = disciplina;
        Medalla = medalla;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Disciplina} - {Medalla}";
    }
}

class Program
{
    static void Main()
    {
        // Conjunto de disciplinas
        HashSet<string> disciplinas = new HashSet<string>();

        // Mapa de deportistas (ID -> Deportista)
        Dictionary<string, Deportista> deportistas = new Dictionary<string, Deportista>();

        // Registro de deportistas
        deportistas["001"] = new Deportista("Ana Pérez", "Atletismo", "Oro");
        deportistas["002"] = new Deportista("Luis Gómez", "Natación", "Plata");
        deportistas["003"] = new Deportista("María Torres", "Gimnasia", "Bronce");

        // Agregar disciplinas únicas
        foreach (var d in deportistas.Values)
        {
            disciplinas.Add(d.Disciplina);
        }

        // Reporte general
        Console.WriteLine("=== Disciplinas registradas ===");
        foreach (var disc in disciplinas)
        {
            Console.WriteLine(disc);
        }

        Console.WriteLine("\n=== Deportistas premiados ===");
        foreach (var dep in deportistas.Values)
        {
            Console.WriteLine(dep);
        }
    }
}

