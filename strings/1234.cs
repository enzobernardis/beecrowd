using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<string> list = new List<string>();
    string input;
    while((input = Console.ReadLine()) != null) {
      int count = 0;
      string transformInput = "";
      for(int i = 0; i < input.Length; i++) {
        if(input[i] != ' ') {
          switch(count % 2) {
          case 0: 
            transformInput += input[i].ToString().ToUpper();
            break;
          case 1:
            transformInput += input[i].ToString().ToLower();
            break;
          }
          count++;
        } else {
          transformInput += " ";
        }
      }
      list.Add(transformInput);
    }

    foreach(string i in list) {
      Console.WriteLine(i);
    }
  }

}