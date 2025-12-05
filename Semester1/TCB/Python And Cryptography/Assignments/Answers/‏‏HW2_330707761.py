# ------------------------------------------------
# Name: Guy Shitrit
# ID: 330707761
# ------------------------------------------------
#                   Q1
# ------------------------------------------------
def Q1(hours, minutes, seconds, flight_time):
    """
    הפונקציה מקבלת זמן התחלה ושם כוללת שעות דקות ושניות וכן מקבלת את משך זמן הטיסה בשניות
    הפונקציה בודקת תקינות של כל אחד מערכי הזמן ולא מבצעת חישוב במקרה של ערכים שגויים
    אם הקלט תקין הפונקציה מחשבת את זמן הנחיתה מתוך המרה לשניות ולאחר מכן המרה חזרה לשעות דקות ושניות
    הפונקציה מציגה את זמן ההתחלה ואת זמן הסיום ומוסיפה מידע על מספר ימי השארית אם קיימים
    """
    
    valid = True

    if hours < 0 or hours >= 24:
        print(f"{hours} hours value error!")
        valid = False

    if minutes < 0 or minutes >= 60:
        print(f"{minutes} minutes value error!")
        valid = False

    if seconds < 0 or seconds >= 60:
        print(f"{seconds} seconds value error!")
        valid = False

    if valid: # אם הקלט תקין
        print(f"The Start Time: {hours:02d}:{minutes:02d}:{seconds:02d}")

        start_time = seconds + minutes * 60 + hours * 60 * 60 # המרה של הזמן ההתחלתי לשניות

        landing_time = start_time + flight_time

        landing_hours = landing_time // 3600 # שעה אחת היא 3600 שניות
        landing_time %= 3600 # קיזוז השעות מתוך זמן הנחיתה בשניות

        leftover_days = landing_hours // 24
        landing_hours %= 24 # קיזוז "ימי השארית" מתוך זמן הנחיתה בשניות

        landing_minutes = landing_time // 60 # דקה אחת היא 60 שניות
        landing_time %= 60 # קיזוז הדקות מתוך זמן הנחיתה בשניות

        landing_seconds = landing_time # מה שנותר בשארית לאחר קיזוז זמן הנחיתה חייב להיות רק שניות

        print("The Finish Time: ", end="")
        print(f"{landing_hours} hour", end="")

        if landing_hours > 1:
            print("s", end="")

        if landing_minutes == 0 and landing_seconds == 0:
            print(" exactly", end="")
        if landing_minutes > 0:
            print(f", {landing_minutes} minutes", end="")

        if landing_seconds > 0:
            print(f", {landing_seconds} seconds", end="")

        if leftover_days > 0:
            print(f" (+{leftover_days} day", end="")

            if leftover_days > 1:
                print("s", end="")

            print(f")", end="")



# ------------------------------------------------
'''
>>> Q1(-5,60,100,0)
  -5 hours   value error !!!
  60 minutes value error !!!
 100 seconds value error !!!
>>> Q1(3,9,59,1)
The Start Time: 03:09:59
The Finish Time: 3 hours, 10 minutes
>>> Q1(23,9,59,1)
The Start Time: 23:09:59
The Finish Time: 23 hours, 10 minutes
>>> Q1(22,59,59,1)
The Start Time: 22:59:59
The Finish Time: 23 hours exactly
>>> Q1(1,1,6,1)
The Start Time: 01:01:06
The Finish Time: 1 hour, 1 minute, 7 seconds
>>> Q1(0,0,0,177615)
The Start Time: 00:00:00
The Finish Time: 1 hour, 20 minutes, 15 seconds(+2 days)
>>> Q1(0,0,0,91215)
The Start Time: 00:00:00
The Finish Time: 1 hour, 20 minutes, 15 seconds(+1 day)
'''

# ------------------------------------------------
#                   Q2
# ------------------------------------------------
def Q2(x):
    """
    הפונקציה מקבלת מספר שלם ומחזירה מספר חדש שבו כל הספרות האי זוגיות מופיעות קודם לפי סדר הופעתן המקורי ולאחר מכן כל הספרות הזוגיות לפי סדר הופעתן המקורי
    אם המספר שלילי הסימן נשמר ומצורף לתוצאה
    הפעולה מתבצעת על ידי פירוק המספר לספרות משמאל לימין באמצעות חישוב אורך והתקדמות במכפילים ללא שימוש במבנים נוספים
    """
    length = 0

    if x >= 0: # נרצה שאם המספר יהיה שלילי, נהפוך אותו לחיובי כדי שלא יגביל את המטרה של הפונקציה
        sign = 1
    else:
        sign = -1

    x *= sign

    temp = x
    while temp != 0: # משיג את האורך של המספר
        length += 1
        temp //= 10

    res = 0

    temp = x
    factor = 10 ** (length - 1)
    while factor > 0: # ספרות אי-זוגיות
        digit = temp // factor
        if digit % 2 == 1:
            res = res * 10 + digit

        temp %= factor
        factor //= 10

    temp = x
    factor = 10 ** (length - 1)
    while factor > 0: # ספרות זוגיות
        digit = temp // factor
        if digit % 2 == 0:
            res = res * 10 + digit

        temp %= factor
        factor //= 10

    return res * sign


