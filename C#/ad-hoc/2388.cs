using System; 

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int km = 0;

    int[,] values = new int[n,2];
    for(int i = 0; i < n; i++) {
      string[] input = Console.ReadLine().Split(' ');
      for (int j = 0; j < 2; j++) {
        values[i, j] = int.Parse(input[j]);
      }
    }

    for(int i = 0; i < n; i++) {
      km += values[i, 0] * values[i, 1];
    }

    Console.WriteLine(km);

  }

}