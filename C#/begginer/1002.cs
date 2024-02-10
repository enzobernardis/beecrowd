using System; 

class URI {

    static void Main(string[] args) { 

        double r, a;

        r = double.Parse(Console.ReadLine());

        a = 3.14159 * (r * r);

        Console.WriteLine($"A={a:F4}");

    }

}