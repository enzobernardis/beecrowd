using System; 

class URI {

  static void Main(string[] args) { 
    int loopTimes = int.Parse(Console.ReadLine());
    int totalAmount = 0, numCoelho = 0, numRato = 0, numSapo = 0;

    for(int i = 0; i < loopTimes; i++) {
      string[] input = Console.ReadLine().Split(' ');
      int amount = int.Parse(input[0]);
      char type = char.Parse(input[1]);

      switch(type) {
      case 'C':
        numCoelho += amount;
        totalAmount += amount;
        break;
      case 'R':
        numRato += amount;
        totalAmount += amount;
        break;
      case 'S':
        numSapo += amount;
        totalAmount += amount;
        break;
      }
    }

    Console.WriteLine($"Total: {totalAmount} cobaias");
    Console.WriteLine($"Total de coelhos: {numCoelho}");
    Console.WriteLine($"Total de ratos: {numRato}");
    Console.WriteLine($"Total de sapos: {numSapo}");
    Console.WriteLine($"Percentual de coelhos: {numCoelho * 100.0 / totalAmount:F2} %");
    Console.WriteLine($"Percentual de ratos: {numRato * 100.0 / totalAmount:F2} %");
    Console.WriteLine($"Percentual de sapos: {numSapo * 100.0 / totalAmount:F2} %");

  }

}
