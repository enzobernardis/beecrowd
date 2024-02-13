using System; 

class URI {

  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int[] positions = { 100, 50, 25, 10, 5, 3, 1 };
    int realPosition = 100;

    for(int i = 0; i < positions.Length; i++) {
      if(positions[i] >= n) {
        realPosition = positions[i];
      }
    }

    Console.WriteLine("Top " + realPosition);
  }

}