using System; 

class URI {

  static void Main(string[] args) { 
    string[] input = Console.ReadLine().Split(' ');
    int code = int.Parse(input[0]);
    int amount = int.Parse(input[1]);

    double[] items = { 4.00, 4.50, 5.00, 2.00, 1.50 };

    double total = items[code - 1] * amount;

    Console.WriteLine($"Total: R$ {total:F2}");
  }

}