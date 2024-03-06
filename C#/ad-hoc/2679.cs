using System; 

class URI {

    static void Main(string[] args) { 
        int input = int.Parse(Console.ReadLine());
        
        do {
            input++;
        } while(input % 2 != 0);
        
        Console.WriteLine(input);
    }

}
