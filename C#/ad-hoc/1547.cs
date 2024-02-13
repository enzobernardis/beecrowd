using System; 

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int[] v = new int[n];

    for(int i = 0; i < n; i++) {
      int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
      int[] answers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

      int close = int.MaxValue;
      int closeIndex = -1;

      for(int j = 0; j < answers.Length; j++) {
        if(answers[j] == input[1]) {
          v[i] = j + 1;
          break;
        } else {
          if(Math.Abs(answers[j] - input[1]) < close) {
            close = Math.Abs(answers[j] - input[1]);
            closeIndex = j + 1;
          }
        }
      }

      if(v[i] == 0) {
        v[i] = closeIndex;
      }

    }

    foreach(int k in v) {
      Console.WriteLine(k);
    }
  }

}