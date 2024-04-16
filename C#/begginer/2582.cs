using System; 

class URI {

    static void Main(string[] args) {
        int loopTimes = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < loopTimes; i++) {
            string[] line = Console.ReadLine().Split(' ');
            int n1 = int.Parse(line[0]), n2 = int.Parse(line[1]);
            
            switch (n1 + n2)
            {
                case 0:
                    Console.WriteLine("PROXYCITY");
                    break;
                case 1:
                    Console.WriteLine("P.Y.N.G.");
                    break;
                case 2:
                    Console.WriteLine("DNSUEY!");
                    break;
                case 3:
                    Console.WriteLine("SERVERS");
                    break;
                case 4:
                    Console.WriteLine("HOST!");
                    break;
                case 5:
                    Console.WriteLine("CRIPTONIZE");
                    break;
                case 6:
                    Console.WriteLine("OFFLINE DAY");
                    break;
                case 7:
                    Console.WriteLine("SALT");
                    break;
                case 8:
                    Console.WriteLine("ANSWER!");
                    break;
                case 9:
                    Console.WriteLine("RAR?");
                    break;
                case 10:
                    Console.WriteLine("WIFI ANTENNAS");
                    break;
            }
        }
    }

}
