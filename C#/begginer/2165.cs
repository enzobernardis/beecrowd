using System; 

class URI {

    static void Main(string[] args) { 
        char[] input = Console.ReadLine().ToCharArray();
        string answer = input.Length <= 140 ? "TWEET" : "MUTE";
        Console.WriteLine(answer);
    }

}
