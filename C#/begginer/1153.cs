using System; 

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int result = n;

    for (int i = 1; i < n; i++) {
      result *= i;
    }

    Console.WriteLine(result);
  }

}