using System; 

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    string[] gradesUK = { "E", "D", "C", "B", "A" };
    int[] gradesBR = { 0, 35, 60, 85, 100 };
    int lastGrade = 0;
    for(int i = 0; i < gradesBR.Length; i++) {
      if(n >= lastGrade && n <= gradesBR[i]) {
        Console.WriteLine(gradesUK[i]);
        break;
      }
      lastGrade = gradesBR[i] + 1;
    }

  }

}