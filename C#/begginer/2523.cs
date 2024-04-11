using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
        List<string> answers = new List<string>();
        
        string input;
        while((input = Console.ReadLine()) != null) {
            char[] alphabet = input.ToCharArray();
            int numOfLetters = int.Parse(Console.ReadLine());
            int[] letters = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string message = "";
            
            for(int i = 0; i < numOfLetters; i++) message += alphabet[letters[i] - 1];
            
            answers.Add(message);
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
