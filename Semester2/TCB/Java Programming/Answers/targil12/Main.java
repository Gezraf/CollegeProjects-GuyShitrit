//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        int[] arr1 = {12551, 6215, 77, 4254, 4, -561};
        int[] arr2 = {12551, 4, 6215, 77, 4254, -561};

        int[] res = buildSpecialArray(arr1, arr2);

        for (int i = 0; i < res.length; i++) {
            System.out.print(res[i] + " ");
        }
    }


    public static void Q7() {
        // Student
    }


    public static void Q8() {
        // Participant, VickeryAuction, Winner
    }


    public static int getLength(int num) {
        int n = 0;

        while (num > 0) {
            num /= 10;
            n++;
        }

        return n;
    }


    // Q11
    public static boolean specialNumber(int num) {
        if (num < 0)
            return false;


        int n = getLength(num);
        if (n < 2)
            return false;

        int oddSum = 0, evenSum = 0;
        for(int i = 0; i < n; i++) {
            int digit = num % 10;

            if (i % 2 == 0) {
                oddSum += digit;
            } else {
                evenSum += digit;
            }

            num /= 10;
        }

        return oddSum == evenSum;
    }

    public static boolean isSpecialArray(int[] arr) {
        boolean flag = false;

        for (int i = 0; i < arr.length; i++) {
            if (specialNumber(arr[i])) {
                if (flag)
                    return false;

            } else {
                flag = true;
            }
        }

        return true;
    }

    public static int[] buildSpecialArray(int[] arr1, int[] arr2) {
        int[] temp = new int[arr1.length + arr2.length];
        int count = 0;
        int j = 0;

        for (int i = 0; i < arr1.length; i++) {
            if (specialNumber(arr1[i])) {
                temp[j++] = arr1[i];
                count++;
            }
        }


        for (int i = 0; i < arr2.length; i++) {
            if(specialNumber(arr2[i])) {
                temp[j++] = arr2[i];
                count++;
            }
        }

        int[] res = new int[count];

        for(int i = 0; i < count; i++) {
            res[i] = temp[i];
        }

        return res;
    }

    public static void Q11() {
        // specialNumber(), isSpecialArray(), buildSpecialArray()
    }

}