using System; 

class URI {

    static void Main(string[] args) {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        
        int answer = (num1 + num2) % 2 == 0 ? 1 : 0;
        Console.WriteLine(answer);
    }

}
