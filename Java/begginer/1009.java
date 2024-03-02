import java.io.IOException;
import java.util.Scanner;
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        scanner.nextLine();
        double baseSalary = scanner.nextDouble();
        double sales = scanner.nextDouble();
        
        System.out.printf("TOTAL = R$ %.2f\n", baseSalary + (sales * 0.15));
    }
 
}
