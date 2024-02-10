using System; 

class URI {

    static void Main(string[] args) { 

        double a, b, aver;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        aver = ((a * 3.5 + b * 7.5) / (3.5 + 7.5));

        Console.WriteLine($"MEDIA = {aver:F5}");

    }

}