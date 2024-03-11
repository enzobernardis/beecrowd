using System; 

class URI {

  static void Main(string[] args) { 
    double average = 0;
    int count = 0;
    for(int i = 0; i < 6; i++) {
      double input = double.Parse(Console.ReadLine());
      if (input > 0) {
        count++;
        average += input;
      }
    }
    Console.WriteLine($"{count} valores positivos");
    Console.WriteLine($"{average / count:F1}");
  }

}
