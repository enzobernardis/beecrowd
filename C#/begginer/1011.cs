using System; 

class URI {

    static void Main(string[] args) { 

        int r = int.Parse(Console.ReadLine());

        double vol = (4.0/3.0) * 3.14159 * Math.Pow(r, 3);

        Console.WriteLine($"VOLUME = {vol:F3}");

    }

}