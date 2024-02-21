using System; 

class URI {

  static void Main(string[] args) {
    int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int time;
    
    if(n[0] > n[1]) {
      time = 24 - (n[0] - n[1]);
    } else if(n[0] < n[1]) {
      time = n[1] - n[0];
    } else {
      time = 24;
    }

    Console.WriteLine($"O JOGO DUROU {time} HORA(S)");
  }

}