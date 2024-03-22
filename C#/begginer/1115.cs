using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) {
        List<string> answers = new List<string>();
        while(true) {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            if(numbers[0] == 0 || numbers[1] == 0) break;
            else if(numbers[0] > 0 && numbers[1] > 0) answers.Add("primeiro");
            else if(numbers[0] < 0 && numbers[1] > 0) answers.Add("segundo");
            else if(numbers[0] < 0 && numbers[1] < 0) answers.Add("terceiro");
            else if(numbers[0] > 0 && numbers[1] < 0) answers.Add("quarto");
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
