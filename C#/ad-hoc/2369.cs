using System; 

class URI {

  static void Main(string[] args) { 
    int n = int.Parse(Console.ReadLine());
    int total = 7;


    for(int i = 1; i <= n; i++) {
      if(i > 10 && i < 31) {
        total += 1;
      } else if(i > 30 && i < 101) {
        total += 2;
      } else if(i > 100) {
        total += 5;
      }
    }

    Console.WriteLine(total);
  }

}