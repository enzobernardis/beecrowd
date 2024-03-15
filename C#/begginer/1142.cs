using System;

class URI {

  static void Main(string[] args) {
    int loopTimes = int.Parse(Console.ReadLine()), count = 1, limit = 3;

    for(int i = 0; i < loopTimes; i++) {
      for(int j = count; j <= limit; j++) {
        Console.Write(j + " ");
        count++;
      }
      Console.WriteLine("PUM");
      limit += 4;
      count++;
    }
  }

}
