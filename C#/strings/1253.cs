using System; 

class Program {

  static void Main(string[] args) { 
    int n = int.Parse(Console.ReadLine());
    string[] answers = new string[n];
    char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

    for(int i = 0; i < n; i++) {
      string input = Console.ReadLine();
      int x = int.Parse(Console.ReadLine());

      for(int j = 0; j < input.Length; j++) {
        int index = Array.IndexOf(alphabet, input[j]);
        answers[i] += alphabet[(index - x + 26) % 26];
      }
    }

    foreach(string answer in answers) {
      Console.WriteLine(answer);
    }
  }

}