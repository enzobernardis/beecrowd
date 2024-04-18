using System; 

class URI {

    static void Main(string[] args) { 
        char[] abc = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        
        for(int i = 0; i < 26; i++) {
            Console.WriteLine($"{i + 97} e {abc[i]}");
        }
    }

}
