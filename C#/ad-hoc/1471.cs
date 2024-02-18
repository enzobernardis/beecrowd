using System; 
using System.Linq;
using System.Collections.Generic;

class Program {

  static void Main(string[] args) { 
    List<string> list = new List<string>();
    string line;
    while ((line = Console.ReadLine()) != null) {
      int[] n = Array.ConvertAll(line.Split(' '), int.Parse);
      int[] diversComeback = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

      int[] allDivers = new int[n[0]];
      string response = "";

      for(int i = 1; i <= allDivers.Length; i++) {
        allDivers[i - 1] = i;
      }

      for(int i = 0; i < n[0]; i++) {
        if(!(diversComeback.Any(x => x == allDivers[i]))) {
          response += allDivers[i] + " ";
        }
      }

      if(response == "") {
        list.Add("*");
      } else {
        list.Add(response);
      }

    }

    foreach(string s in list) {
      Console.WriteLine(s);
    }
  }

}