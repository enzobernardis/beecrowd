import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        double sum = 0;
        int count = 0;
        
        for(int i = 0; i < 6; i++) {
            double input = scanner.nextDouble();
            if(input > 0) { sum += input; count++; }
        }
        
        System.out.printf("%d valores positivos\n", count);
        System.out.printf("%.1f\n", sum / count);
    }
 
}
