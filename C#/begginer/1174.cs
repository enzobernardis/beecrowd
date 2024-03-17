using System;

class URI {

  static void Main(string[] args) {
    double[] array = new double[100];

    for(int i = 0; i < 100; i++) array[i] = double.Parse(Console.ReadLine());
    
    for(int i = 0; i < 100; i++) if(array[i] <= 10) Console.WriteLine($"A[{i}] = {array[i]:F1}");
  }
}
