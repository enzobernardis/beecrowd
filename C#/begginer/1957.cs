using System; 

class URI {

    static void Main(string[] args) { 
        int input = int.Parse(Console.ReadLine());
        string hexadecimal = input.ToString("X");
        Console.WriteLine(hexadecimal);
    }

}
