using System; 

class URI {

    static void Main(string[] args) { 
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] inputInt = new int[n];
        
        for(int i = 0; i < n; i++) inputInt[i] = int.Parse(input[i]);
        
        int index = 0, smallestNumber = inputInt[0];
        for(int i = 0; i < n; i++) {
            if(smallestNumber > inputInt[i]) {
                smallestNumber = inputInt[i];
                index = i;
            }
        }
        
        Console.WriteLine("Menor valor: " + smallestNumber);
        Console.WriteLine("Posicao: " + index);
    }

}
