using System; 

class URI {

  static void Main(string[] args) { 
    int input = int.Parse(Console.ReadLine());

    for(int i = 2; i <= 10000; i+=input) {
      Console.WriteLine(i);
    }
  }

}
