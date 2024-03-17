using System;

class URI {

  static void Main(string[] args) {
    //Input start
    int loopTimes = int.Parse(Console.ReadLine());
    string[] answers = new string[loopTimes];

    for(int i = 0; i < loopTimes; i++) {
      int number = int.Parse(Console.ReadLine());
      //Input end

      //Processing start
      bool isPrime = true;
      for(int j = 2; j < number; j++) if(number % j == 0) isPrime = false;

      if(isPrime) answers[i] = $"{number} eh primo";
      else answers[i] = $"{number} nao eh primo";
      //Processing end
    }
    
    //Output start
    foreach(string answer in answers) Console.WriteLine(answer);
    //Output end
  }
}
