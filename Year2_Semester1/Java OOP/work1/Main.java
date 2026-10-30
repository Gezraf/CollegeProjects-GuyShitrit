import java.util.Scanner;

public class Main {
    public static void Q1() {
        /* This function has to do with the inner function
           logic of Q1's main function in the CircleArea class
        */
        Scanner scan = new Scanner(System.in);
        double radius, area;

        System.out.println("Please enter radius: ");
        radius = scan.nextDouble();
        area = Math.PI * radius * radius;
        System.out.println("The area of the circle is: " + area);
    }

    public static void Q2() {
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter n: ");
        int n = scan.nextInt();

        int a = 1, b = 0;
        for (int i = 0; i < n; i++) {
            System.out.printf("%d", a + b);
            int copy = b;
            b = a + b;
            a = copy;

            if (i < n - 1)
                System.out.printf(",");
        }
    }

    public static void Q3() {
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter number: ");
        int num = scan.nextInt();

        int[] counts = {0,0,0,0,0,0,0,0,0,0};

        while (num > 0) {
            int digit = num % 10;
            counts[digit]++;
            num /= 10;
        }

        int oddSum = 0;
        System.out.print("Even appearances digits: ");
        for (int i = 0; i < counts.length; i++) {
            if (counts[i] > 0) {
                if (counts[i] % 2 == 0) {
                    System.out.printf("%d,", i);
                } else {
                    oddSum += i * counts[i];
                }
            }
        }

        System.out.printf("\nOdd appeareance digit sum: " + oddSum);
    }

    public static boolean isPrime(int n) {
        if (n <= 1)
            return false;
        if (n == 2)
            return true;

        for (int i = 2; i < Math.sqrt(n); i++) {
            if (n % i == 0)
                return false;
        }

        return true;
    }
    public static void Q4() {
        for (int i = 2;  i <= 200; i++)
            if (isPrime(i))
                System.out.printf("%d,", i);
    }

    public static char digitToHex(int remainder) {
        if (0 <= remainder && remainder <= 9)
            return (char) ('0' +remainder);
        return (char) ('A' + remainder - 10);
    }
    public static void Q5() {
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter number: ");
        int num = scan.nextInt();

        String reverseHexResult = "";
        while (num > 0) {
            int rem = num % 16;
            reverseHexResult += digitToHex(rem);
            num /= 16;
        }

        String hexResult = "0";
        int revHexLength = reverseHexResult.length();
        for (int i = 0; i < revHexLength; i++) {
            hexResult += reverseHexResult.charAt(revHexLength - i - 1);
        }

        hexResult += 'h';
        System.out.println("Result: " + hexResult);

    }
    public static void main(String[] args) {
        Q1();
        Q2();
        Q3();
        Q4();
        Q5();
    }
}