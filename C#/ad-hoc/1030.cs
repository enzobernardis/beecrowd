using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    int i = int.Parse(Console.ReadLine());
    string[] caseText = new string[i];

    for(int j = 0; j < i; j++) {
      List<int> list = new List<int>();
      string[] input = Console.ReadLine().Split(' ');
      int n = int.Parse(input[0]);
      int k = int.Parse(input[1]);
      int atual = 0;

      for(int l = 0; l < n; l++) {
        list.Add(l);
      }

      while(list.Count != 1) {
        atual = (atual + k - 1) % list.Count;
        list.RemoveAt(atual);
      }

      caseText[j] = "Case " + (j + 1) + ": " + (list[0] + 1);
    }

    foreach(string s in caseText) {
      Console.WriteLine(s);
    }
    
  }

}