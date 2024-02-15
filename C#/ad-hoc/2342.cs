using System; 

class URI {

  static void Main(string[] args) { 
    int max = int.Parse(Console.ReadLine());
    string[] input = Console.ReadLine().Split(' ');

    int a = int.Parse(input[0]);
    string n = input[1];
    int b = int.Parse(input[2]);

    int result;

    if(n == "+") {
      result = a + b;
    } else {
      result = a * b;
    }

    if(result > max){
      Console.WriteLine("OVERFLOW");
    } else {
      Console.WriteLine("OK");
    }
  }

}
