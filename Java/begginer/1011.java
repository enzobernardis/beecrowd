import java.io.IOException;
import java.util.Scanner;
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        double input = scanner.nextDouble();
        
        System.out.printf("VOLUME = %.3f\n", (4.0 / 3.0) * 3.14159 * Math.pow(input, 3));
    }
 
}
