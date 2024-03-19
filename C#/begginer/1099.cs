using System;

class URI {

  static void Main(string[] args) {
    int loopTimes = int.Parse(Console.ReadLine());
    int[] answers = new int[loopTimes];

    for(int i = 0; i < loopTimes; i++) {
      int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
      Array.Sort(numbers);
      int sum = 0;

      for(int j = numbers[0] + 1; j < numbers[1]; j++) {
        if(j % 2 != 0) sum += j;
      }

      answers[i] = sum;
    }

    foreach(int answer in answers) Console.WriteLine(answer);
  }
}
