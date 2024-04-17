using System; 

class URI {

    static void Main(string[] args) { 
        string[] abc = new string[3];
        
        for(int i = 0; i < 3; i++) abc[i] = Console.ReadLine();
        
        for(int i = 0; i < 3; i++) Console.WriteLine($"A = {abc[i % 3]}, B = {abc[(i + 1) % 3]}, C = {abc[(i + 2) % 3]}");
    }

}
