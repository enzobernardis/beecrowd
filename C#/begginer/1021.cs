using System; 

class URI {

  static void Main(string[] args) { 
    double input = double.Parse(Console.ReadLine());
    double[] values = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
    string notesOrCoins = "nota";

    Console.WriteLine("NOTAS:");
    for(int i = 0; i < values.Length; i++) {
      input = Math.Round(input, 2);
      if(i == 6) {
        Console.WriteLine("MOEDAS:");
        notesOrCoins = "moeda";
      }
      int count = (int)(input / values[i]);
      input = input - (values[i] * count);
      Console.WriteLine($"{count} {notesOrCoins}(s) de R$ {values[i]:F2}");
    }
  }
}
