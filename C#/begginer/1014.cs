using System; 

class URI {

    static void Main(string[] args) { 

        int km = int.Parse(Console.ReadLine());
        double spentFuel = double.Parse(Console.ReadLine());

        Console.WriteLine($"{km / spentFuel:F3} km/l");

    }

}