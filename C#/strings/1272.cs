using System; 

class URI {

  static void Main(string[] args) { 
    int n = int.Parse(Console.ReadLine());
    string[] answers = new string[n];

    for(int i = 0; i < n; i++) {
      string input = Console.ReadLine();
      string[] split = input.Split(' ');

      for(int j = 0; j < split.Length; j++) {
        if (!string.IsNullOrEmpty(split[j])) {
          answers[i] += split[j][0];
        } else {
          answers[i] += "";
        }
      }
    }

    foreach(string i in answers) {
      Console.WriteLine(i);
    }
    
  }

}