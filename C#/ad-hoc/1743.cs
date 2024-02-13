using System; 

class URI {

  static void Main(string[] args) { 
    int[] n1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int[] n2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    string response = "Y";

    for(int i = 0; i < 5; i++) {
      if(n1[i] == n2[i]) {
        response = "N";
        break;
      }
    }

    Console.WriteLine(response);
  }

}