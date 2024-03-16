using System;
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<string> answers = new List<string>();

    while(true) {
      int finalNum = int.Parse(Console.ReadLine());
      if(finalNum == 0) break;

      string result = "";
      for(int i = 1; i <= finalNum; i++) {
        result += i + " ";
      }

      answers.Add(result.Trim());
    }

    foreach(string answer in answers) Console.WriteLine(answer);
  }

}
