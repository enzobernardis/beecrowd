import java.io.IOException;
import java.util.Scanner;
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        double num1 = scanner.nextDouble();
        double num2 = scanner.nextDouble();
        double num3 = scanner.nextDouble();
        
        System.out.printf("MEDIA = %.1f\n", (num1 * 2 + num2 * 3 + num3 * 5) / (2 + 3 + 5));
    }
 
}
