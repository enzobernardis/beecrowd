using System;

class URI {

  static void Main(string[] args) {
    int sum = 0, count = 0;

    while(true) {
      int input = int.Parse(Console.ReadLine());
      if(input >= 0) {
        sum += input;
        count++;
      } else break;
    }
    Console.WriteLine($"{sum / (count * 1.0):F2}");

  }

}
