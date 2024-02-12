using System;
using System.Collections.Generic;

class URI {
  static void Main(string[] args) { 
    List<string> response = new List<string>();

    while(true) {
      int n = int.Parse(Console.ReadLine());

      if(n > 0) {
        int aPoints = 0, bPoints = 0;

        for(int i = 0; i < n; i++) {
          string[] input = Console.ReadLine().Split(' ');
          int a = int.Parse(input[0]);
          int b = int.Parse(input[1]);

          if(a > b) {
            aPoints++;
          } else if(a < b) {
            bPoints++;
          } 
        }

        response.Add($"{aPoints} {bPoints}");

      } else {
        break;
      }
    }
    foreach(string s in response) {
      Console.WriteLine(s);
    }
  }
}
