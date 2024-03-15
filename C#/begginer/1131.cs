using System;
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<string> answers = new List<string>();
    int againOrNo;
    int pointsInter = 0, pointsGremio = 0, pointsDraw = 0, grenais = 0;
    do {
      int[] points = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

      if(points[0] > points[1]) pointsInter++;
      else if(points[1] > points[0]) pointsGremio++;
      else pointsDraw++;

      answers.Add("Novo grenal (1-sim 2-nao)");
      againOrNo = int.Parse(Console.ReadLine());

      grenais++;
      
    } while(againOrNo != 2);

    foreach(string answer in answers) Console.WriteLine(answer);

    Console.WriteLine($"{grenais} grenais");
    Console.WriteLine($"Inter:{pointsInter}");
    Console.WriteLine($"Gremio:{pointsGremio}");
    Console.WriteLine($"Empates:{pointsDraw}");

    if(pointsInter > pointsGremio) Console.WriteLine("Inter venceu mais");
    else if(pointsGremio > pointsInter) Console.WriteLine("Gremio venceu mais");
    else Console.WriteLine("Nao houve vencedor");
  }

}
