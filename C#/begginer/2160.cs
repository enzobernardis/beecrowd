using System; 

class URI {

    static void Main(string[] args) { 
        char[] charArr = Console.ReadLine().ToCharArray();
        
        string answer = charArr.Length <= 80 ? "YES" : "NO";
        Console.WriteLine(answer);
    }

}
