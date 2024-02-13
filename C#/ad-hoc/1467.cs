using System;
using System.Collections.Generic;

class URI {

  static void Main(string[] args) { 
    List<string> answer = new List<string>();

    string line;
    while((line = Console.ReadLine()) != null) {
      string[] input = line.Split(' ');

      int[] n = new int[3];
      for(int j = 0; j < 3; j++) {
        n[j] = int.Parse(input[j]);
      }

      if(n[0] != n[1] && n[0] != n[2]) {
        answer.Add("A");
      } else if(n[1] != n[0] && n[1] != n[2]) {
        answer.Add("B");
      } else if(n[2] != n[0] && n[2] != n[1]) {
        answer.Add("C");
      } else {
        answer.Add("*");
      }
    }

    foreach(string c in answer) {
      Console.WriteLine(c);
    }
  }

}
