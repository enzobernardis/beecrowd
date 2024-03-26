using System; 

class URI {

    static void Main(string[] args) { 
        int loopTimes = int.Parse(Console.ReadLine()), s;
        int[] answers = new int[loopTimes];
        
        for(int i = 0; i < loopTimes; i++) {
            s = int.Parse(Console.ReadLine()) % 2;
            answers[i] = s;
        }
        
        foreach(int answer in answers) Console.WriteLine(answer);
    }

}
