using System; 

class URI {

    static void Main(string[] args) {
        int num = 0, index = 0;
        for(int i = 0; i < 100; i++) {
            int temp = int.Parse(Console.ReadLine());
            if(num <= temp) {
                num = temp;
                index = i;
            } 
        }
        
        Console.WriteLine(num);
        Console.WriteLine(index + 1);
    }

}
