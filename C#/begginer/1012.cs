using System; 

class URI {

    static void Main(string[] args) { 

        string[] input = Console.ReadLine().Split(' ');

        double a = double.Parse(input[0]), b = double.Parse(input[1]), c = double.Parse(input[2]);

        Console.WriteLine($"TRIANGULO: {(a * c) / 2:F3}");
        Console.WriteLine($"CIRCULO: {3.14159 * Math.Pow(c, 2):F3}");
        Console.WriteLine($"TRAPEZIO: {((a + b) * c) / 2:F3}");
        Console.WriteLine($"QUADRADO: {Math.Pow(b, 2):F3}");
        Console.WriteLine($"RETANGULO: {a * b:F3}");

    }

}