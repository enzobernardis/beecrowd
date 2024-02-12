using System; 

class URI {

    static void Main(string[] args) { 
        int n = int.Parse(Console.ReadLine());

        int sec = n % 60;
        int min = n / 60;
        int hou = min / 60;
        min %= 60;

        Console.WriteLine($"{hou}:{min}:{sec}");

    }

}