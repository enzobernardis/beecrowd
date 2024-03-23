using System;
using System.Collections.Generic;
using System.Linq;

class URI {

  static void Main(string[] args) {
    List<string> answers = new List<string>();
    int loop = 1;
    while(loop == 1) {
      double[] scores = new double[2];
      int i = 0;

      while(i < 2) {
        scores[i] = double.Parse(Console.ReadLine());
        if(scores[i] < 0 || scores[i] > 10) answers.Add("nota invalida");
        else i++;
      }

      answers.Add($"media = {scores.Sum() / 2.0:F2}");

      while(true) {
        answers.Add("novo calculo (1-sim 2-nao)");
        loop = int.Parse(Console.ReadLine());
        if(loop == 1 || loop == 2) break;
      }
    }

    foreach(string answer in answers) Console.WriteLine(answer);
  }
}
