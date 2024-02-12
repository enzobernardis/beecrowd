using System;
using System.Collections.Generic;

class Program {

    static void Main(string[] args) { 
      List<string> answers = new List<string>();
      while(true) {
        int times = int.Parse(Console.ReadLine());

        if(times > 0) {
           string[] inputDivisionPoint = Console.ReadLine().Split();
           int divisionPointX = int.Parse(inputDivisionPoint[0]);
           int divisionPointY = int.Parse(inputDivisionPoint[1]);

           int[,] inputPoint = new int[times, 2];

           for (int i = 0; i < times; i++) {
              string[] point = Console.ReadLine().Split();
              inputPoint[i, 0] = int.Parse(point[0]);
              inputPoint[i, 1] = int.Parse(point[1]);

              if(inputPoint[i, 0] == divisionPointX || inputPoint[i, 1] == divisionPointY) {
                answers.Add("divisa");
              } else if(inputPoint[i, 0] > divisionPointX && inputPoint[i, 1] > divisionPointY) {
                answers.Add("NE");
              } else if(inputPoint[i, 0] < divisionPointX && inputPoint[i, 1] > divisionPointY) {
                answers.Add("NO");
              } else if (inputPoint[i, 0] < divisionPointX && inputPoint[i, 1] < divisionPointY) {
                answers.Add("SO");
              } else if (inputPoint[i, 0] > divisionPointX && inputPoint[i, 1] < divisionPointY) {
                answers.Add("SE");
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
