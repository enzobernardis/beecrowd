using System;

class URI {

  static void Main(string[] args) {
    int i = 1, j = 7, lastJ = 7;
    while(true) {
      if(j == lastJ - 3) {
        i += 2;
        j = lastJ + 2;
        lastJ = j;
      }
      if(i > 9) break;
      Console.WriteLine($"I={i} J={j}");
      j--;
    }
  }
}
