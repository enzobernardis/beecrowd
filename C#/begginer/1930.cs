using System;
using System.Linq;

class URI {

  static void Main(string[] args) {
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    Console.WriteLine(numbers.Sum() - 3);
  } 
}
