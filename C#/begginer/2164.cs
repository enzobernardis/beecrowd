using System; 

class URI {

    static void Main(string[] args) { 
        int n = int.Parse(Console.ReadLine());
        
        double fibonacci = (Math.Pow(((1 + Math.Sqrt(5)) / 2), n) - Math.Pow(((1 - Math.Sqrt(5)) / 2), n)) / Math.Sqrt(5);
        Console.WriteLine(fibonacci.ToString("F1"));
    }

}
