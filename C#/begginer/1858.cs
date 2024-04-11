using System; 

class URI {

    static void Main(string[] args) { 
        int numOfPersons = int.Parse(Console.ReadLine());
        int[] persons = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int position = 1, hitTimes = persons[0];
        
        for(int i = 1; i < numOfPersons; i++) {
            if(persons[i] < hitTimes) { 
                position = i + 1; 
                hitTimes = persons[i];
            }
        }
        
        Console.WriteLine(position);
    }

}
