using System;

class URI {

  static void Main(string[] args) {
    int[] number = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    int hour1 = number[0] * 60, minute1 = number[1], hour2 = number[2] * 60, minute2 = number[3];
    int totalBegin = hour1 + minute1, totalEnd = hour2 + minute2;
    int timeSpan;

    if(totalBegin < totalEnd) timeSpan = totalEnd - totalBegin;
    else if(totalBegin == totalEnd) timeSpan = 24 * 60;
    else timeSpan = (24 * 60) - totalBegin + totalEnd;

    Console.WriteLine($"O JOGO DUROU {timeSpan / 60} HORA(S) E {timeSpan % 60} MINUTO(S)");
  }
}
