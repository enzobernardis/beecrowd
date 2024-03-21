using System; 

class URI {

    static void Main(string[] args) { 
        int i = 1, j = 7;
        
        while(true) {
            if(j < 5) {
                j = 7;
                i += 2;
                if(i > 9) break;
            }
            Console.WriteLine($"I={i} J={j}");
            j--;
        }
    }

}
