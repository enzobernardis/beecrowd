using System; 

class URI {

    static void Main(string[] args) { 
        string input = Console.ReadLine();
        char[] conversionChar = input.ToCharArray();
        Array.Reverse(conversionChar);
        string reversedInput = new string(conversionChar);
        Console.WriteLine(reversedInput);
    }

}
