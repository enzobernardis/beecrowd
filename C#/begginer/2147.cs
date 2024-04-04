using System; 

class URI {

    static void Main(string[] args) { 
        int loopTimes = int.Parse(Console.ReadLine());
        double[] answers = new double[loopTimes];
        
        for(int i = 0; i < loopTimes; i++) {
            string phrase = Console.ReadLine();
            answers[i] = phrase.Length / 100.0;
        }
        
        foreach(double answer in answers) Console.WriteLine($"{answer:F2}");
    }

}
