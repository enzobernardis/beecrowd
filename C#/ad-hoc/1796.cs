using System; 
using System.Linq;

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int[] answers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    int sum = answers.Sum();

    if(sum < n / 2.0) {
      Console.WriteLine("Y");
    } else {
      Console.WriteLine("N");
    }
  }

}