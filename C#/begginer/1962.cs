using System; 

class URI {

    static void Main(string[] args) { 
        int loopTimes = int.Parse(Console.ReadLine());
        string[] answers = new string[loopTimes];
        
        for(int i = 0; i < loopTimes; i++) {
            int years = int.Parse(Console.ReadLine());
            int difference = 2015 - years;
            string when = difference > 0 ? "D.C." : "A.C.";
            difference = difference <= 0 ? difference - 1 : difference;
            difference = Math.Abs(difference);
            answers[i] = $"{difference} {when}";
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
