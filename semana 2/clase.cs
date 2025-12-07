using System; // se importa la libreria

class Rectangulo // definicion de la clase
{
    public double ancho; // atributos publicos
    public double alto;

    public double Area()  // metodo que calcula el area
    {
        return ancho * alto;
    }

    public double Perimetro() // metodo que calcula el area
    {
        return 2 * (ancho + alto);
    }
}

class Cuadrado
{
    public double lado; // atributos publicos

    public double Area() // metodo que calcula el area
    {
        return lado * lado;
    }

    public double Perimetro() // metodo que calcula el area
    {
        return 4 * lado;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangulo rect = new Rectangulo(); // creacion del objeto
        rect.ancho = 10;
        rect.alto = 5;
        Console.WriteLine("Área del rectángulo: " + rect.Area()); // llamada a los metodos
        Console.WriteLine("Perímetro del rectángulo: " + rect.Perimetro());

        Cuadrado cuad = new Cuadrado();
        cuad.lado = 6;
        Console.WriteLine("Área del cuadrado: " + cuad.Area());
        Console.WriteLine("Perímetro del cuadrado: " + cuad.Perimetro());
    }
}
