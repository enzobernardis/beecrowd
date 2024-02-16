using System; 

class URI {

    static void Main(string[] args) {
        int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        if(n[0] == 0) {
            Console.WriteLine("C");
        } else {
            switch(n[1]) {
                case 0:
                    Console.WriteLine("B");
                    break;
                case 1:
                    Console.WriteLine("A");
                    break;
            }
        }
    }

}
