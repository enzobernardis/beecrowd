using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
  static void Main(string[] args){
    List<string> resultList = new List<string>();

    while (true) {
      string[] input = Console.ReadLine().Split(' ');

      if (input[0] == "0" && input[1] == "0") break;

      int students = int.Parse(input[0]);
      int dinners = int.Parse(input[1]);

      int[,] inputDinners = new int[dinners, students];

      for (int i = 0; i < dinners; i++) {
        int[] dinnerRow = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        for (int j = 0; j < students; j++){
          inputDinners[i, j] = dinnerRow[j];
        }
      }

      int[] pointsStudents = new int[students];

      for (int i = 0; i < dinners; i++) {
        for (int j = 0; j < students; j++) {
          if (inputDinners[i, j] == 1) {
            pointsStudents[j]++;
          }
        }
      }

      if (pointsStudents.Any(x => x == dinners)) {
        resultList.Add("yes");
      } else {
        resultList.Add("no");
      }
    }

    foreach (string result in resultList){
      Console.WriteLine(result);
    }
  }
}