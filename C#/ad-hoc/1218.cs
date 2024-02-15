using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) { 
    string n;
    int time = 1;;
    List<string> list = new List<string>();
    while((n = Console.ReadLine()) != null) {
      
      string[] options = Console.ReadLine().Split(' ');

      int equal = 0;
      int fem = 0;
      int masc = 0;

      for(int i = 0; i < options.Length; i++) {
        if(options[i] == n) {
          equal++;
          if(options[i + 1] == "F") {
            fem++;
          } else {
            masc++;
          }
        }
      }

      list.Add($"Caso {time}:\nPares Iguais: {equal}\nF: {fem}\nM: {masc}");
      time++;
    }

    for(int j = 0; j < list.Count; j++) {
      Console.WriteLine(list[j]);
      if(j < list.Count - 1) {
        Console.WriteLine();
      }
    }
  }

}