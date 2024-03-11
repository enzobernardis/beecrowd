using System; 

class URI {

  static void Main(string[] args) { 
    int count = 0;
    for(int i = 0; i < 5; i++) {
      int input = int.Parse(Console.ReadLine());
      if (input % 2 == 0) {
        count++;
      }
    }
    Console.WriteLine($"{count} valores pares");
  }

}
