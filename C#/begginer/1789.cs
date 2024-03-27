using System;
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<int> answers = new List<int>();
    string line;
    while((line = Console.ReadLine()) != null) {
      int numOfSlugs = int.Parse(line), mostHighSpeed;
      int[] speedOfSlugs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
      mostHighSpeed = speedOfSlugs[0];

      foreach(int speed in speedOfSlugs) {
        if(speed > mostHighSpeed) mostHighSpeed = speed;
      }

      if(mostHighSpeed < 10) answers.Add(1);
      else if (mostHighSpeed >= 10 && mostHighSpeed < 20) answers.Add(2);
      else answers.Add(3);
    }

    foreach(int answer in answers) Console.WriteLine(answer);
  } 
}
