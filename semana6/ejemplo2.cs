using System;

namespace listaenlazada2
{
public class Nodo2
{
    public int Dato;
    public Nodo2 Next;

    public Nodo2(int dato)
    {
        Dato = dato;
        Next = null;
    }
}

public class ListaEnlazada2
{
    private Nodo2 head;

    public void Agregar(int dato)
    {
        Nodo2 nuevo = new Nodo2(dato);
        if (head == null)
        {
            head = nuevo;
        }
        else
        {
            Nodo2 temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = nuevo;
        }
    }

    public void Mostrar()
    {
        Nodo2 temp = head;
        while (temp != null)
        {
            Console.Write(temp.Dato + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }

    // Método para invertir la lista
    public void Invertir()
    {
        Nodo2 prev = null;
        Nodo2 actual = head;
        Nodo2 siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Next;   // Guardamos el siguiente
            actual.Next = prev;        // Invertimos el enlace
            prev = actual;             // Avanzamos prev
            actual = siguiente;        // Avanzamos actual
        }

        head = prev; // Nuevo inicio de la lista
    }
}
}
