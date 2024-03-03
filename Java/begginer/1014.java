import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        int km = scanner.nextInt();
        double spentFuel = scanner.nextDouble();
        
        System.out.printf("%.3f km/l\n", km / spentFuel);
    }
 
}
