using System; 

class URI {

    static void Main(string[] args) { 
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        int[] pipes = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        
        string answer = "YOU WIN";
        
        for(int i = 0; i < input[1] - 1; i++) {
            if(Math.Abs(pipes[i] - pipes[i + 1]) > input[0]) answer = "GAME OVER";
        }
        
        Console.WriteLine(answer);
    }

}
