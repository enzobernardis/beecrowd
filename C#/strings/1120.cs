using System;
using System.Collections.Generic;

class URI {
  static void Main(string[] args) {
    List<string> answers = new List<string>();
    while(true) {
      string[] input = Console.ReadLine().Split(' ');

      if(input[0] == "0" && input[1] == "0") break;

      string typedKeys = input[1];
      string withoutBrokenKeys = typedKeys.Replace(input[0], "");
      string filteredTypedKeys = "";

      for(int i = 0; i < withoutBrokenKeys.Length; i++) {
        if(withoutBrokenKeys[i] == '0') continue;
        else {
          for(int j = i; j < withoutBrokenKeys.Length; j++) {
            filteredTypedKeys += withoutBrokenKeys[j];
          }
          break;
        }
      }

      if(filteredTypedKeys == "") filteredTypedKeys = "0";

      answers.Add(filteredTypedKeys);
    }
    foreach(string answer in answers) {
      Console.WriteLine(answer);
    }
  }
}