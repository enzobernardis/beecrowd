using System; 

class URI {

    static void Main(string[] args) { 
        int loopTimes = int.Parse(Console.ReadLine());
        string[] answers = new string[loopTimes];
        
        for(int i = 0; i < loopTimes; i++) {
            int bonus = int.Parse(Console.ReadLine());
            
            int[] dabriel = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            double valueDabriel = (dabriel[0] + dabriel[1]) / 2.0;
            
            int[] guarte = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            double valueGuarte = (guarte[0] + guarte[1]) / 2.0;
            
            if(dabriel[2] % 2 == 0) valueDabriel += bonus;
            if(guarte[2] % 2 == 0) valueGuarte += bonus;
            
            if(valueDabriel > valueGuarte) answers[i] = "Dabriel";
            else if(valueDabriel < valueGuarte) answers[i] = "Guarte";
            else answers[i] = "Empate";
        }
        
        foreach(string answer in answers) Console.WriteLine(answer);
    }

}
