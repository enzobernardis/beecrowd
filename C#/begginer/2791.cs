using System; 

class URI {

  static void Main(string[] args) {
    int[] cups = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    Console.WriteLine(Array.IndexOf(cups, 1) + 1);
  }

}