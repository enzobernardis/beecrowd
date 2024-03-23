using System;
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<int> answers = new List<int>();

    while(true) {
      int n = int.Parse(Console.ReadLine()), sum = 0;
      
      if(n == 0) break;
      if(n % 2 != 0) n++;
      
      for(int i = 0; i < 5; i++) { sum += n; n+=2; }

      answers.Add(sum);
    }

    foreach(int answer in answers) Console.WriteLine(answer);
  }
}
