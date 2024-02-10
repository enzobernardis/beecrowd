using System; 

class URI {

    static void Main(string[] args) { 

        double a, b, c, aver;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        aver = ((a * 2 + b * 3 + c * 5) / (2 + 3 + 5));

        Console.WriteLine($"MEDIA = {aver:F1}");

    }

}