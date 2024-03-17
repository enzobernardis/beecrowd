using System;

class URI {

  static void Main(string[] args) {
    int number = int.Parse(Console.ReadLine());

    for(int i = 0; i < 1000; i++) Console.WriteLine($"N[{i}] = {i % number}");
  }
}
