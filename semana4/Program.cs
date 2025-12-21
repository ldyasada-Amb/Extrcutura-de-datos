using System;
using System.Collections.Generic;

// Clase Contacto con propiedades
class Contacto
{
    public string Nombre { get; set; } // get y set sirvern para acceder y modificar las propiedades
    public string Telefono { get; set; }

    public Contacto(string nombre, string telefono) // Constructor          
    {
        Nombre = nombre;
        Telefono = telefono;
    }

    public override string ToString()// Método para mostrar el contacto
    {
        return $"Nombre: {Nombre}, Teléfono: {Telefono}";
    }
}

// Clase Agenda que gestiona los contactos
class Agenda
{
    private List<Contacto> contactos = new List<Contacto>();

    public void AgregarContacto(string nombre, string telefono)
    {
        contactos.Add(new Contacto(nombre, telefono));
        Console.WriteLine("Contacto agregado.");
    }

    public void ListadeContactos()
    {
        Console.WriteLine("\nLista de contactos:");
        if (contactos.Count == 0)
        {
            Console.WriteLine("No hay contactos registrados.");
        }
        else
        {
            foreach (var c in contactos)
            {
                Console.WriteLine(c);
            }
        }
    }
}

// Clase principal Program
class Programprincipal
{
    static void Main()
    {
        Agenda agenda = new Agenda();

        string[,] etiquetas = {
            {"Nombre", "aqui va el nombre"},
            {"Teléfono", "aqui va el teléfono"}
        };

        while (true)
        {
            Console.WriteLine("\nAgenda Telefónica");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Listar contactos");
            Console.WriteLine("3. Mostrar matriz");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("Por favor ingrese un número válido.");
                continue;
            }

            if (opcion == 0) break;
            else if (opcion == 1)
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Teléfono: ");
                string telefono = Console.ReadLine();
                agenda.AgregarContacto(nombre, telefono);
            }
            else if (opcion == 2)
            {
                agenda.ListadeContactos();
            }
            else if (opcion == 3)
            {
                Console.WriteLine("\nMatriz de etiquetas:");
                for (int i = 0; i < etiquetas.GetLength(0); i++)
                {
                    for (int j = 0; j < etiquetas.GetLength(1); j++)
                    {
                        Console.Write(etiquetas[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}
