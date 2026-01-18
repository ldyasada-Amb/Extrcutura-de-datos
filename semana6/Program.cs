using System;   
using System.Collections.Generic;
using listaenlazada;
using listaenlazada2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== EJEMPLO 1: Lista Enlazada con Longitud ==========");
        listaenlazada.ListaEnlazada lista1 = new listaenlazada.ListaEnlazada();
        lista1.Agregar(2);
        lista1.Agregar(3);
        lista1.Agregar(4);

        Console.WriteLine("Lista 1:");
        lista1.Mostrar();
        Console.WriteLine("Longitud: " + lista1.Longitud());

        Console.WriteLine("\n========== EJEMPLO 2: Lista Enlazada Invertida ==========");
        ListaEnlazada2 lista2 = new ListaEnlazada2();
        lista2.Agregar(1);
        lista2.Agregar(2);
        lista2.Agregar(3);
        lista2.Agregar(4);

        Console.WriteLine("Lista 2 original:");
        lista2.Mostrar();

        lista2.Invertir();

        Console.WriteLine("Lista 2 invertida:");
        lista2.Mostrar();
    }
}