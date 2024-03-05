import java.io.IOException;
import java.util.Scanner;
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        double[] price = { 4.00, 4.50, 5.00, 2.00, 1.50 };
        String[] input = scanner.nextLine().split(" ");
        
        int code = Integer.valueOf(input[0]).intValue();
        int quant = Integer.valueOf(input[1]).intValue();
        
        System.out.printf("Total: R$ %.2f\n", price[code - 1] * quant);
    }
 
}
