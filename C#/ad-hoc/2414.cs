using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 
        int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int max = n.Max();
        Console.WriteLine(max);
    }

}