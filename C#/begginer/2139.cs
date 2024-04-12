using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
        List<string> answers = new List<string>();
        
        string input;
        while((input = Console.ReadLine()) != null) {
            int[] nums = Array.ConvertAll(input.Split(' '), int.Parse);
            int countDays = nums[1], christimas = 360;
            
            if(nums[0] == 12 && nums[1] == 25) {
                answers.Add("E natal!");
                continue;
            } else if(nums[0] == 12 && nums[1] == 24) {
                answers.Add("E vespera de natal!");
                continue;
            } else if(nums[0] == 12 && nums[1] > 25) {
                answers.Add("Ja passou!");
                continue;
            }
            
            for(int i = 1; i < nums[0]; i++) {
                if(i < 8) {
                    if(i == 2) countDays += 29;
                    else if(i % 2 != 0) countDays += 31;
                    else countDays += 30;
                } else {
                    if(i % 2 == 0) countDays += 31;
                    else countDays += 30;
                }
            }
            
            int diff = christimas - countDays;
            
            answers.Add($"Faltam {diff} dias para o natal!");
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
