using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) { 
        List<string> answers = new List<string>();
        
        string input;
        while((input = Console.ReadLine()) != null) {
            int numOfPlayers = int.Parse(input);
            int[] votes = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            string result = votes.Sum() >= numOfPlayers / 3.0 * 2.0 ? "impeachment" : "acusacao arquivada";
            answers.Add(result);
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
        
    }

}
