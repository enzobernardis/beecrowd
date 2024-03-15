using System;

class URI {

  static void Main(string[] args) {
    int begin = int.Parse(Console.ReadLine());
    int final = int.Parse(Console.ReadLine());
    int sum = 0;

    if(final < begin) {
      int temp = begin;
      begin = final;
      final = temp;
    }
    
    for(int i = begin; i <= final; i++) {
      if(i % 13 == 0) continue;
      sum += i;
    }

    Console.WriteLine(sum);
  }

}
