using System;

class URI {

  static void Main(string[] args) {
    int input = int.Parse(Console.ReadLine());
    int[] fibonacci = new int[input];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    string line = "0 1";
    
    for(int i = 2; i < input; i++) {
      fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
      line += " " + fibonacci[i];
    }

    Console.WriteLine(line);
  }
}
