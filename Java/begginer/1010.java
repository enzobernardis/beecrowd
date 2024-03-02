import java.io.IOException;
import java.util.Scanner;
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        double toPay = 0.0;
        
        for(int i = 0; i < 2; i++) {
            String[] input = scanner.nextLine().split(" ");
            
            int numOfPurchased = Integer.valueOf(input[1]).intValue();
            double price = Double.valueOf(input[2]).doubleValue();
            
            toPay += numOfPurchased * price;
        }
        
        System.out.printf("VALOR A PAGAR: R$ %.2f\n", toPay);
    }
 
}
