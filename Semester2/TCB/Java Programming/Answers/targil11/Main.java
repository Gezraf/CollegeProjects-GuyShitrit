// Author: Guy Shitrit, ID: 330707761

public class Main {

    public static void main(String[] args) {
        int[] arr = {4,10,13,71,10,10,71,71,2,10};
        System.out.println(unique_weight(arr));
    }


    // Q10
    public static int weight(int num) {
        if (num < 0)
            num = -num;

        int res = 0;

        while (num > 0) {
            res += num % 10;
            num /= 10;
        }

        return res;
    }


    public static boolean unique_weight(int[] arr) {
        for (int i = 0; i < arr.length; i++) {
            for (int j = i + 1; j < arr.length; j++) {
                if (weight(arr[i]) == weight(arr[j]))
                    return false;
            }
        }

        return true;
    }


    public static boolean equal_weight(int[] arr1, int[] arr2) {
        for (int i = 0; i < arr1.length; i++) {

            boolean flag = false;

            for (int j = 0; j < arr2.length; j++) {
                if (weight(arr1[i]) == weight(arr2[j])) {
                    flag = true;
                    break;
                }
            }

            if (!flag)
                return false;
        }

        return true;
    }

    /* ד.
     סיבוכיות זמן הריצה בסעיף ב הוא O(n^2) כי עבור כל איבר במערך אנחנו עוברים על כל המערך
     זה בגלל שאנחנו צריכים לבדוק אם כבר קיים איבר שמשקלו זהה למשקל האיבר הנוכחי
     לבסוף נחזיר אמת אם אין חזרות במשקל אחרת שקר (מוקדם)


    סיבוכיות זמן הריצה בסעיף ג הוא O(n*m) כאשר n הוא אורך arr1 וm הוא אורך arr2,
    עבור כל איבר בarr1 אנחנו עוברים כל מערך arr2, במטרה לבדוק האם יש איברים שמשקלם שונה בין שני המערכים
    אם כן אנחו מחזירים שקר אחרת אם לא נמצא אפילו זוג אחד כזה אז נחזיר אמת בסוף


     */


    //

    public static void Q12() {
        // Date, FoodItem, Stock class
    }


    public static void Q13() {
    /* א. עבור s1="HELLO" ו־s2="HERLOLOR" תוצאת הפעולה תהיה אמת.
       הסיבה: הפעולה בודקת האם אפשר למצוא את כל התווים של s1 בתוך s2 לפי אותו סדר.
       כאן אפשר למצוא: H,E,L,L,O ולכן מוחזר true.

       ב. דוגמה למחרוזת שתיתן תשובה שונה:
       s3 = "HELO"
       במקרה הזה what("HELLO", s3) תחזיר שקר כי חסר אחד מהתווים L ולכן אי אפשר לקבל את HELLO לפי הסדר.

       ג. באופן כללי הפעולה בודקת האם s1 היא תת סדרה של s2,
       כלומר האם ניתן למחוק תווים מ־s2 ולקבל את s1 בלי לשנות את סדר האותיות.

       ד. מימוש לא רקורסיבי:

       public static boolean what(String s1, String s2)
       {
           int i = 0;
           int j = 0;

           while(i < s1.length() && j < s2.length())
           {
               if(s1.charAt(i) == s2.charAt(j))
                   i++;

               j++;
           }

           return i == s1.length();
       }
    */
    }
}