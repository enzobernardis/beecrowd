using System;

class URI {

  static void Main(string[] args) {
    int begin = int.Parse(Console.ReadLine());
    int final = int.Parse(Console.ReadLine());

    if(final < begin) {
      int temp = begin;
      begin = final;
      final = temp;
    }
    
    for(int i = begin + 1; i <= final; i++) {
      if(i % 5 == 2 || i % 5 == 3) Console.WriteLine(i);
    }
  }

}
