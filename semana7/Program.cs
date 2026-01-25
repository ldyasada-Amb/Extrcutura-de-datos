using VerificacionBalanceada;

class Program // Programa principal que ejecuta ambos ejercicios
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== EJERCICIO 1: Verificar Balance ===");
        BalanceChecker checker = new BalanceChecker();

        Console.WriteLine("Ingrese la expresión matemática:");
        string expresion = Console.ReadLine() ?? "";

        if (checker.EsBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.\n");
        else
            Console.WriteLine("Fórmula NO balanceada.\n");

        Console.WriteLine("=== EJERCICIO 2: Torres de Hanoi ===");
        Console.Write("Número de discos: ");
        int n = int.Parse(Console.ReadLine() ?? "3");

        new Hanoi(n);

        Console.WriteLine("¡Resuelto!");
    }
}
