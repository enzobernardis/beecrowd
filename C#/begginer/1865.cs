using System;

class URI {

  static void Main(string[] args) {
    int loopTimes = int.Parse(Console.ReadLine());
    string[] answers = new string[loopTimes];

    for(int i = 0; i < loopTimes; i++) {
      string[] input = Console.ReadLine().Split(' ');
      
      if(input[0] == "Thor") answers[i] = "Y";
      else answers[i] = "N";
    }

    foreach(string answer in answers) Console.WriteLine(answer);
  } 
}
