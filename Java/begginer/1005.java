import java.io.IOException;
import java.util.Scanner;
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        double num1 = scanner.nextDouble();
        double num2 = scanner.nextDouble();
        
        System.out.printf("MEDIA = %.5f\n", (num1 * 3.5 + num2 * 7.5) / (3.5 + 7.5));
    }
 
}
