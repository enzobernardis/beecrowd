using System; 

class URI {

    static void Main(string[] args) { 
        int n = int.Parse(Console.ReadLine()), points = 1;
        int[] interval = { 0, 800, 1400, 2000 };
        
        for(int i = 1; i < 4; i++) {
            if(n > interval[i - 1] && n <= interval[i]) {
                points = i;
                break;
            }
        }
        
        Console.WriteLine(points);
    }

}
