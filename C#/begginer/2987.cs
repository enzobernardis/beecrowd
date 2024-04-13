using System; 

class URI {

    static void Main(string[] args) { 
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string input = Console.ReadLine();
        
        Console.WriteLine(Array.IndexOf(alphabet, input) + 1);
    }

}
