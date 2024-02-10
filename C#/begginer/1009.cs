using System; 

class URI {

    static void Main(string[] args) { 

        string name;
        double salary, sold;

        name = Console.ReadLine();
        salary = double.Parse(Console.ReadLine());
        sold = double.Parse(Console.ReadLine());

        Console.WriteLine($"TOTAL = R$ {salary + sold * 0.15:F2}");

    }

}