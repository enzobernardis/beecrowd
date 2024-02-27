using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) { 
    List<string> list = new List<string>();

    while(true) {
      int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
      if(input[0] == 0 && input[1] == 0) break;

      string answer = Convert.ToString(input[0] + input[1]);

      list.Add(answer.Replace("0", ""));
    }

    foreach(string i in list) {
      Console.WriteLine(i);
    }
  }

}