using System;

class URI {

  static void Main(string[] args) {
    //Input start
    int loopTimes = int.Parse(Console.ReadLine());
    string[] answers = new string[loopTimes];

    for(int i = 0; i < loopTimes; i++) {
      int number = int.Parse(Console.ReadLine());
      //Input end

      //Process start
      int sum = 0;

      for(int j = 1; j < number; j++) {
        if(number % j == 0) sum += j;
      }

      if(sum == number) answers[i] = $"{number} eh perfeito";
      else answers[i] = $"{number} nao eh perfeito";
      //Process end
    }
    
    //Output start
    foreach(string answer in answers) Console.WriteLine(answer);
    //Output end
  }
}
