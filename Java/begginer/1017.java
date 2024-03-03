import java.io.IOException;
import java.util.Scanner;
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        int distance = scanner.nextInt();
        int averSpeed = scanner.nextInt();
        
        System.out.printf("%.3f\n", distance * averSpeed / 12.0);
    }
 
}
