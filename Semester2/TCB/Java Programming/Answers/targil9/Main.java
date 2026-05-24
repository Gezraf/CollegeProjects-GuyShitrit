// Author: Guy Shitrit, ID: 330707761
// הערה: את הmain לשאלה 2 כתבתי בקובץ הזה, הוא מפעיל את Q2

import java.util.Scanner;
public class Main {

    public static void Q1() {
        Scanner scan = new Scanner(System.in);
        int numCount = 0, evenCount = 0, posCount = 0, posSum = 0;
        int num = -1;

        while (num != 0) {
            System.out.printf("Enter num: ");
            num = scan.nextInt();

            if (num == 0)
                break;

            numCount++;

            if(num % 2 == 0)
                evenCount++;

            if(num > 0) {
                posCount++;
                posSum += num;
            }
        }

        System.out.println("NumCount: " + numCount);
        System.out.println("EvenCount: " + evenCount);

        double posAvg = (double) posSum / posCount;
        System.out.println("Positives Average: " + posAvg);
    }

    public static void Q2() {
        Scanner scan = new Scanner(System.in);

        System.out.println("Enter hours of flight1: ");
        int hour1 = scan.nextInt();
        System.out.println("Enter minutes of flight1: ");
        int min1 = scan.nextInt();

        while(!(hour1 >= 0 && hour1 <= 23 && min1 >= 0 && min1 <= 59)) {
            System.out.println("Enter hours of flight1: ");
            hour1 = scan.nextInt();
            System.out.println("Enter minutes of flight1: ");
            min1 = scan.nextInt();
        }


        Clock cl1 = new Clock(hour1, min1);


        System.out.println("Enter hours of flight2: ");
        int hour2 = scan.nextInt();
        System.out.println("Enter minutes of flight2: ");
        int min2 = scan.nextInt();

        while(!(hour2 >= 0 && hour2 <= 23 && min2 >= 0 && min2 <= 59)) {
            System.out.println("Enter hours of flight2: ");
            hour2 = scan.nextInt();
            System.out.println("Enter minutes of flight2: ");
            min2 = scan.nextInt();
        }

        Clock cl2 = new Clock(hour2, min2);

        int interval1 = cl1.getInterval();
        int interval2 = cl2.getInterval();

        if (interval1 < interval2) {
            System.out.println("Flight 1 arrives later");
        } else if (interval2 < interval1) {
            System.out.println("Flight 2 arrives later");
        } else {
            System.out.println("Both flights arrive at the same time");

        }
    }

    public static void Q3() { // זה רק מקום לענות על שאלה 3, אין פה מימוש
        /*

        א.

        public static int what(int num) {
            int c = 0;
            while (num > 0)
            {
                c += (num % 2);
                num /= 10;
            }

            return c;
        }

        1. עבור num=12345 אנחנו עוברים על כל הספרות
        (טכנית המספר עצמו אבל אנחנו עושים חלוקה בשארית) של המספר ובהתאם להאם הוא זוגי או לא,
        אנחנו מוסיפים את תוצאת חילוק השארית שלו ב-2 לתוך משתנה c:
        c += 12345 % 2 = 1 --> c = 1 --> num = 12345 / 10 = 1234
        c += 1234 % 2 = 0 -- > c = 1 --> num = 1234 / 10 = 123
        c += 123 % 2 = 1 -- > c = 2 --> num = 123 / 10 = 12
        c += 12 % 2 = 0 --> c = 2 --> num = 12 / 10 = 1
        c += 1 % 2 = 1 -- > c = 3 --> num = 1 / 10 = 0 --> סיום

        קיבלנו בסוף כי c = 3, מייצג את כמות הספרות האי-זוגיות במספר


        2. ניקח למשל num = 2468:

        c += 2468 % 2 = 0 --> c = 0, num = 246
        c += 246 % 2 = 0 -- > c = 0, num = 24
        c += 24 % 2 = 0 --> c = 0, num = 2
        c += 2 % 2 = 0 -- > c = 0, num = 0

        קיבלנו c = 0 לכן הפעולה תחזיר 0


        3. הפעולה בסופו של דבר מחזירה את כמות הספרות האי-זוגיות של מספר שלם וחיובי.
        היא עושה זאת ע"י הוספת תוצאת השארית של חילוק ב-2 של המספר הנוכחי לתוך c
         ואז מחלקת את המספר הנוכחי ב-10, כך שספרת האחדות של המספר הנוכחי יורדת וכך מתקבל
          מספר חדש. ככה אנחנו עוברים בעצם על  ה"ספרות" של המספר
           (המספר הנוכחי עצמו אך ספרת האחדות קובעת אם המספר הוא זוגי או לא)

        /*

          ב.

          public static void why()
//        {
//            int[] arr = {1245, 34781, 23, 468, 139};
//            int res = arr[0];
//
//            for (int i = 1; i < arr.length; i++)
//            {
//                if(what(arr[i]) < what(res))
//                {
//                    res = arr[i];
//                }
//            }
//
//            System.out.println(res);
//        }


        1. לפני זה הסקנו שהפעולה what מחזירה את כמות הספרות האי זוגיות של מספר שלם חיובי
         יש לנו מערך מספרים ואת המשתנה res שמעתיק את האיבר הראשון תחילה
        אנחנו עוברים על שאר המערך ובודקים האם כמות הספרות האי הזוגיות הנוכחית קטנה משל כמות הספרות האי זוגיות של res הנוכחי, אם כן נשים את res להיות כמות זו.
        כלומר אנחנו בעצם עושים את סדר הפעולות הבא:

        what(34781) < what(1245) --> 3 < 2 --> false
        what(23) < what(1245) --> 1 < 2 --> true --> res = 23
        what(468) < what(23) --> 0 < 1 --> true --> res = 468
        what(139) --> what(468) --> 3 < 0 --> false

        יודפס לבסוף 468

        2. הקוד בשאלה זו מתחיל עם מערך מספרים, עם המשתנה res שמעתיק את האיבר הראשון
        אנחנו עוברים על כל שאר המערך ומשנים אחרי כל איטרציה את res למספר הנוכחי עם כמות הספרות האי זוגיות המינימלית
        לבסוף res יתקבל כמספר עם הכמות הספרות האי זוגיות המינימלית מתוך המערך

        */
    }


