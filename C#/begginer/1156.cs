using System;

class URI {

  static void Main(string[] args) {
    double s = 0;
    int j = 1;

    for(int i = 1; i <= 39; i += 2) {
      s += (double)i / j;
      j *= 2;
    }

    Console.WriteLine($"{s:F2}");
  }
}
