using System; 

class URI {

    static void Main(string[] args) { 
        int input = int.Parse(Console.ReadLine());
        string quote = "LIFE IS NOT A PROBLEM TO BE SOLVED";
        
        for(int i = 0; i < input; i++) {
            Console.Write(quote[i]);
        }
        
        Console.WriteLine();
    }

}
