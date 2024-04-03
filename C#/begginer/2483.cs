using System; 

class URI {

    static void Main(string[] args) { 
        int numOfA = int.Parse(Console.ReadLine());
        string phrase = "Feliz nat";
        
        for(int i = 0; i < numOfA; i++) phrase += "a";
        
        Console.WriteLine(phrase + "l!");
    }

}
