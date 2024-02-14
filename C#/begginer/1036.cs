using System;

class URI {

  static void Main(string[] args) {
    string[] input = Console.ReadLine().Split(' ');
    double a = double.Parse(input[0]);
    double b = double.Parse(input[1]);
    double c = double.Parse(input[2]);

    double delta = Math.Pow(b, 2) - 4 * a * c;

    if(delta < 0 || a == 0) {
      Console.WriteLine("Impossivel calcular");
    } else {
      double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
      double r2 = (-b - Math.Sqrt(delta)) / (2 * a);

      Console.WriteLine($"R1 = {r1:F5}");
      Console.WriteLine($"R2 = {r2:F5}");
    }
  }

}
