using System;

class URI {

  static void Main(string[] args) {
    string[] dayInput1 = Console.ReadLine().Split(' ');
    int dayOne = int.Parse(dayInput1[1]);

    string[] hms1 = Console.ReadLine().Replace(" ", "").Split(':');
    int hourOne = int.Parse(hms1[0]), minuteOne = int.Parse(hms1[1]), secondOne = int.Parse(hms1[2]);

    string[] dayInput2 = Console.ReadLine().Split(' ');
    int lastDay = int.Parse(dayInput2[1]);

    string[] hms2 = Console.ReadLine().Replace(" ", "").Split(':');
    int lastHour = int.Parse(hms2[0]), lastMinute = int.Parse(hms2[1]), lastSecond = int.Parse(hms2[2]);

    int totalOne = (dayOne * 86400) + (hourOne * 3600) + (minuteOne * 60) + secondOne;
    int lastTotal = (lastDay * 86400) + (lastHour * 3600) + (lastMinute * 60) + lastSecond;

    int total = lastTotal - totalOne;

    Console.WriteLine($"{total / 86400} dia(s)");
    Console.WriteLine($"{(total % 86400) / 3600} hora(s)");
    Console.WriteLine($"{((total % 86400) % 3600) / 60} minuto(s)");
    Console.WriteLine($"{((total % 86400) % 3600) % 60} segundo(s)");
  }
}
