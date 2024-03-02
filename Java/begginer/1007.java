import java.io.IOException;
import java.util.Scanner;
public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        int[] nums = new int[4];
        
        for(int i = 0; i < 4; i++) {
            nums[i] = scanner.nextInt();
        }
        
        System.out.println("DIFERENCA = " + (nums[0] * nums[1] - nums[2] * nums[3]));
    }
 
}
