using System; 

class URI {

    static void Main(string[] args) { 
        string line;
        while((line = Console.ReadLine()) != null) {
            int number = int.Parse(line);
            
            if(number == 1) {
                Console.WriteLine(0);
            } else {
                for(int i = 0; i < number; i++) {
                    int result = (int)Math.Pow(2, i);
                    if(result == number) {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }

}