# ------------------------------------------------
'''
Q2( 12345678 )
13572468
Q2( -623 )
-362
Q2( 7135 )
7135
Q2( -64282 )
-64282
'''

# ------------------------------------------------
#                   Q3
# ------------------------------------------------
def Q3():
    """
    הפונקציה קוראת מהמשתמש מספרים אחד אחד עד להזנת 0
    עבור כל מספר שנקלט, הפונקציה בודקת האם הוא מספר פלינדרומי
    (כלומר מספר שנקרא אותו הדבר משמאל לימין ומימין לשמאל)

    הבדיקה מתבצעת באמצעות השוואת הספרה השמאלית לספרה הימנית, מחיקת שתי הספרות, והמשך ההשוואה עד אמצע המספר
    בסיום הפונקציה מדפיסה כמה מן המספרים שנקלטו היו פלינדרומיים
    """
    num = 1
    count = 0

    while num > 0:
        num = int(input("Enter number: "))

        if num == 0:
            break

        length = 0
        temp = num
        isBalanced = True

        while temp != 0: # משיג את האורך של המספר
            length += 1
            temp //= 10

        temp = num
        factor = 10 ** (length - 1)

        while factor > 9: # כל עוד המכפיל דו-ספרתי
            leftDigit = temp // factor
            rightDigit = temp % 10

            if leftDigit != rightDigit: # ידלג על המספר אם הספרה השמאלית שונה מהספרה הימנית
                isBalanced = False
                break

            temp %= factor # מחק ספרה שמאלית
            temp //= 10 # מחק ספרה ימנית
            factor //= 100 # מחק 2 אפסים מהמכפיל הנוכחי

        if isBalanced:
            count += 1


    print(count)


# ------------------------------------------------
'''
Q3( )
Enter integer numbers [0 for end]: 
number: 8
number: 3135
number: 967
number: 1234321
number: 15
number: 989
number: 271897
number: 0
3
'''

# ------------------------------------------------
#                   Q4
# ------------------------------------------------
def Q4():
    """
    הפונקציה קוראת מהמשתמש מספרים שלמים עד שנקלט מספר בין עשר לתשעים ותשע (כלומר מספר דו-ספרתי)
    עבור כל מספר שאינו בתחום הפונקציה מחשבת את סכום הספרות הזוגיות של המספר
    הפונקציה שומרת את המספר שהביא את הסכום הזוגי הגבוה ביותר
    בסיום הכנסה של מספר בתחום מודפס המספר בעל סכום הספרות הזוגיות הגדול ביותר
    """
    num = 1
    maxSum = -1
    maxNum = -1

    while not (10 <= num <= 99):
        num = int(input("Enter number: "))

        if 10 <= num <= 99:
            break

        temp = num
        evenSum = 0

        while temp != 0:
            digit = temp % 10

            if digit % 2 == 0:
                evenSum += digit

            temp //= 10

        if evenSum > maxSum:
            maxSum = evenSum
            maxNum = num

    print(maxNum)

# ------------------------------------------------
'''
Q4( )
Enter integer numbers [two-digit for end]: 
number: 8
number: 3135
number: 967
number: 1234321
number: 125
number: 989
number: 271
number: 894
number: 15
894
'''

# ------------------------------------------------
#                   Q5
# ------------------------------------------------
def Q5(n):
    """
    הפונקציה מקבלת מספר אי זוגי בתחום המתאים ומדפיסה צורה סימטרית בעלת מבנה של יהלום
    בכל שורה יודפסו ספרות לפי סדר עולה עד תשע ולאחר מכן חוזר לספרה אחת
    הפונקציה מאזנת את הרווחים בכל שורה כך שהמבנה מודפס בצורה ממורכזת
    """

    if not (n % 2 == 1 and 1 <= n <= 19):
        print("Number must be odd and in the range [1-19].")

    else: # אם המספר תקין

        length = 1
        num = 1

        while length <= n:
            spaces = " " * ((n - length) // 2) # איזון הרווחים בין צד שמאל וימין כך שהמבנה יהיה מודפס בצורה ממורכזת
            print(spaces, end="")

            for i in range(length):
                print(num, end="")

                if num == 9:
                    num = 1
                else:
                    num += 1

            print(spaces, end="")
            print()

            length += 2

        length -= 4 # בלולאה הקודמת נוסף אורך 2 אקסטרה ולכן נצטרך גם לקזז אותו וגם בעוד 2 עבור השורה הבאה סהכ קיזוז של אורך 4
        while length >= 1:
            spaces = " " * ((n - length) // 2) # מספר רווחים שמאוזן לפי שני הצדדים שתלוי באורך הנוכחי של השורה
            print(spaces, end="")

            for i in range(length):
                print(num, end="")

                if num == 9:
                    num = 1
                else:
                    num += 1

            print(spaces)
            length -= 2


# ------------------------------------------------
'''
>>> Q5( 11 )
     1
    234
   56789
  1234567
 891234567
89123456789
 123456789
  1234567
   89123
    456
     7
>>> Q5( 19 )
         1
        234
       56789
      1234567
     891234567
    89123456789
   1234567891234
  567891234567891
 23456789123456789
1234567891234567891
 23456789123456789
  123456789123456
   7891234567891
    23456789123
     456789123
      4567891
       23456
        789
         1
>>> Q5( 1 )
1
'''
