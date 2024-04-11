using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 
        int loopTimes = int.Parse(Console.ReadLine());
        string[] codes = new string[loopTimes];
        double[] notes = new double[loopTimes];
        
        for(int i = 0; i < loopTimes; i++) {
            string[] inputs = Console.ReadLine().Split();
            codes[i] = inputs[0];
            notes[i] = double.Parse(inputs[1]);
        }
        
        double biggestNote = notes.Max();
        int index = Array.IndexOf(notes, biggestNote);
        
        string answer = biggestNote < 8 ? "Minimum note not reached" : codes[index];
        
        Console.WriteLine(answer);
    }
    

}
