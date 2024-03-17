using System;

class URI {

  static void Main(string[] args) {
    int[] array = new int[20];

    for(int i = 0; i < 20; i++) array[i] = int.Parse(Console.ReadLine());

    Array.Reverse(array);

    for(int i = 0; i < 20; i++) Console.WriteLine($"N[{i}] = {array[i]}");
  }
}
