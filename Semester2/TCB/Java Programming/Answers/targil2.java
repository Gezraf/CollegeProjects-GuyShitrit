//ID: 330707761, Author: Guy Shitrit
import java.util.Scanner;

public class Main {

    // Q1
    public static int leftDigit(int num) {
        while(num > 9)
            num /= 10;

        return num;
    }


    public static boolean checkArr(int[] arr) {
        for(int i = 1; i < arr.length; i++) {
            if(leftDigit(arr[i]) != arr[i - 1] % 10) {
                System.out.println("Invalid");
                return false;
            }
        }

        System.out.println("Valid");
        return true;
    }


    // Q2
    public static int method(int x) {
        int[] counts = new int[10]; // מערך ספירה של ספרות כאשר כל מיקום אינדקס מיוצג כספרה

        while(x > 0) {
            counts[x % 10]++; // קידום הספרה לפי הספרה הימנית הנוכחית של המספר
            x /= 10;
        }

        int max = -1;
        int commonDigit = 0;
        for(int i = 0; i < counts.length; i++) {
            if(counts[i] > max) {
                max = counts[i];
                commonDigit = i; // מציאת הספרה הנפוצה לפי כמות הופעות מקסימלית
            }
        }

        return commonDigit;
    }


    // Q3
    public static void method1(int[] arr) {
        int max = 0;
        int curr = 1;

        for (int i = 1; i < arr.length; i++) {
            if (arr[i] == arr[i - 1]) {
                curr++; // נקדם את הרצף כל עוד איבר שווה לאיברו הקודם
            } else {
                if (curr > max) {
                    max = curr; // אחרת נעדכן את הרצף המקסימלי לרצף שהגענו אליו עד כה
                }
                curr = 1; // ונאתחל את הרצף הנוכחי חזרה ל1
            }
        }

        if (curr > max) { // בדיקה אחרונה למקרה שהרצף המשיך בסוף
            max = curr;
        }

        System.out.println(max);
    }


    // Q4
    public static int maxMin(int[][] mat) {
        int[] mins = new int[mat[0].length];

        for(int i = 0; i < mat.length; i++) {
            int min = mat[i][0];
            for(int j = 0; j < mat[i].length; j++)
                if(mat[i][j] < min)
                    min = mat[i][j];

            mins[i] = min;
        }

        int max = mins[0];
        for(int i = 0; i < mins.length; i++)
            if(mins[i] > max)
                max = mins[i];

        return max;
    }

    public static void main(String[] args) { // פונקציה ראשית עבור שאלה 4 בלבד
        int[][] mat = new int[5][5];
        Scanner scan = new Scanner(System.in);

        for(int i = 0; i < mat.length; i++) {
            for(int j = 0; j < mat[i].length; j++) {
                System.out.println("Enter number: ");
                mat[i][j] = scan.nextInt();
            }
        }

        System.out.println(maxMin(mat));
    }
}
