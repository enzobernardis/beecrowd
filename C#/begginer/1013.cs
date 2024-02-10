using System; 

class URI {

    static void Main(string[] args) { 

        string[] input = Console.ReadLine().Split(' ');

        int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);

        if(c > b) {
            b = c;
        }

        int greatestAB = (a+b+Math.Abs(a-b)) / 2;

        Console.WriteLine($"{greatestAB} eh o maior");

    }

}