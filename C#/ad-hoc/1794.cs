using System; 

class URI {

    static void Main(string[] args) { 
      int n = int.Parse(Console.ReadLine());
      int[] l = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
      int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
      int points = 0;

      if(l[0] <= n && l[1] >= n) {
        points++;
      } 
      if(s[0] <= n && s[1] >= n) {
        points++;
      }

      if(points == 2) {
        Console.WriteLine("possivel");
      } else {
        Console.WriteLine("impossivel");
      }

    }

}