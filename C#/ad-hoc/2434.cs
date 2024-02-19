using System; 

class URI {

  static void Main(string[] args) {
    int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int smallerBalance = n[1];

    for(int i = 0; i < n[0]; i++) {
      n[1] += int.Parse(Console.ReadLine());
      if(n[1] < smallerBalance) smallerBalance = n[1];
    }

    Console.WriteLine(smallerBalance);
  }

}