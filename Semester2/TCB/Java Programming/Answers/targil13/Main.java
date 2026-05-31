// Author: Guy Shitrit, ID: 330707761
// הערה: את הmain לשאלה 2 כתבתי בקובץ הזה, הוא מפעיל את Q2

import java.util.Scanner;
public class Main {

    // Q12
    public static boolean isSuperEven(int num) {
        if (num <= 0)
            return false;

        int length = 0;
        while (num > 0) {
            if (num % 2 == 1)
                return false;

            num /= 10;
            length++;
        }

        if (length % 2 == 1)
            return false;

        return true;
    }


    public static boolean isSuperEven(int[] arr) {
        int n = arr.length;

        if (n % 2 == 1)
            return false;

        int superEvenCount = 0;

        for (int i = 0; i < n; i++) {
            if(isSuperEven(arr[i]))
                superEvenCount++;
        }

        if (superEvenCount <= n / 2)
            return false;

        return true;
    }

    public static int[] getColumn(int[][] mat, int col) {
        int[] column = new int[mat.length];
        for (int i = 0; i < mat.length; i++) {
            column[i] = mat[i][col];
        }

        return column;
    }

    public static boolean isSuperEven(int[][] mat) {
        int cols = mat[0].length;

        if (cols % 2 == 1)
            return false;

        for (int col = 0; col < cols; col++) {
            if(!isSuperEven(getColumn(mat, col)))
                return false;
        }

        return true;
    }

    /*
        ב. נחשב את סיבוכיות זמן הריצה של סעיף א':

        בדיקה אם מספר הוא מספר סופר זוגי זה סיבוכיות O(k) כאשר k הוא אורך המספר
        בדיקה האם מערך הוא סופר זוגי הוא במקרה הגרוע ביותר O(k*n) כאשר k הוא אורך כל מספר במערך וn הוא אורך המערך
        בדיקה האם מערך דו-מימדי הוא סופר זוגי היא במקרה הגרוע ביותר O(k*n*m)  כאשר k הוא אורך כל מספר, n הוא מספר השורות במטריצה, ו-m הוא מספר העמודות במטריצה
        הסיבה היא שעוברים על כל עמודה במטריצה, ובכל עמודה בודקים n איברים
     */


    // Q13 עשיתי את המחלקות שהתבקשו


    // Q14

    /*
        public static void what (int[] arr, int begin, int end)
        {
            if(begin < end)
            {
                what(arr, begin+1, end);
                arr[begin] = arr[begin] - arr[begin+1];
            }
        }

        א.
        1.
        brr = {15,5,3,16,10,8}, begin=0, end=5
        ברגע שמגיעים לתנאי start<end אנחנו מבצעים רקורסיה (לפני השמת ערך למערך)
        כלומר אנחנו דוחפים למחסנית הרקורסיה עד שהתנאי יהיה שקרי, ע"י הוספת 1 לstart בכל קריאה חדשה
        כלומר הקריאה אחרונה תהיה מתי שbegin=4, ובסוף כשאנחנו "מקלפים" את המחסנית הרקורסיה אנחנו מתחילים עם begin=4 בפעולות הבאות

        brr[4] -= brr[5] --> brr = {15,5,3,16,2,8}
        brr[3] -= brr[4] --> brr = {15,5,3,14,2,8}
        brr[2] -= brr[3] --> brr = {15,5,-11,14,2,8}
        brr[1] -= brr[2] --> brr = {15,16,-11,14,2,8}
        brr[0] -= brr[1] --> brr = {-1,16,-11,14,2,8}


        2.
        המטרה של הפעולה what היא לעדכן כל ערך במערך ע"י החסרת ערך כל איבר קודם מהערך של האיבר שמולו, מסוף המערך לתחילתו.


        ב.

        public static void where (int[] arr, int begin, int end)
        {
            if(begin < end)
            {
                arr[begin] = arr[begin] - arr[begin+1];
                where (arr, begin+1, end);
            }
        }

        1.
        נבחון שהפעולה where די דומה לפעולה what רק שהיא עוברת על האיברים מההתחלה עד לסוף
        כדי להגיע למצב הסופי של
        crr = {1,-2,-1,-2,7,3}

        נצטרך לחשוב בסדר הפוך, כלומר במקום להחסיר כל איבר קודם מאיברו הבא מההתחלה לסוף
        אז להיפך נצטרך להוסיף כל איבר קודם מאיברו הבא מהסוף להתחלה

        לכן לפני הזימון:
        crr = {6,5,7,8,10,3}

        2.
        המטרה של הפעולה what היא לעדכן כל ערך במערך ע"י החסרת ערך כל איבר קודם מהערך של האיבר שמולו, מהתחלת המערך לסופו.
     */



    public static void main(String[] args) {
        System.out.println(isSuperEven(-22));
    }
}