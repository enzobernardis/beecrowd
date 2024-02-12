using System;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
      List<string> answers = new List<string>();
      while(true) {
        int times = int.Parse(Console.ReadLine());

        if(times > 0) {

          for (int i = 0; i < times; i++) {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);
            int e = int.Parse(input[4]);

            if(a <= 127 && b > 127 && c > 127 && d > 127 && e > 127) {
              answers.Add("A");
            } else if(a > 127 && b <= 127 && c > 127 && d > 127 && e > 127) {
              answers.Add("B");
            } else if(a > 127 && b > 127 && c <= 127 && d > 127 && e > 127) {
              answers.Add("C");
            } else if(a > 127 && b > 127 && c > 127 && d <= 127 && e > 127) {
              answers.Add("D");
            } else if(a > 127 && b > 127 && c > 127 && d > 127 && e <= 127) {
              answers.Add("E");
            } else {
              answers.Add("*");
            }
          }
        } else {
          break;
        }
      }
      foreach(string answer in answers) {
        Console.WriteLine(answer);
      }
    }
}
