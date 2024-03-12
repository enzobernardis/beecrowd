using System; 

class URI {

    static void Main(string[] args) { 
        int loopTimes = int.Parse(Console.ReadLine());
        double[] answers = new double[loopTimes];
        
        for(int i = 0; i < loopTimes; i++) {
            double[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            
            answers[i] = (nums[0] * 2 + nums[1] * 3 + nums[2] * 5) / (2 + 3 + 5);
        }
        
        foreach(double answer in answers) {
            Console.WriteLine($"{answer:F1}");
        }
    }

}
