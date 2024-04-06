using System; 

class URI {

    static void Main(string[] args) { 
        double[,] grid = new double[12, 12];
        string operation = Console.ReadLine();
        
        for(int y = 0; y < 12; y++) {
            for(int x = 0; x < 12; x++) grid[x, y] = double.Parse(Console.ReadLine());
        }
        
        double sum = 0.0;
        int xBegin = 5, numOfNumbers = 0;
        
        for(int y = 7; y < 12; y++) {
            for(int x = xBegin; x < 12 - xBegin; x++) { 
                sum += grid[x, y];
                numOfNumbers++;
            }
            xBegin--;
        }
        
        if(operation != "S") sum = sum / numOfNumbers;
        
        Console.WriteLine(sum.ToString("F1"));
    }

}
