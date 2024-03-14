using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) {
        List<string> answers = new List<string>();
        while(true) {
            int password = int.Parse(Console.ReadLine());
            if(password == 2002) {
                answers.Add("Acesso Permitido");
                break;
            } else answers.Add("Senha Invalida");
        }
        
        foreach(string answer in answers) {
            Console.WriteLine(answer);
        }
    }

}
