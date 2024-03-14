using System; 
using System.Collections.Generic;

class URI {

  static void Main(string[] args) {
    List<string> list = new List<string>();
    while(true) {
      int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

      if(nums[0] == nums[1]) break;

      if(nums[0] > nums[1]) list.Add("Decrescente");
      else list.Add("Crescente");
    }

    foreach(string s in list) Console.WriteLine(s);
  }

}
