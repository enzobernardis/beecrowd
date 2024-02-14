using System; 

class URI {

  static void Main(string[] args) {
    double[] n = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

    if(n[0] == 0 && n[1] == 0) {
      Console.WriteLine("Origem");
    } else if(n[0] > 0 && n[1] > 0) {
      Console.WriteLine("Q1");
    } else if(n[0] < 0 && n[1] > 0) {
      Console.WriteLine("Q2");
    } else if(n[0] < 0 && n[1] < 0) {
      Console.WriteLine("Q3");
    } else if(n[0] > 0 && n[1] < 0) {
      Console.WriteLine("Q4");
    } else if(n[0] == 0 && n[1] != 0) {
      Console.WriteLine("Eixo Y");
    } else if(n[0] != 0 && n[1] == 0) {
      Console.WriteLine("Eixo X");
    }
  }

}