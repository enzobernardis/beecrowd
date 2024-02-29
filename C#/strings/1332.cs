using System;

class URI {
  static void Main(string[] args) {
    int loopTimes = int.Parse(Console.ReadLine());
    int[] answers = new int[loopTimes];

    for(int i = 0; i < loopTimes; i++) {
      string input = Console.ReadLine();

      if(input.Length == 5) {
        answers[i] = 3;
      } else {
        int count = 0;
        string stringOne = "one";
        for(int j = 0; j < input.Length; j++) {
          if (input[j] == stringOne[j]) count++;
        }
        if(count >= 2) {
          answers[i] = 1;
        } else {
          answers[i] = 2;
        }
      }
    }

    foreach(int answer in answers) {
      Console.WriteLine(answer);
    }
  }
}