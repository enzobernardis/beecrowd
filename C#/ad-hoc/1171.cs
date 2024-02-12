using System; 

class URI {

  static void Main(string[] args) { 
    int n = int.Parse(Console.ReadLine());
    int[] num = new int[n];
    
    for(int i = 0; i < n; i++) {
      num[i] = int.Parse(Console.ReadLine());
    }
    
    Array.Sort(num);

    int[] count = new int[n];
    int lastNum = -1;
    
    for(int j = 0; j < n; j++) {
      for(int k = 0; k < n; k++) {
        if(num[j] == num[k] && num[j] != lastNum) {
          count[j]++;
        } else {
          continue;
        }
      }
      lastNum = num[j];
    }

    int[] alreadyPrinted = new int[n];;
    
    for(int l = 0; l < n; l++) {
      if(!(Array.Exists(alreadyPrinted, element => element == num[l]))) {
        Console.WriteLine($"{num[l]} aparece {count[l]} vez(es)");
        alreadyPrinted[l] = num[l];
      } else { 
        continue;
      }
    }
  }
}
