using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
        List<string> answers = new List<string>();
        
        string input;
        while((input = Console.ReadLine()) != null) {
            int[] nums = Array.ConvertAll(input.Split(':'), int.Parse);

            int calc = ((nums[0] + 1) * 60) + nums[1] - 480;
            calc = calc > 0 ? calc : 0;
            
            answers.Add($"Atraso maximo: {calc}");
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
