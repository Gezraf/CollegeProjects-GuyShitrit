public class Main {

    public static void printTriangle(int n) {
        if (n == 0)
            return;

        for (int i = 0; i < n; i++)
            System.out.print("*");
        System.out.println();

        printTriangle(n-1);
    }


    public static void printReverse(String s) {
        if (s == null || s.isEmpty()) // נצא כשהתת מחרוזת ריקה
            return;
        printReverse(s.substring(1)); // קודם אנחנו מעלים את המחרוזת הבאה בתור למחסנית כך שאנחנו "בונים" את המחסנית
        System.out.print(s.charAt(0)); // כשהתוכנית "מפרקת" את המחסנית היא יוצאת בסדר הפוך כך שהפלט יוצא הפוך
    }


    public static int howManyChar(String s, char c) {
        if (s == null || s.isEmpty()) // נצא כשהתת מחרוזת ריקה
            return 0;

        if (s.charAt(0) == c)
            return 1 + howManyChar(s.substring(1), c); // אם התו הראשון בתת מחרוזת הנוכחית שווה לתו פרמטר נוסיף 1 לתוצאה

        return howManyChar(s.substring(1), c); // אם לא אז לא נוסיף 1 לתוצאה
    }

    public static boolean checkAscending(int n) {
        if (n == 0)
            return true;

        if(n % 10 >= (n / 10 % 10)) // אם הספרה האחרונה גדולה מהספרה לפניה אז נמשיך לבדוק
            return checkAscending(n / 10);

        return false; // אחרת נחזיר שקר מוקדם
    }
}