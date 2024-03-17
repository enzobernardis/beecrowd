using System;

class URI {

  static void Main(string[] args) {
    int number = int.Parse(Console.ReadLine());

    for(int i = 0; i < 10; i++) {
      Console.WriteLine($"N[{i}] = {number}");
      number *= 2;
    }
  }
}
