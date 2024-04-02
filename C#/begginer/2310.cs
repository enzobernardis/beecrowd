using System; 

class URI {

    static void Main(string[] args) { 
        int loopTimes = int.Parse(Console.ReadLine());
        int[] attempts = { 0, 0, 0}, scored = { 0, 0, 0 };
        
        for(int i = 0; i < loopTimes; i++) {
            Console.ReadLine();
            int[] firstInput = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int j = 0; j < 3; j++) attempts[j] += firstInput[j];
            int[] secondInput = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int j = 0; j < 3; j++) scored[j] += secondInput[j];
        }
        
        Console.WriteLine($"Pontos de Saque: {(scored[0] / (attempts[0] * 1.0)) * 100:F2} %.");
        Console.WriteLine($"Pontos de Bloqueio: {(scored[1] / (attempts[1] * 1.0)) * 100:F2} %.");
        Console.WriteLine($"Pontos de Ataque: {(scored[2] / (attempts[2] * 1.0)) * 100:F2} %.");
    }

}
