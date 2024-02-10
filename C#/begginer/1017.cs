using System; 

class URI {

    static void Main(string[] args) { 

        int spentTime = int.Parse(Console.ReadLine());
        int averSpeed = int.Parse(Console.ReadLine());

        Console.WriteLine($"{(spentTime * averSpeed) / 12.0:F3}");

    }

}