using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 
        int loopTimes = int.Parse(Console.ReadLine());
        string[] answers = new string[loopTimes];
        
        for(int i = 0; i < loopTimes; i++) {
            string name = Console.ReadLine();
            double mult = double.Parse(Console.ReadLine());
            double[] points = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            Array.Sort(points);
            points[points.Length - 1] = 0.0;
            points[0] = 0.0;
            double sum = points.Sum() * mult;
            answers[i] = $"{name} {sum:F2}";
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
