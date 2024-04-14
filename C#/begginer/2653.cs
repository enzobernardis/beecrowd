using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
        HashSet<string> lines = new HashSet<string>();
        
        string input;
        while((input = Console.ReadLine()) != null) {
            lines.Add(input);
        }
        
        Console.WriteLine(lines.Count);
    }

}
