using System;

class URI {

  static void Main(string[] args) {
    int loopTimes = int.Parse(Console.ReadLine());
    string[] answers = new string[loopTimes];

    for(int i = 0; i < loopTimes; i++) {
      string[] input = Console.ReadLine().Split(' ');
      int populationA = int.Parse(input[0]);
      int populationB = int.Parse(input[1]);
      double growthA = double.Parse(input[2]) / 100;
      double growthB = double.Parse(input[3]) / 100;

      int years;

      for(years = 1; populationA <= populationB && years <= 100; years++) {
        populationA += (int)Math.Floor(populationA * growthA);
        populationB += (int)Math.Floor(populationB * growthB);
      }

      answers[i] = populationA <= populationB ? "Mais de 1 seculo." : $"{years - 1} anos.";
    }

    foreach(string answer in answers) Console.WriteLine(answer);
  } 
}
