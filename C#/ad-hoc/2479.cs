using System; 

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());

    string[] names = new string[n];
    string[] behavior = new string[n];
    
    for(int i = 0; i < n; i++) {
      string[] input = Console.ReadLine().Split(' ');
      behavior[i] = input[0];
      names[i] = input[1];
    }

    int goodBehavior = 0;

    foreach(string b in behavior) {
      if(b == "+") {
        goodBehavior++;
      }
    }

    Array.Sort(names);

    foreach(string name in names) {
      Console.WriteLine(name);
    }

    Console.WriteLine($"Se comportaram: {goodBehavior} | Nao se comportaram: {n - goodBehavior}");
  }

}