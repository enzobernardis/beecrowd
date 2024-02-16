using System; 
using System.Linq;

class URI {

  static void Main(string[] args) {
    int ball = int.Parse(Console.ReadLine());
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    if(input.Any(x => x < ball)) {
      Console.WriteLine("N");
    } else {
      Console.WriteLine("S");
    }
  }

}