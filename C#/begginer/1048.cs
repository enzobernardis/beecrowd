using System; 

class URI {

  static void Main(string[] args) { 
    double salary = double.Parse(Console.ReadLine());
    double[] range =  { 0, 400, 800, 1200, 2000 };
    double[] percent = { 0.15, 0.12, 0.10, 0.07, 0.04 };
    double newSalary = 0;
    
    if(salary > 2000) {
      newSalary = salary * (1 + percent[4]);
      Console.WriteLine($"Novo salario: {newSalary:F2}");
      Console.WriteLine($"Reajuste ganho: {newSalary - salary:F2}");
      Console.WriteLine($"Em percentual: {percent[4] * 100:F0} %");
    } else {
      for(int i = 0; i < range.Length - 1; i++) {
        if(salary > range[i] && salary <= range[i + 1]) {
          newSalary = salary * (1 + percent[i]);
          Console.WriteLine($"Novo salario: {newSalary:F2}");
          Console.WriteLine($"Reajuste ganho: {newSalary - salary:F2}");
          Console.WriteLine($"Em percentual: {percent[i] * 100:F0} %");
          break;
        }
      }
    }
  }
}
