import java.util.Scanner;

public class Main
{
    public static void Q1() {
        int SIZE = 10;
        
        for(int i = 1; i <= SIZE; i++) {
            for(int j = 1; j <= SIZE; j++) {
                System.out.print(i * j + " ");
            }
            
            System.out.println();
        }
    }
    
    
    public static void Q2() {
        for (int i = 2; i < 20; i++) {
            boolean isPrime = true;
            
            for(int j = 2; j < i / 2; j++)
                if (i % j  == 0)
                    isPrime = false;
            
            if(isPrime)
                System.out.println(i);
        }
    }
    
    
    public static void Q3() {
        for(int num = 1000; num <= 9999; num++) {
            int left = num / 100;
            int right = num / 10 % 10 * 10 + num % 10;
            
            int sum = left + right;
            
            if(sum * sum == num)
                System.out.println(num);
        }
    }
    
    
    public static void Q4() {
        Scanner scan = new Scanner(System.in);
        
        System.out.println("Enter number: ");
        int num = scan.nextInt();
        
        for(int count = 1; count <= num; count++) {
            for(int spaces = 0; spaces < num - count; spaces++)
                System.out.print("  ");
                
            for(int i = 1; i <= count; i++) {
                System.out.print(i + " ");
            }
            
            for(int i = count - 1; i >= 1; i--) {
                System.out.print(i + " ");
            }
            
            System.out.println();
        }
    }
    
	public static void main(String[] args) {
		Q1();
		Q2();
		Q3();
		Q4();
	}
}
