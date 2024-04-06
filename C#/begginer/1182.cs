using System; 

class URI {

    static void Main(string[] args) { 
        double[,] grid = new double[12, 12];
        int line = int.Parse(Console.ReadLine());
        string operation = Console.ReadLine();
        double sum = 0.0;
        
        for(int x = 0; x < 12; x++) {
            for(int y = 0; y < 12; y++) {
                grid[x, y] = double.Parse(Console.ReadLine());
            }
        }
        
        for(int i = 0; i < 12; i++) sum += grid[i, line];
        
        if(operation != "S") sum /= 12.0;
        
        Console.WriteLine(sum.ToString("F1"));
        
    }

}
