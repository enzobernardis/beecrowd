using System;

class URI {

  static void Main(string[] args) {
    int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    Console.WriteLine(n[0] % n[1]);
  }

}