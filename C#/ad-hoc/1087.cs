using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<int> list = new List<int>();
    while(true) {
      int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

      if(n[0] == 0 && n[1] == 0 && n[2] == 0 && n[3] == 0) break;

      if(n[0] == n[2] && n[1] == n[3]) {
        list.Add(0);
      } else if ((n[0] == n[2] && n[1] != n[3]) || (n[0] != n[2] && n[1] == n[3]) || (n[0] + n[1] == n[2] + n[3]) || (n[0] - n[1] == n[2] - n[3])) {
        list.Add(1);
      } else {
        list.Add(2);
      }
    }

    foreach(int i in list) {
      Console.WriteLine(i);
    }
  }

}