using System; 

class URI {

    static void Main(string[] args) { 

        int num, workedHours;
        double recPerHour;

        num = int.Parse(Console.ReadLine());
        workedHours = int.Parse(Console.ReadLine());
        recPerHour = double.Parse(Console.ReadLine());

        double salary = workedHours * recPerHour;

        Console.WriteLine($"NUMBER = {num}");
        Console.WriteLine($"SALARY = U$ {salary:F2}");

    }

}