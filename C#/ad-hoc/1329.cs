using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) { 
    List<string> list = new List<string>();
    while(true) {
      int n = int.Parse(Console.ReadLine());
      if(n == 0) break;

      string[] input = Console.ReadLine().Split(' ');
      int[] num = Array.ConvertAll(input, int.Parse);

      int a = 0, b = 0;

      for(int i = 0; i < n; i++) {
        if(num[i] == 0) {
          a++;
        } else {
          b++;
        }
      }

      list.Add($"Mary won {a} times and John won {b} times");
    }

    foreach(string s in list) {
      Console.WriteLine(s);
    }
  }

}