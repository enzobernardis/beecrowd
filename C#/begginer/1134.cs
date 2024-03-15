using System;

class URI {

  static void Main(string[] args) {
    int gasoline = 0, alcohol = 0, diesel = 0;
    bool loop = true;
    while(loop) {
      int input = int.Parse(Console.ReadLine());

      switch(input) {
      case 1:
        alcohol++;
        break;
      case 2:
        gasoline++;
        break;
      case 3:
        diesel++;
        break;
      case 4:
        loop = false;
        break;
      }
    }

    Console.WriteLine("MUITO OBRIGADO");
    Console.WriteLine("Alcool: " + alcohol);
    Console.WriteLine("Gasolina: " + gasoline);
    Console.WriteLine("Diesel: " + diesel);
  }

}
