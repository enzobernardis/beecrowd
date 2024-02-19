using System; 

class URI {

  static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());

    for(int i = 0; i <= 100; i++) {
      if((a + i) / 2 == m) {
        Console.WriteLine(i);
        break;
      }
    }
  }

}