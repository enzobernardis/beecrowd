using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

  static void Main(string[] args) {
    List<int> list = new List<int>();
    while(true) {
      int n = int.Parse(Console.ReadLine());

      if(n == 0) break;

      string[] input = Console.ReadLine().Split(' ');
      int[] inputInt = Array.ConvertAll(input, int.Parse);

      int first = inputInt.Max();
      int second = inputInt.Where(x => x != first).Max();

      int j = 0;
      while(j < n) {
        if(inputInt[j] == second) {
          break;
        }
        j++;
      }
      list.Add(j + 1);
    }
    foreach(int i in list) {
      Console.WriteLine(i);
    }
  }

}