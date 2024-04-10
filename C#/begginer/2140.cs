using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) {
        List<string> answers = new List<string>();
        int[] bills = { 2, 5, 10, 20, 50, 100 };
        
        while(true) {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            if(numbers[0] == 0 && numbers[1] == 0) break;
            
            string possible = "impossible";
            
            for(int i = 0; i < bills.Length; i++) {
                for(int j = 0; j < bills.Length; j++) {
                    if(i == j) continue;
                    
                    if(numbers[1] - (bills[i] + bills[j]) == numbers[0]) possible = "possible";
                }
            } 
            
            answers.Add(possible);
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
