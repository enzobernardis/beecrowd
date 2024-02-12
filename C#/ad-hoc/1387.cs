using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) { 
    List<int> list = new List<int>();
    do {
      string[] input = Console.ReadLine().Split(' ');
      int l = int.Parse(input[0]);
      int r = int.Parse(input[1]);

      if (l == 0 && r == 0) {
        break;
      } else {
        list.Add(l + r);
      }
    } while(true);
    foreach (int i in list) {
      Console.WriteLine(i);
    }
  }

}