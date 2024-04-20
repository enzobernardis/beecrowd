using System; 

class URI {

    static void Main(string[] args) { 
        string[] input = Console.ReadLine().Split('.');
        
        int num1 = int.Parse(input[0]), num2 = int.Parse(input[1]);
        
        Console.WriteLine($"{num2}.{num1}");
    }

}
