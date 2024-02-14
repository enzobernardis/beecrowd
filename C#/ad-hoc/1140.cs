using System; 
using System.Collections.Generic;

class Program {

  static void Main(string[] args) {
    List<string> list = new List<string>();
    while(true) {
      string[] input = Console.ReadLine().Split(' ');

      if(input[0] == "*") break;

      string firstCharString = input[0].ToLower();
      char firstChar = firstCharString[0];
      int points = 0;

      for (int i = 0; i < input.Length; i++){
        input[i] = input[i].ToLower();
        string element = input[i];
        if(element[0] == firstChar){
          points++;
        }
      }

      if(points == input.Length) {
        list.Add("Y");
      } else {
        list.Add("N");
      }
    }

    foreach(string i in list) {
      Console.WriteLine(i);
    }
  }
}