    public static boolean Q4(int[] arr)
    {
        int n = arr.length;
        if (n < 3 || n % 2 == 0)
            return false;

        int mid = arr[n / 2];

        for(int i = 0; i < n / 2; i++) {
            if (arr[i] <= mid)
                return false;
        }

        for (int i = n / 2 + 1; i < n; i++) {
            if (arr[i] >= mid)
                return false;
        }

        return true;


        /*
         סיבוכיות הפעולה היא ליניארית (O(n)) משום שאנחנו עושים שני מעברים ליניאריים
         בשני החצאים של המערך אחד אחרי השני
         המקרה הכי טוב עבור סיבוכיות הזמן הוא O(1) אם אנחנו מחזירים שקר מוקדם כאשר המערך לא תקין או שנתפסה סתירת תנאי מוקדמת
        */
    }


    public static void Q5() {
        /*
            public static boolean one(int[] arr)
            {
                for (int i = 0; i < arr.length - 1; i++)
                {
                    for (int k = i + 1; k < arr.length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            i = 0 → arr[i] = 3
            k = 1 → arr[k] = 5 → 3 != 5
            k = 2 → arr[k] = 7 → 3 != 7
            k = 3 → arr[k] = 5 → 3 != 5
            k = 4 → arr[k] = 2 → 3 != 2
            לא נמצא איבר שווה, ממשיכים

            i = 1 → arr[i] = 5
            k = 2 → arr[k] = 7 → 5 != 7
            k = 3 → arr[k] = 5 → 5 == 5 → הפעולה מחזירה אמת

            הפעולה נעצרת מיד ולא ממשיכה לבדוק

            תשובה סופית: הפעולה מחזירה true


            ב. הפעולה one בודקת האם יש שני איברים שווים במערך

            ג. הסיבוכיות של הפעולה היא פרבולית (O(n^2)) משום שאנחנו מבצעים לולאה מקוננת על המערך
            כלומר עבור כל איבר במערך אנחנו עוברים על שאר האיברים שאחריו (n*k בדיקות)

            ד. אם המערך arr ממויין בסדר עולה נוכל לכתוב מחדש את הפעולה כך שאנחנו בודקים
            אם כל שני איברים סמוכים שווים כל פעם, אם נמצא צמד איברים סמוכים שווים נחזיר אמת מוקדם, אחרת נחזיר שקר בסוף הלולאה.
            סיבוכיות הזמן של פתרון יעיל זה היא O(n) משום שאנחנו עוברים על כל המערך פעם אחת ובודקים שיוויון זוג איברים סמוכים לאורך המערך


            ה. לא, תשובתי לא תשתנה אפילו אם arr ממוין בסדר יורד, בגלל שמספיקה העובדה שהמערך ממוין בשביל
            בדיקת שיוויון זוג איברים סמוכים לאורך המערך, במערך ממוין (עולה או יורד) איברים שויים בהכרח יהיו סמוכים זה לזה.
         */
    }


    public static void Q6() {
        /*
            public static boolean why(String str)
            {
                 for (int i = 0; i < str.length(); i++)
                 {
                     if (str.charAt(i) < 'A' || str.charAt(i) > 'Z')  {
                         return false;
                     }
                 }

                 return true;
            }


            ABCDE .1
            aBCDE .2
            3. מחזירה אמת או שקר בהתאם להאם כל התווים של המחרוזת הם אותיות גדולות או לא
            4. הסיבוכיות של הפעולה היא O(n) בגלל שאנחנו עוברים על כל התווים של המחרוזת ובודקים האם כל תו הוא אות גדולה או לא
            אך במקרה הכי טוב הסיבוכיות תהיה O(1) במקרה ואנחנו מוצאים תו במחרוזת שהיא לא אות גדולה, ואז הפעולה מחזירה שקר מוקדם


            ב.

            public static boolean mystery(String[] arr)
            {
                 for (int i = 0; i < arr.length / 2; i++)
                 {
                        if (why(arr[i]) == why(arr[arr.length - 1 - i]))
                            return false;
                 }

                return true;
            }

            {"A", "b", "c", "D", "E", "f"} .1
            {"A", "b", "c", "D", "E", "f"} .2

            3. הסיבוכיות של הפעולה היא O(n^2) בגלל שאנחנו עוברים בלולאה ובודקים מהקצוות של המערך
            בעזרת הפעולה why עם סיבוכיות O(n) על כל קצה
            כלומר אנחנו מבצעים פעולה של O(n) פעמיים * n / 2 פעמים:

            (O(n) + O(m)) * (n/2) = O(n + m) * (n/2) = O(n(n+m) / 2) ~ O(n^2)
            לכן הסיבוכיות היא O(n^2)
            אבל כמובן המקרה הטוב ביותר הוא O(n) כאשר אנחנו בהכרח מבצעים את הפעולה why אבל מחזירים שקר מוקדם בפונקציה mystery ברגע שנסתר התנאי
         */
    }

    public static void main(String[] args) {
        Q2();
    }
}