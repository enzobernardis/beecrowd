using System; 

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int[] guesses = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    int correct = 0;

    foreach(int i in guesses) {
      if(i == n) {
        correct++;
      }
    }

    Console.WriteLine(correct);
  }

}