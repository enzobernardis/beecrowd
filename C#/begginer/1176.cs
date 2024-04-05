using System; 

class URI {

    static void Main(string[] args) { 
        long[] fib = new long[61];
        fib[0] = 0;
        fib[1] = 1;
        
        for(int i = 2; i < fib.Length; i++) fib[i] = fib[i - 1] + fib[i - 2];
        
        int loopTimes = int.Parse(Console.ReadLine());
        string[] answers = new string[loopTimes];
        
        for(int i = 0; i < loopTimes; i++) {
            int n = int.Parse(Console.ReadLine());
            answers[i] = $"Fib({n}) = {fib[n]}";
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
