using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
        List<int> answers = new List<int>();
        string input;
        
        while((input = Console.ReadLine()) != null) {
            int password = int.Parse(input);
            answers.Add(password);
        }
        
        foreach(int answer in answers) Console.WriteLine(answer - 1);
    }

}
