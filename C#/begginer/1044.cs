using System; 

class URI {

    static void Main(string[] args) { 
        int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        string answer = (n[1] % n[0] == 0 || n[0] % n[1] == 0) ? "Sao Multiplos" : "Nao sao Multiplos";
        
        Console.WriteLine(answer);
    }

}
