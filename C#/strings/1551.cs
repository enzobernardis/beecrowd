using System;
using System.Linq;
using System.Collections.Generic;

class URI {
  static void Main(string[] args) {
    int numInputs = int.Parse(Console.ReadLine());
    string[] answers = new string[numInputs];
    char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    for(int i = 0; i < numInputs; i++) {
      string phrase = Console.ReadLine();
      HashSet<char> uniqueLetters = new HashSet<char>();
      
      for(int j = 0; j < alphabet.Length; j++) {
        if(phrase.Any(x => x == alphabet[j])) uniqueLetters.Add(alphabet[j]);
      }

      if(uniqueLetters.Count ==  26) {
        answers[i] = "frase completa";
      } else if(uniqueLetters.Count >= 13) {
        answers[i] = "frase quase completa";
      } else {
        answers[i] = "frase mal elaborada";
      }
    }

    foreach(string answer in answers) {
      Console.WriteLine(answer);
    }
  }
}