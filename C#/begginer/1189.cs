using System; 

class URI {

    static void Main(string[] args) { 
        double[,] grid = new double[12, 12];
        string operation = Console.ReadLine();
        
        for(int y = 0; y < 12; y++) {
            for(int x = 0; x < 12; x++) grid[x, y] = double.Parse(Console.ReadLine());
        }
        
        double sum = 0.0;
        int yBegin = 1, numOfNumbers = 0;
        
        for(int x = 0; x < 5; x++) {
            for(int y = yBegin; y < 12 - yBegin; y++) { 
                sum += grid[x, y];
                numOfNumbers++;
            }
            yBegin++;
        }
        
        if(operation != "S") sum = sum / numOfNumbers;
        
        Console.WriteLine(sum.ToString("F1"));
    }

}
