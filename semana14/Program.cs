using System;

class Nodo
{
    public int Valor;
    public Nodo Izquierdo;
    public Nodo Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}

class ArbolBST
{
    public Nodo Raiz;

    public void Insertar(int valor)
    {
        Raiz = InsertarRec(Raiz, valor);
    }

    private Nodo InsertarRec(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierdo = InsertarRec(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = InsertarRec(nodo.Derecho, valor);

        return nodo;
    }

    public bool Buscar(int valor)
    {
        return BuscarRec(Raiz, valor);
    }

    private bool BuscarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return false;
        if (valor == nodo.Valor) return true;
        if (valor < nodo.Valor) return BuscarRec(nodo.Izquierdo, valor);
        return BuscarRec(nodo.Derecho, valor);
    }

    public void Eliminar(int valor)
    {
        Raiz = EliminarRec(Raiz, valor);
    }

    private Nodo EliminarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return nodo;

        if (valor < nodo.Valor)
            nodo.Izquierdo = EliminarRec(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = EliminarRec(nodo.Derecho, valor);
        else
        {
            if (nodo.Izquierdo == null) return nodo.Derecho;
            else if (nodo.Derecho == null) return nodo.Izquierdo;

            nodo.Valor = Minimo(nodo.Derecho);
            nodo.Derecho = EliminarRec(nodo.Derecho, nodo.Valor);
        }
        return nodo;
    }

    public void PreOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            PreOrden(nodo.Izquierdo);
            PreOrden(nodo.Derecho);
        }
    }

    public void InOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            InOrden(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            InOrden(nodo.Derecho);
        }
    }

    public void PostOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            PostOrden(nodo.Izquierdo);
            PostOrden(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }

    public int Minimo(Nodo nodo)
    {
        int min = nodo.Valor;
        while (nodo.Izquierdo != null)
        {
            min = nodo.Izquierdo.Valor;
            nodo = nodo.Izquierdo;
        }
        return min;
    }

    public int Maximo(Nodo nodo)
    {
        int max = nodo.Valor;
        while (nodo.Derecho != null)
        {
            max = nodo.Derecho.Valor;
            nodo = nodo.Derecho;
        }
        return max;
    }

    public int Altura(Nodo nodo)
    {
        if (nodo == null) return 0;
        int izq = Altura(nodo.Izquierdo);
        int der = Altura(nodo.Derecho);
        return Math.Max(izq, der) + 1;
    }

    public void Limpiar()
    {
        Raiz = null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArbolBST arbol = new ArbolBST();
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ ÁRBOL BINARIO DE BÚSQUEDA ---");
            Console.WriteLine("1. Insertar valor");
            Console.WriteLine("2. Buscar valor");
            Console.WriteLine("3. Eliminar valor");
            Console.WriteLine("4. Mostrar Preorden");
            Console.WriteLine("5. Mostrar Inorden");
            Console.WriteLine("6. Mostrar Postorden");
            Console.WriteLine("7. Mostrar mínimo");
            Console.WriteLine("8. Mostrar máximo");
            Console.WriteLine("9. Mostrar altura del árbol");
            Console.WriteLine("10. Limpiar árbol");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor a insertar: ");
                    int valorInsertar = int.Parse(Console.ReadLine());
                    arbol.Insertar(valorInsertar);
                    break;
                case 2:
                    Console.Write("Ingrese valor a buscar: ");
                    int valorBuscar = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(valorBuscar) ? "Valor encontrado." : "Valor no encontrado.");
                    break;
                case 3:
                    Console.Write("Ingrese valor a eliminar: ");
                    int valorEliminar = int.Parse(Console.ReadLine());
                    arbol.Eliminar(valorEliminar);
                    break;
                case 4:
                    Console.Write("Recorrido Preorden: ");
                    arbol.PreOrden(arbol.Raiz);
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Write("Recorrido Inorden: ");
                    arbol.InOrden(arbol.Raiz);
                    Console.WriteLine();
                    break;
                case 6:
                    Console.Write("Recorrido Postorden: ");
                    arbol.PostOrden(arbol.Raiz);
                    Console.WriteLine();
                    break;
                case 7:
                    if (arbol.Raiz != null)
                        Console.WriteLine("Mínimo: " + arbol.Minimo(arbol.Raiz));
                    else
                        Console.WriteLine("Árbol vacío.");
                    break;
                case 8:
                    if (arbol.Raiz != null)
                        Console.WriteLine("Máximo: " + arbol.Maximo(arbol.Raiz));
                    else
                        Console.WriteLine("Árbol vacío.");
                    break;
                case 9:
                    Console.WriteLine("Altura del árbol: " + arbol.Altura(arbol.Raiz));
                    break;
                case 10:
                    arbol.Limpiar();
                    Console.WriteLine("Árbol limpiado.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 0);
    }
}

