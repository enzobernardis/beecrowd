using System;

class URI {

  static void Main(string[] args) {
    decimal[] n = new decimal[100];
    n[0] = decimal.Parse(Console.ReadLine());

    for(int i = 1; i < 100; i++) { 
      n[i] = n[i - 1] / 2;
    }

    for(int i = 0; i < 100; i++) Console.WriteLine($"N[{i}] = {Math.Round(n[i], 4):F4}");
  }
}
