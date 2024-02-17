using System; 

class URI {

    static void Main(string[] args) { 
        int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int a = n[0] * n[1];
        int b = n[2] * n[3];

        if(a == b) {
          Console.WriteLine(0);
        } else if(a > b) {
          Console.WriteLine(-1);
        } else {
          Console.WriteLine(1);
        }
      
    }

}