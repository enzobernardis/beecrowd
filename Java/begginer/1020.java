import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        
        int input = scanner.nextInt();
        int year = input / 365;
        input = input % 365;
        int month = input / 30;
        input = input % 30;
        
        System.out.println(year + " ano(s)");
        System.out.println(month + " mes(es)");
        System.out.println(input + " dia(s)");
    }
 
}
