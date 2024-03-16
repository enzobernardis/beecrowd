using System;

class URI {

  static void Main(string[] args) {
    int x = int.Parse(Console.ReadLine());
    int z;
    do {
      z = int.Parse(Console.ReadLine());
    } while(z <= x);

    int count = 0;
    for(int i = 1; i * x <= z; i++) count = i;

    Console.WriteLine(count);
  }

}
