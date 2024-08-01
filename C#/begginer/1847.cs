using System; 

class URI {

    static void Main(string[] args) { 
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int a = numbers[0], b = numbers[1], c = numbers[2];
        
        if((a == b && c > b) || (b < a && b-a < c-b) || (b > a && c-b >= b-a)) 
        {
            Console.WriteLine(":)");
        } else
        {
            Console.WriteLine(":(");
        }
    }

}
