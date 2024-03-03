import java.io.IOException;
import java.util.Scanner;
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        String[] input = scanner.nextLine().split(" ");
        
        double a = Double.valueOf(input[0]).doubleValue();
        double b = Double.valueOf(input[1]).doubleValue();
        double c = Double.valueOf(input[2]).doubleValue();
        
        System.out.printf("TRIANGULO: %.3f\n", a * c / 2);
        System.out.printf("CIRCULO: %.3f\n", 3.14159 * Math.pow(c, 2));
        System.out.printf("TRAPEZIO: %.3f\n", (a + b) * c / 2);
        System.out.printf("QUADRADO: %.3f\n", Math.pow(b, 2));
        System.out.printf("RETANGULO: %.3f\n", a * b);
    }
 
}
