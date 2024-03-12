using System; 

class URI {

  static void Main(string[] args) { 
    int loopTimes = int.Parse(Console.ReadLine());
    string[] answers = new string[loopTimes];

    for(int i = 0; i < loopTimes; i++) {
      int input = int.Parse(Console.ReadLine());

      if(input == 0) answers[i] = "NULL";
      else {
        if(input % 2 == 0) answers[i] = "EVEN";
        else answers[i] = "ODD";

        if(input > 0) answers[i] += " POSITIVE";
        else answers[i] += " NEGATIVE";
      }
    }

    foreach(string answer in answers) {
      Console.WriteLine(answer);
    }

  }

}
