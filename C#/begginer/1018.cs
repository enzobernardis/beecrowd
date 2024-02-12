using System; 

class URI {

    static void Main(string[] args) { 

        int i = 0, n = int.Parse(Console.ReadLine());
        int[] banknotes = { 100, 50, 20, 10, 5, 2, 1 };

        int[] count = { 0, 0, 0, 0, 0, 0, 0};

        Console.WriteLine(n);

        while(n > 0) {

            while(n < banknotes[i]) {
                i++;
            }


            switch(i) {
                case 0:
                    n -= banknotes[i];
                    count[i]++;
                break;
                case 1:
                    n -= banknotes[i];
                    count[i]++;
                break;
                case 2:
                    n -= banknotes[i];
                    count[i]++;
                break;
                case 3:
                    n -= banknotes[i];
                    count[i]++;
                break;
                case 4:
                    n -= banknotes[i];
                    count[i]++;
                break;
                case 5:
                    n -= banknotes[i];
                    count[i]++;
                break;
                case 6:
                    n -= banknotes[i];
                    count[i]++;
                break;
            }

        }

        for(int j = 0; j < 7; j++) {
            Console.WriteLine($"{count[j]} nota(s) de R$ {banknotes[j]},00");
        }

    }

}