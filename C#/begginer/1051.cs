using System; 

class URI {

  static void Main(string[] args) { 
    double input = double.Parse(Console.ReadLine());
    double[] taxes = new double[3];
    double toPay = 0.0;

    if(input <= 2000.00) Console.WriteLine("Isento");
    else {
      if(input <= 3000.00) {
        toPay = (input - 2000.00) * 0.08;
      } else {
        if(input <= 4500.00) {
          toPay = (input - 3000.00) * 0.18 + 1000.00 * 0.08;
        } else {
          toPay = (input - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
        }
      }
      Console.WriteLine($"R$ {toPay:F2}");
    }
  }
}
