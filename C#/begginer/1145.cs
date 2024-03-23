using System;

class URI {

  static void Main(string[] args) {
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int saveJ = 1, j;

    for(int i = 0; i < input[1] / input[0]; i++) {
      string line = "";
      for(j = saveJ; j < saveJ + input[0]; j++) line += j + " ";
      Console.WriteLine(line.Trim());
      saveJ = j;
    }
  }
}
