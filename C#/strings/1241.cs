using System;

class URI {
  static void Main(string[] args) {
    int loopTimes = int.Parse(Console.ReadLine());
    string[] answers = new string[loopTimes];

    for(int i = 0; i < loopTimes; i++) {
      string[] input = Console.ReadLine().Split(' ');

      string num1 = input[0];
      string num2 = input[1];

      int fit = num1.IndexOf(num2);

      if(fit == -1) answers[i] = "nao encaixa";
      else answers[i] = "encaixa";
    }

    foreach(string answer in answers) {
      Console.WriteLine(answer);
    }
  }
}