using System; 

class URI {

  static void Main(string[] args) {
    int[] grams = { 300, 1500, 600, 1000, 150 };

    int[] portions = new int[5];
    for(int i = 0; i < 5; i++) {
      portions[i] = int.Parse(Console.ReadLine());
    }

    int totalGrams = 225;

    for(int i = 0; i < 5; i++) {
      totalGrams += grams[i] * portions[i];
    }

    Console.WriteLine(totalGrams);
  }

}