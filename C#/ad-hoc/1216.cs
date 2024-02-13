using System;
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<double> list = new List<double>();
    string input;

    while((input = Console.ReadLine()) != null) {
      list.Add(double.Parse(Console.ReadLine()));
    }

    double sum = 0.0;

    foreach(double n in list) {
      sum += n;
    }

    Console.WriteLine($"{sum / list.Count:F1}");
  }
}
