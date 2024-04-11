using System; 

class URI {

    static void Main(string[] args) { 
        int lastMinutes = int.Parse(Console.ReadLine());
        int[] minutesForGifts = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        string answer = minutesForGifts[0] + minutesForGifts[1] > lastMinutes ? "Deixa para amanha!" : "Farei hoje!";
        Console.WriteLine(answer);
    }

}
