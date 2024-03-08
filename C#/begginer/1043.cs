using System; 

class URI {

    static void Main(string[] args) { 
        double[] input = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
        Array.Sort(input);
        
        if(input[2] < input[1] + input[0]) {
            Console.WriteLine($"Perimetro = {input[2] + input[1] + input[0]:F1}");
        } else {
            Console.WriteLine($"Area = {((input[2] + input[1])* input[0]) / 2:F1}");
        }
    }

}
