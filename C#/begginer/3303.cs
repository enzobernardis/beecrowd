using System; 

class URI {

    static void Main(string[] args) { 
        string input = Console.ReadLine();
        string answer = input.Length >= 10 ? "palavrao" : "palavrinha";
        Console.WriteLine(answer);
    }

}
