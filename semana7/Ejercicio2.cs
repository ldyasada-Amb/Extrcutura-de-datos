using System;
using System.Collections.Generic;

class Torre // Representa una torre en el juego de Torres de Hanoi
{
    public string Nombre { get; }
    public Stack<int> Discos { get; }

    public Torre(string nombre) // Constructor de la torre 
    {
        Nombre = nombre;
        Discos = new Stack<int>();
    }

    public void MoverDiscoA(Torre destino)  // Mueve el disco superior a otra torre         
    {
        int disco = Discos.Pop();
        destino.Discos.Push(disco);
        Console.WriteLine($"Mover disco {disco} de {Nombre} a {destino.Nombre}");
    }
}

class Hanoi // Clase principal para resolver las Torres de Hanoi                                                                
{
    private Torre origen, auxiliar, destino;

    public Hanoi(int n) // Constructor que inicia la resolución del problema
    {
        origen = new Torre("Origen");
        auxiliar = new Torre("Auxiliar");
        destino = new Torre("Destino");

        for (int i = n; i >= 1; i--)
            origen.Discos.Push(i);

        Resolver(n, origen, destino, auxiliar);
    }

    private void Resolver(int n, Torre origen, Torre destino, Torre auxiliar) // Método recursivo para resolver las Torres de Hanoi 
    {
        if (n == 1)
        {
            origen.MoverDiscoA(destino);
        }
        else
        {
            Resolver(n - 1, origen, auxiliar, destino);
            origen.MoverDiscoA(destino);
            Resolver(n - 1, auxiliar, destino, origen);
        }
    }
}

