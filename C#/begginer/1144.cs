using System;

class URI {

  static void Main(string[] args) {
    int number = int.Parse(Console.ReadLine());

    for(int i = 1; i <= number; i++) {
      for(int j = 0; j < 2; j++) {
        Console.WriteLine($"{i} {i * i + j} {i * i * i + j}");
      }
    }
  }
}
