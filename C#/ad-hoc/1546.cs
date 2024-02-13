using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<string> list = new List<string>();
    int n = int.Parse(Console.ReadLine());

    for(int i = 0; i < n; i++) {
      int k = int.Parse(Console.ReadLine());

      for(int j = 0; j < k; j++) {
        switch(int.Parse(Console.ReadLine())) {
        case 1:
          list.Add("Rolien");
          break;
        case 2:
          list.Add("Naej");
          break;
        case 3:
          list.Add("Elehcim");
          break;
        case 4:
          list.Add("Odranoel");
          break;
        }
      }
    }

    foreach(string s in list) {
      Console.WriteLine(s);
    }
  }

}