using System; 

class URI {

    static void Main(string[] args) { 
        double[] price = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
        double percentage = (price[1] / price[0]) - 1.0;
        percentage *= 100.0;
        Console.WriteLine($"{percentage:F2}%");
    }

}
