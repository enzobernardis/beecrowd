using System;
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<string> answers = new List<string>();
    while(true) {
      int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

      if(numbers[0] <= 0 || numbers[1] <= 0) break;

      Array.Sort(numbers);

      int sum = 0;
      string result = "";
      for(int i = numbers[0]; i <= numbers[1]; i++) {
        result += i + " ";
        sum += i;
      }
      result += "Sum=" + sum;
      answers.Add(result);
    }

    foreach(string answer in answers) Console.WriteLine(answer);
  }
}
