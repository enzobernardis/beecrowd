using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
        List<string> answers = new List<string>();
        List<int> even = new List<int>();
        List<int> odd = new List<int>();
        
        for(int i = 0; i < 15; i++) {
            int number = int.Parse(Console.ReadLine());
            
            if(Math.Abs(number) % 2 == 0) even.Add(number);
            else odd.Add(number);
            
            if(even.Count == 5) {
                for(int j = 0; j < 5; j++) {
                    answers.Add($"par[{j}] = {even[j]}");
                }
                even.Clear();
            }
            if(odd.Count == 5) {
                for(int j = 0; j < 5; j++) {
                    answers.Add($"impar[{j}] = {odd[j]}");
                }
                odd.Clear();
            }
        }
        
        for(int i = 0; i < odd.Count; i++) answers.Add($"impar[{i}] = {odd[i]}");
        for(int i = 0; i < even.Count; i++) answers.Add($"par[{i}] = {even[i]}");
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
