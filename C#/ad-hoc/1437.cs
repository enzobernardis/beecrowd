using System; 

class URI {

   static void Main(string[] args) {
      while (true) {
         int n = int.Parse(Console.ReadLine());

         if (n == 0) break;

         string input = Console.ReadLine();
         int count = 0;

         foreach (char direction in input) {
            if (direction == 'D') {
               count++;
            } else {
               count--;
            }
         }

         count = (count % 4 + 4) % 4;

         switch (count % 4) {
            case 0:
               Console.WriteLine("N");
               break;
            case 1:
               Console.WriteLine("L");
               break;
            case 2:
               Console.WriteLine("S");
               break;
            case 3:
               Console.WriteLine("O");
               break;
         }
      }
   }

}