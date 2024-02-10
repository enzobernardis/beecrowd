using System;

class URI {

    static void Main(string[] args) { 

        string[] input1 = Console.ReadLine().Split(' ');

        int code1 = int.Parse(input1[0]);
        int units1 = int.Parse(input1[1]);
        double price1 = double.Parse(input1[2]);

        string[] input2 = Console.ReadLine().Split(' ');

        int code2 = int.Parse(input2[0]);
        int units2 = int.Parse(input2[1]);
        double price2 = double.Parse(input2[2]);

        double priceToPay = price1 * units1 + price2 * units2;

        Console.WriteLine($"VALOR A PAGAR: R$ {priceToPay:F2}");

    }

}