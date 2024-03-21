using System;

class URI {

  static void Main(string[] args) {
    bool repeat = true;
    int i = 1, j = 60;

    while(repeat) {
      Console.WriteLine($"I={i} J={j}");
      if(j == 0) repeat = false;
      i+=3; 
      j-=5;
    }
  }
}
