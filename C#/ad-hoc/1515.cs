using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) { 
    List<string> response = new List<string>();
    while(true){
      int n = int.Parse(Console.ReadLine());

      if(n == 0) break;

      string[] name = new string[n];
      int[] year = new int[n];
      int[] travel = new int[n];


      for(int i = 0; i < n; i++) {
        string[] input = Console.ReadLine().Split(' ');
        name[i] = input[0];
        year[i] = int.Parse(input[1]);
        travel[i] = int.Parse(input[2]);
      }

      int first = year[0] - travel[0];
      string nameFirst = name[0];

      for(int j = 0; j < n; j++) {
        if(year[j] - travel[j] < first) {
          first = year[j] - travel[j];
          nameFirst = name[j];
        }
      }

      response.Add(nameFirst);

    } 

    foreach(string name in response) {
      Console.WriteLine(name);
    }

  }

}