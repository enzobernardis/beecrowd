using System; 

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int[] r = new int[n];

    for(int i = 0; i < n; i++) {
      string input = Console.ReadLine();
      int a = int.Parse(input[0].ToString());
      int b = int.Parse(input[2].ToString());
      char c = input[1];

      if(a == b) {
        r[i] = a * b;
      } else {
        if(char.IsUpper(c)) {
          r[i] = b - a;
        } else {
          r[i] = a + b;
        } 
      }
    }

    foreach(int i in r) {
      Console.WriteLine(i);
    } 
  }

}