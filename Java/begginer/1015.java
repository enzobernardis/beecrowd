import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        double[][] points = new double[2][2];
        
        for(int i = 0; i < 2; i++) {
            String[] input = scanner.nextLine().split(" ");
            for(int j = 0; j < 2; j++) {
                points[i][j] = Double.valueOf(input[j]).doubleValue();
            }
        }
        
        System.out.printf("%.4f\n", Math.sqrt(Math.pow(points[1][0] - points[0][0], 2) + Math.pow(points[1][1] - points[0][1], 2)));
        
    }
 
}
