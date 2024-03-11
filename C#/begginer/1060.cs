using System; 

class URI {

  static void Main(string[] args) { 
    int count = 0;
    for(int i = 0; i < 6; i++) {
      double input = double.Parse(Console.ReadLine());
      if (input > 0) count++;
    }
    Console.WriteLine($"{count} valores positivos");
  }

}
