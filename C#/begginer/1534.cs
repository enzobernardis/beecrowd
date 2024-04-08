using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
        List<string> answers = new List<string>();
        
        string input;
        while((input = Console.ReadLine()) != null) {
            int length = int.Parse(input);
            string line = "";
            
            for(int i = 0; i < length; i++) line += "3";
            for(int i = 0; i < length; i++) {
                char[] lineInChar = line.ToCharArray();
                lineInChar[i] = '1';
                lineInChar[(length - 1) - i] = '2';
                string newLine = new string(lineInChar);
                answers.Add(newLine);
            }
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
