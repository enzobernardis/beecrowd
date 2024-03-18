using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
        List<string> answers = new List<string>();
        
        string input;
        while((input = Console.ReadLine()) != null) {
            int num = int.Parse(input);
            if(num > 0) answers.Add("vai ter duas!");
            else answers.Add("vai ter copa!");
        }
        
        foreach(string answer in answers) {
            Console.WriteLine(answer);
        }
    }

}
