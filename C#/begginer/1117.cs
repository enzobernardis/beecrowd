using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) {
        List<string> answers = new List<string>();
        double[] nums = new double[2];
        int count = 0;
        while(true) {
            if(count < 2) {
                double input = double.Parse(Console.ReadLine());
                
                if(input >= 0 && input <= 10) {
                    nums[count] = input;
                    count++;
                } else {
                    answers.Add("nota invalida");
                }
            } else {
                answers.Add("media = " + (nums[0] + nums[1]) / 2);
                foreach(string answer in answers) {
                    Console.WriteLine(answer);
                }
                break;
            }
        }
    }

}
