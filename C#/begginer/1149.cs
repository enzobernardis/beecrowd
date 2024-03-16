using System;

class URI {

  static void Main(string[] args) {
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    int[] AandN = new int[2];
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
      if(input[i] > 0) {
        AandN[count] += input[i];
        count++;
      }
      if(count == 2) break;
    }

    int sum = 0;
    
    for(int i = 0; i < AandN[1]; i++) {
      sum += AandN[0] + i;
    }

    Console.WriteLine(sum);

  }

}
