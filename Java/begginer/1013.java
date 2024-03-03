import java.io.IOException;
import java.util.Scanner;
import java.util.Arrays;

public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        String[] input = scanner.nextLine().split(" ");
        int[] nums = new int[3];
        
        for(int i = 0; i < 3; i++) {
            nums[i] = Integer.valueOf(input[i]).intValue();
        }
        
        System.out.println(Arrays.stream(nums).max().getAsInt() + " eh o maior");
    }
 
}
