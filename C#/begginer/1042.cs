using System; 

class URI {

  static void Main(string[] args) {
    int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    int[] nSort = new int[3];

    Array.Copy(n, nSort, 3);
    Array.Sort(nSort);

    foreach(int i in nSort) {
      Console.WriteLine(i);
    }

    Console.WriteLine("");

    foreach(int j in n) {
      Console.WriteLine(j);
    }

  }

}