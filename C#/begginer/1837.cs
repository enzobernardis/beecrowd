using System; 

class URI {

    static void Main(string[] args) { 
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int q, r;
        
        if(a >= 0) {
            q = a / b;
            r = a % b;
        } else {
            int x = 0, y = 0;
            
            x = Math.Abs(b);
            
            for(r = 0; r < x; r++) {
                y = a - r;
                if(y % b == 0) break;
            }
            q = y / b;
        }
        
        Console.WriteLine($"{q} {r}");
    }

}
