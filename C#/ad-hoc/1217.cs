using System; 

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    string[] dayKg = new string[n];
    double kgTotal = 0;
    double paidTotal = 0;

    for(int i = 0; i < n; i++) {
      double paid = double.Parse(Console.ReadLine());
      paidTotal += paid;
      string[] fruits = Console.ReadLine().Split(' ');
      kgTotal += fruits.Length;

      dayKg[i] = "day " + (i + 1) + ": " + fruits.Length + " kg";
    }

    foreach(string i in dayKg) {
      Console.WriteLine(i);
    }

    Console.WriteLine($"{kgTotal / n:F2} kg by day");
    Console.WriteLine($"R$ {paidTotal / n:F2} by day");
  }

}