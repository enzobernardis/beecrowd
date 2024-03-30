using System; 

class URI {

    static void Main(string[] args) { 
        int numOfNumbers = int.Parse(Console.ReadLine());
        int[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] numCount = { 0, 0, 0, 0 };
        
        for(int i = 0; i < 4; i++) {
            for(int j = 0; j < numOfNumbers; j++) {
                if(inputNumbers[j] % (i + 2) == 0) numCount[i] += 1;
            }
        }
        
        for(int i = 0; i < 4; i++) Console.WriteLine($"{numCount[i]} Multiplo(s) de {i + 2}");
        
    }

}
