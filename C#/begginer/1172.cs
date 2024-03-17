using System;

class URI {

  static void Main(string[] args) {
    int[] array = new int[10];

    for(int i = 0; i < array.Length; i++) {
      int number = int.Parse(Console.ReadLine());
      array[i] = number > 0 ? number : 1;
    }

    for(int i = 0; i < array.Length; i++) Console.WriteLine($"X[{i}] = {array[i]}");
  }
}
