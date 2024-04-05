using System; 

class URI {

    static void Main(string[] args) { 
        int n = int.Parse(Console.ReadLine());
        string[] answers = new string[n];
        
        for(int i = 0; i < n; i++) {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string closed = input[2] == 1 ? "A porta abriu!" : "A porta fechou!";
            string zero = input[0] < 10 ? "0" : "";
            string zerotwo = input[1] < 10 ? "0" : "";
            answers[i] = $"{zero}{input[0]}:{zerotwo}{input[1]} - {closed}";
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
