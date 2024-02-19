using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<int> list = new List<int>();
    while(true) {
      int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

      if(n[0] == 0 && n[1] == 0) break;

      list.Add(n[0] * n[1]);
    }
    foreach(int i in list) {
      Console.WriteLine(i);
    }
  }

}