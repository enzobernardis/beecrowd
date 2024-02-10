using System;

class URI {

    static void Main(string[] args) { 

        string[] input1 = Console.ReadLine().Split(' ');
        double[] p1 = { double.Parse(input1[0]), double.Parse(input1[1]) };

        string[] input2 = Console.ReadLine().Split(' ');
        double[] p2 = { double.Parse(input2[0]), double.Parse(input2[1]) };

        Console.WriteLine($"{Math.Sqrt(Math.Pow(p2[0] - p1[0], 2) + Math.Pow(p2[1] - p1[1], 2)):F4}");
    }
}
