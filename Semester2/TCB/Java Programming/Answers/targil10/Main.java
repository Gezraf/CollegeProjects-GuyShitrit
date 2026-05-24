// Author: Guy Shitrit, ID: 330707761

import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        int[] arr = {4,10,13,71,10,10,71,71,2,10};
        System.out.println(minNum(arr));
    }


    // Q10
    public static int dist(int arr[], int num) {
        int n = arr.length;
        int minIndex = n + 1, maxIndex = -1;


        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == num) {
                if (i < minIndex)
                    minIndex = i;

                if (maxIndex < i)
                    maxIndex = i;
            }
        }

        return minIndex + (n - maxIndex - 1);
    }


    public static int minNum(int arr[]) {
        int min = 2147483646; // השלם הגדול ביותר (נראה לי)
        int distance = 0;

        for (int i = 0; i < arr.length; i++) {
            distance = dist(arr, arr[i]);
            if (distance > min)
                min = distance;

        }

        return distance;
    }

    //

    public static void Q11() {
                /*

        א.

        public static boolean secret (int n1, int n2)
        {
             if (n1 < 10)
                return (n1 == n2);

             if (n1%10 == n2)
                return true;

             return secret (n1 / 10, n2);
        }


        א. 1. עבור secret(528,5) אנחנו מבצעים את הפעולה הבאה:

        n1 = 528, n2 = 5: n1 < 10? no. n1 % 10 == n2? no --> secret(52, 5)
        n1 = 52, n2 = 5: n1 < 10? no. n1 % 10 == n2? no --> secret(5, 5)
        n1 = 5, n2 = 5: n1 < 10? yes. return 5 == 5 --> true

        2. הפעולה secret בודקת האם קיימת ספרה בn1 ששווה לn2 (בהנחה שn2 היא ספרה!)


        ב.

        public static int[] bigSecret(int[] arr) {
            int[] temp = new int[arr.length];

            mystery(arr, temp, 0, 0, temp.length - 1);

            return temp;
        }

        private static void mystery(int[] arr, int[] temp, int k, int low, int high) {

            if (k < arr.length) {

                if (secret(arr[k] / 10, arr[k] % 10)) {

                    temp[high] = arr[k];

                    mystery(arr, temp, k + 1, low, high - 1);

                } else {

                    temp[low] = arr[k];

                    mystery(arr, temp, k + 1, low + 1, high);
                }
            }
        }

        1. עבור bigSecret([424,57547, 130, 57675, 12]) אנחנו מצבעים את הפעולה הבאה:

        temp = new int[arr.length]
        mystery([424, 57547, 130, 57675, 12], temp, k=0, low=0, high=4)


        mystery:
        k < arr.length? (0 < 5) yes
        secret(arr[0] / 10, arr[0] % 10) --> secret(42, 4)? yes --> temp[4] = arr[0]
        --> temp = [., ., ., ., 424]


        mystery([424, 57547, 130, 57675, 12], temp, k=1, low=0, high=3)

        k < arr.length? (1 < 5) yes
        secret(arr[1] / 10, arr[1] % 10) --> secret(5754, 7)? yes --> temp[3] = arr[1]
        --> temp = [., ., ., 57547, 424]


        mystery([424, 57547, 130, 57675, 12], temp, k=2, low=0, high=2)

        k < arr.length? (2 < 5) yes
        secret(arr[2] / 10, arr[2] % 10) --> secret(13, 0)? no --> temp[0] = arr[2] -->
        --> temp = [130, ., ., 57547, 424]


        mystery([424, 57547, 130, 57675, 12], temp, k=3, low=1, high=2)

        k < arr.length? (3 < 5) yes
        secret(arr[3] / 10, arr[3] % 10) --> secret(5767, 7)? yes --> temp[2] = arr[3] -->
        --> temp = [130, ., 57675, 57547, 424]


        mystery([424, 57547, 130, 57675, 12], temp, k=4, low=1, high=1)

        k < arr.length? (4 < 5) yes
        secret(arr[4] / 10, arr[4] % 10) --> secret(1, 2)? yes --> temp[1] = arr[4] -->
        --> temp = [130, 12, 57675, 57547, 424]



        return temp --> temp = [130, 12, 57675, 57547, 424]



        2.
        הפעולה bigSecret יוצרת מערך חדש ומעבירה אליו את כל המספרים מהמערך המקורי לפי התנאי של הפעולה secret
        מספרים שעבורם secret מחזירה true נכנסים לסוף המערך
        מספרים שעבורם secret מחזירה false נכנסים לתחילת המערך
        */


    }


    public static void Q12() {
        // Worker class
    }

}