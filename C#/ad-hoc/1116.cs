using System; 

class URI {

    static void Main(string[] args) { 
        int loopTimes = int.Parse(Console.ReadLine());
        string[] answers = new string[loopTimes];
        
        for(int i = 0; i < loopTimes; i++) {
            double[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            
            if(numbers[1] != 0) {
                double result = numbers[0] / numbers[1];
                answers[i] = $"{result:F1}";
            } else answers[i] = "divisao impossivel";
        }
        
        foreach(string answer in answers) {
            Console.WriteLine(answer);
        }
    }

}
