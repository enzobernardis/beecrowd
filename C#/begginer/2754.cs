using System; 

class URI {

    static void Main(string[] args) { 
        double num1 = 234.345, num2 = 45.698;
        
        Console.WriteLine($"{num1:F6} - {num2:F6}");
        Console.WriteLine($"{num1:F0} - {num2:F0}");
        Console.WriteLine($"{num1:F1} - {num2:F1}");
        Console.WriteLine($"{num1 - 0.005:F2} - {num2:F2}");
        Console.WriteLine($"{num1:F3} - {num2:F3}");
        Console.WriteLine($"{num1:0.000000e+00} - {num2:0.000000e+00}");
        Console.WriteLine($"{num1:0.000000E+00} - {num2:0.000000E+00}");
        Console.WriteLine($"{num1:F3} - {num2:F3}");
        Console.WriteLine($"{num1:F3} - {num2:F3}");
    }

}
