using System;

class URI {

  static void Main(string[] args) {
    string[] inputStreet = Console.ReadLine().Split(' ');

    int street = int.Parse(inputStreet[0]);
    int toll = int.Parse(inputStreet[1]);

    string[] inputCar = Console.ReadLine().Split(' ');

    int costKm = int.Parse(inputCar[0]);
    int tollCost = int.Parse(inputCar[1]);

    int toPay = (street / toll) * tollCost + street * costKm;

    Console.WriteLine(toPay);
  }

}