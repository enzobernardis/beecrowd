using System; 

class URI {

  static void Main(string[] args) { 
    int loop1Times = int.Parse(Console.ReadLine());
    string[] answers = new string[loop1Times];

    for(int i = 0; i < loop1Times; i++) {
      int loop2Times = int.Parse(Console.ReadLine());
      string[] languagesSpoken = new string[loop2Times];

      for(int j = 0; j < loop2Times; j++) {
        languagesSpoken[j] = Console.ReadLine();
      }

      int count = 0;

      foreach(string language in languagesSpoken) {
        if(language == languagesSpoken[0]) count++;
      }

      if(count == languagesSpoken.Length) {
        answers[i] = languagesSpoken[0];
      } else {
        answers[i] = "ingles";
      }
    }

    foreach(string answer in answers) {
      Console.WriteLine(answer);
    }
  }

}