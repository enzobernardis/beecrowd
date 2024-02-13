using System; 

class URI {

  static void Main(string[] args) { 
    int m = int.Parse(Console.ReadLine());
    int[] p = new int[m];
    for(int i = 0; i < m; i++) {
      int n = int.Parse(Console.ReadLine());
      int[] t = new int[n];

      for(int j = 0; j < n; j++) {
        string input = Console.ReadLine();

        if(input == "LEFT") {
          p[i]--;
          t[j] = -1;
        } else if(input == "RIGHT") {
          p[i]++;
          t[j] = 1;
        } else if(input.Contains("SAME AS")) {
          string[] inputSplit = input.Split(' ');
          int ith = int.Parse(inputSplit[2]);
          t[j] = t[ith - 1];
          p[i] = p[i] + t[j];
        }

      }
    }

    foreach(int i in p) {
      Console.WriteLine(i);
    }

  }

}