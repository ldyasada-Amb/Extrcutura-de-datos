using System;

namespace VuelosArbol
{
    public class Vuelo
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public double Precio { get; set; }

        public Vuelo(string origen, string destino, double precio)
        {
            Origen = origen;
            Destino = destino;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"{Origen} -> {Destino} | Precio: ${Precio}";
        }
    }

    public class NodoVuelo
    {
        public Vuelo Vuelo { get; set; }
        public NodoVuelo Izquierdo { get; set; }
        public NodoVuelo Derecho { get; set; }

        public NodoVuelo(Vuelo vuelo)
        {
            Vuelo = vuelo;
            Izquierdo = null;
            Derecho = null;
        }
    }

    public class ArbolVuelos
    {
        public NodoVuelo Raiz { get; set; }

        public void Insertar(Vuelo vuelo)
        {
            Raiz = InsertarRecursivo(Raiz, vuelo);
        }

        private NodoVuelo InsertarRecursivo(NodoVuelo nodo, Vuelo vuelo)
        {
            if (nodo == null)
                return new NodoVuelo(vuelo);

            if (vuelo.Precio < nodo.Vuelo.Precio)
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, vuelo);
            else
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, vuelo);

            return nodo;
        }

        public void MostrarOrdenado(NodoVuelo nodo)
        {
            if (nodo != null)
            {
                MostrarOrdenado(nodo.Izquierdo);
                Console.WriteLine(nodo.Vuelo);
                MostrarOrdenado(nodo.Derecho);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArbolVuelos arbol = new ArbolVuelos();

            arbol.Insertar(new Vuelo("Quito", "Guayaquil", 80));
            arbol.Insertar(new Vuelo("Quito", "Cuenca", 60));
            arbol.Insertar(new Vuelo("Guayaquil", "Madrid", 750));
            arbol.Insertar(new Vuelo("Quito", "Bogotá", 200));
            arbol.Insertar(new Vuelo("Cuenca", "Quito", 55));

            Console.WriteLine("Vuelos ordenados por precio:");
            arbol.MostrarOrdenado(arbol.Raiz);

            Console.ReadLine();
        }
    }
}
