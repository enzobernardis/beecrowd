using System; 
using System.Collections.Generic; 

class URI {

  static void Main(string[] args) {
    List<int> list = new List<int>();
    do {
      string[] input = Console.ReadLine().Split(' ');
      int[] n = Array.ConvertAll(input, int.Parse);

      if (n[0] == 0 && n[1] == 0) break;

      Array.Sort(n);

      int c = n[0] - (n[1] - n[0]);

      list.Add(c);

    } while(true);

    foreach(int i in list) {
      Console.WriteLine(i);
    }
  } 

}