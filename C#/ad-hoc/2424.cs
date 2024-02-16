using System;

class URI {

  static void Main(string[] args) {
    int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    if(n[0] >= 0 && n[0] <= 432 && n[1] >= 0 && n[1] <= 468) {
      Console.WriteLine("dentro");
    } else {
      Console.WriteLine("fora");
    }
  }

}
