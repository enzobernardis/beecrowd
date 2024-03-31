using System; 

class URI {

    static void Main(string[] args) { 
        double[] input = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
        double div = input[0] / input[1];
        Console.WriteLine($"{div:F2}");
    }

}
