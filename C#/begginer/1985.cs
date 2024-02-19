using System; 

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    double toPay = 0;
    for(int i = 0; i < n; i++) {
      int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

      switch(input[0]) {
      case 1001:
        toPay += 1.5 * input[1];
        break;
      case 1002:
        toPay += 2.5 * input[1];
        break;
      case 1003:
        toPay += 3.5 * input[1];
        break;
      case 1004:
        toPay += 4.5 * input[1];
        break;
      case 1005:
        toPay += 5.5 * input[1];
        break;
      }
    }

    Console.WriteLine($"{toPay:F2}");
  }

}