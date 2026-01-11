using System;
using CursoPOO;
using LoteriEjemploPOO;
using NumerosPOOCollecion;

class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1: Mostrar lista de asignaturas
        Curso curso = new Curso();
        curso.MostrarAsignaturas();

        Console.WriteLine();

        // Ejercicio 2: Mostrar con mensaje "Yo estudio ..."
        CursoConMensaje curso2 = new CursoConMensaje();
        curso2.MostrarAsignaturasConMensaje();

        // Pausa para ver resultados
        Console.ReadLine();

        // Ejercicio 3:
        CursoPedidaNotas curso3 = new CursoPedidaNotas(); // Crear instancia de CursoPedidaNotas

        curso3.PedirNotas(); // Llamar al método para pedir notas al usuario
        curso3.MostrarNotas(); // Llamar al método para mostrar las notas ingresadas                                                                      

        Console.ReadLine();

        // Ejercicio 4 loteria
        LoteriaSorteo loteria = new LoteriaSorteo();

            // ingresar 6 números de lotería
        loteria.PedirNumeros(6);

        loteria.MostrarNumeros(); // Mostrar los números ordenados

        Console.ReadLine(); // Pausa para ver resultados

        // Ejercicio 5 números en orden inverso
        NumerosAlmacenados numeros = new NumerosAlmacenados();
        numeros.MostrarInverso();

        Console.ReadLine();
    }
}



