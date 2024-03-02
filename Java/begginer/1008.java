import java.io.IOException;
import java.util.Scanner;
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        int num = scanner.nextInt();
        int workedHours = scanner.nextInt();
        double usPerHour = scanner.nextDouble();
        
        System.out.println("NUMBER = " + num);
        System.out.printf("SALARY = U$ %.2f\n", workedHours * usPerHour);
    }
 
}
