using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());

        int year = n / 365;
        n -= year * 365;
        int month = n / 30;
        n -= month * 30;
        int day = n;

        Console.WriteLine($"{year} ano(s)");
        Console.WriteLine($"{month} mes(es)");
        Console.WriteLine($"{day} dia(s)");

    }

}