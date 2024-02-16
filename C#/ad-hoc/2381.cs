using System;
using System.Linq;

class URI {

  static void Main(string[] args) {
    string[] input = Console.ReadLine().Split(' ');
    int students = int.Parse(input[0]);
    int selected = int.Parse(input[1]);

    string[] nameStudents = new string[students];
    for(int i = 0; i < students; i++) {
      nameStudents[i] = Console.ReadLine();
    }
    var orderNames = nameStudents.OrderBy(x => x);

    Console.WriteLine(orderNames.ElementAt(selected - 1));
  }

}