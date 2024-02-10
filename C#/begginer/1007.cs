using System; 

class URI {

    static void Main(string[] args) { 

        int[] n = new int[4];

        for(int i = 0; i < 4; i++) {
            n[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"DIFERENCA = {n[0] * n[1] - n[2] * n[3]}");

    }

}