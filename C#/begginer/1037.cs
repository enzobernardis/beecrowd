using System; 

class URI {

  static void Main(string[] args) { 
    double n = double.Parse(Console.ReadLine());

    string which = n > 25 ? "(" : "[";

    int[] interval = { 0, 25, 50, 75, 100 };

    for(int i = 0; i < interval.Length; i++) {
      if(n >= interval[i] && n <= interval[i+1]) {
        Console.WriteLine($"Intervalo {which}{interval[i]},{interval[i+1]}]");
        break;
      } else if(n < 0 || n > 100) {
        Console.WriteLine("Fora de intervalo");
        break;
      }
    }
  }

}