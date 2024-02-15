using System; 

class Program {

  static void Main(string[] args) {
    int brokenGlasses = 0;

    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++) {
      string[] input = Console.ReadLine().Split(' ');
      int cans = int.Parse(input[0]);
      int glasses = int.Parse(input[1]);

      if (cans > glasses) {
        brokenGlasses += glasses;
      }
    }

    Console.WriteLine(brokenGlasses);
  }

}