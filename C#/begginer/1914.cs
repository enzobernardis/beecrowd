using System;

class URI {

  static void Main(string[] args) {
    int loopTimes = int.Parse(Console.ReadLine());
    string[] answers = new string[loopTimes];

    for(int i = 0; i < loopTimes; i++) {
      string[] firstInput = Console.ReadLine().Split(' ');
      int[] choosedNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

      int sum = choosedNumbers[0] + choosedNumbers[1];

      if(sum % 2 == 0) answers[i] = firstInput[Array.IndexOf(firstInput, "PAR") - 1];
      else answers[i] = firstInput[Array.IndexOf(firstInput, "IMPAR") - 1];
    }

    foreach(string answer in answers) Console.WriteLine(answer);
  } 
}
