using System;

class URI {

  static void Main(string[] args) {
    int loopTimes = int.Parse(Console.ReadLine());
    int[] answers = new int[loopTimes];
    
    for(int i = 0; i < loopTimes; i++) {
      int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
      answers[i] = 0;
      int count = 0, j = numbers[0];

      while(count < numbers[1]) {
        if(j % 2 != 0) {
          answers[i] += j;
          count++;
        }
        j++;
      }
    }

    foreach(int answer in answers) Console.WriteLine(answer);
  }

}
