using System;

class URI {

  static void Main(string[] args) {
    for(float i = 0; i < 2.1; i+=0.2f) {
      for(int j = 1; j <= 3; j++) Console.WriteLine($"I={i} J={j + i}");
    }
  }
}
