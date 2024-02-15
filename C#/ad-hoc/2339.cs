using System; 

class URI {

  static void Main(string[] args) {
    string[] input = Console.ReadLine().Split(' ');
    int c = int.Parse(input[0]);
    int p = int.Parse(input[1]);
    int f = int.Parse(input[2]);

    if(p / f >= c) {
      Console.WriteLine("S");
    } else {
      Console.WriteLine("N");
    }
  }

}