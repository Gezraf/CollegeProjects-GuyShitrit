# ------------------------------------------------
# Name: Guy Shitrit
# ID: 330707761
# ------------------------------------------------
#                   Q1
# ------------------------------------------------
def minThree(n1, n2, n3):
    """
    הפונקציה מקבלת שלושה מספרים ממשיים ומחזירה את המספר הקטן ביותר מביניהם
    הפונקציה משתמשת בפונקציית עזר בשם minTwo אשר מחזירה את המספר הקטן מבין שני מספרים
    הפונקציה אינה משתמשת ב if ישיר אלא נשענת על הפונקציה minTwo
    """

    def minTwo(n1, n2):
        if n1 <= n2:
            return n1
        return n2
    return minTwo(minTwo(n1, n2), n3)
# ------------------------------------------------
'''
minThree(4,1,2)
1
minThree(4,2,2)
2
minThree(4,1,7)
1
'''

# ------------------------------------------------
#                   Q2
# ------------------------------------------------
def arrangeDigits( num ):
    """
    הפונקציה מקבלת מספר שלם וחיובי ומחזירה מספר חדש
    במספר המוחזר כל הספרות הזוגיות מופיעות תחילה ולאחריהן כל הספרות האי זוגיות
    סדר הופעת הספרות נשמר כפי שהיה במספר המקורי
    הפונקציה עושה שימוש בפונקציות עזר לצורך פירוק מספרים ובניית מספר חדש
    """

    def lastDigit( x ):
        return x % 10
    def withOutTheLastDigit( x ):
        return x // 10
    def isEven( x ):
        return x % 2 == 0
    def addDigit( x, y ):
        return x * 10 + y
    def reverseNumber( x ):
        res = 0

        while x != 0:
            res = addDigit(res, lastDigit(x))
            x = withOutTheLastDigit(x)

        return res

    temp1 = temp2 = reverseNumber(num)
    res = 0

    while temp1 != 0: # ספרות זוגיות תחילה
        digit = lastDigit(temp1)
        if isEven(digit):
            res = addDigit(res, digit)

        temp1 = withOutTheLastDigit(temp1)

    while temp2 != 0: # ואז חיבור הספרות האי זוגיות כך שיהיו בסוף
        digit = lastDigit(temp2)
        if not isEven(digit):
            res = addDigit(res, digit)

        temp2 = withOutTheLastDigit(temp2)

    return res

# ------------------------------------------------
'''
arrangeDigits(12345)
24135
arrangeDigits(46842)
46842
arrangeDigits(1375)
1375
arrangeDigits(13574628)
46281357
arrangeDigits(12547638)
24681573
'''
# ------------------------------------------------
#                   Q3
# ------------------------------------------------



def printPyramid(n):
    """
    הפונקציה מקבלת מספר שלם וחיובי ומדפיסה פירמידה הבנויה מסימני סולמית ומספרים
    גובה הפירמידה נקבע לפי הערך שהתקבל כפרמטר
    הפונקציה עושה שימוש בפונקציית עזר אשר מדפיסה תו מספר מסוים של פעמים
    """

    def printChars(ch, n): # פונקציה פשוטה שמדפיסה תו מסוים מספר מסוים של פעמים
        for i in range(n):
            print(ch, end="")

    printChars(" ", n-1)  # ההאשטאג הראשון
    print("#", end="")

    print()
    for i in range(1, n - 1):
        printChars(" ", n - i - 1) # רווחים בצד שמאל

        print("#", end="")

        for num in range(i, 0, -1): # מספרים יורדים
            print(num, end="")

        for num in range(2, i + 1): # מספרים עולים
            print(num, end="")

        print("#")

    printChars("#", 2 * n) # "הרצפה"

# ------------------------------------------------
'''        
printPyramid(9)
        #
       #1#
      #212#
     #32123#
    #4321234#
   #543212345#
  #65432123456#
 #7654321234567#
#################
'''

# ------------------------------------------------
#                   Q4
# ------------------------------------------------
def sumNums( n ):
    """
    הפונקציה מקבלת מספר שלם וחיובי ומבצעת קליטה של n מספרים תלת ספרתיים
    הפונקציה מחשבת את סכום המספרים אשר הספרה האמצעית שלהם היא ספרה זוגית
    הפונקציה משתמשת בפונקציות אנונימיות לצורך בדיקת זוגיות חישוב סכום ושליפת ספרה אמצעית
    """

    i = 0
    num = 0

    middleDigit = lambda n: n // 10 % 10
    isEven = lambda n: n % 2 == 0
    sumTwo = lambda x, y: x + y

    res = 0

    print(f"Enter {n} three-digit numbers:")
    while i < n:
        num = int(input("Number: "))
        while not (100 <= num <= 999):
            num = int(input("Invalid input, please enter a valid three-digit number: "))

        digit = middleDigit(num)
        if isEven(digit):
            res = sumTwo(res, num)

        i += 1

    return res

# ------------------------------------------------
'''
sumNums( 10 )
Enter 10 Triple digits number: 
number: 123
number: 410
number: 354
number: 222
number: 978
number: 777
number: 555
number: 202
number: 111
number: 432
547
'''

# ------------------------------------------------
#                   Q5
# ------------------------------------------------
from random import randrange
def doGame( level = 1 ):
    """
    הפונקציה מפעילה משחק זיכרון הבנוי משלבים עוקבים
    בכל שלב מוצג מספר אקראי שאורכו גדל עם ההתקדמות במשחק
    המשתמש נדרש לבצע משימה אחת מתוך מספר משימות אפשריות הקשורות למספר
    אם המשתמש עונה נכון הוא צובר נקודות ומתקדם לשלב הבא
    אם המשתמש טועה המשחק מסתיים ומוצג הניקוד הסופי
    הפונקציה משתמשת בפונקציה randrange ליצירת מספרים אקראיים
    """

    def sumDigits( x ):
        res = 0

        while x != 0:
            digit = x % 10
            res += digit
            x //= 10

        return res

    def reverseNumber( x ):
        res = 0

        while x != 0:
            digit = x % 10
            res = res * 10 + digit
            x //= 10

        return res

    def sumMaxMinDigits( x ):
        minn = maxx = x % 10 # ערך של ספרה אחרונה סתם על ההתחלה, לאחר מכן יתבצע חישוב ספרה מקסימלית ומינימלית

        while x != 0:
            digit = x % 10

            if digit < minn:
                minn = digit
            if digit > maxx:
                maxx = digit

            x //= 10

        return minn + maxx

    def getLength(n): # פונקציית עזר
        length = 0
        while n != 0:
            length += 1
            n //= 10
        return length

    def shiftLeft(x):
        def popLeft(x):
            return x % (10 ** (length - 1))

        length = getLength(x)
        leftDigit = x // (10 ** (length - 1))


        length = getLength(x)

        res = popLeft(x)
        res = res * 10 + leftDigit # הוסף את הספרה השמאלית לפני ההזזה כך שתהיה הספרה הימנית לאחר ההזזה

        return res

    current_length = 3
    points = 0

    while True:
        num = randrange(10 ** (current_length - 1), 10 ** current_length)
        task = randrange(1,5) # משתנה שמייצג את המשימה שהתוכנית תבחר בשביל המשתמש מתוך ארבעת המשימות הקיימות

        print(f"\nLevel {level}")
        print(f"The number: {num}")
        print(f"Remember the number and press enter to lock-in your answer...\n")

        if task == 1:
            ans1 = sumDigits(num)
            user_ans1 = int(input("The sum of all digits is: "))

            if user_ans1 != ans1:
                break

        elif task == 2:
            ans2 = reverseNumber(num)
            user_ans2 = int(input("The reverse number is: "))

            if user_ans2 != ans2:
                break

        elif task == 3:
            ans3 = sumMaxMinDigits(num)
            user_ans3 = int(input("The sum of max and min digits is: "))

            if user_ans3 != ans3:
                break

        elif task == 4:
            ans4 = shiftLeft(num)
            user_ans4 = int(input("The shift left number is: "))

            if user_ans4 != ans4:
                break


        # (אם השחקן עבר את השלב, יתווסף לו לניקוד והוא יעבור לשלב הבא, (המספר בשלב הבא יהיה עם ספרה אחת יותר
        points += current_length
        level += 1
        current_length += 1

    print(f"\nGame over!\nYou win {points} points.")

# ------------------------------------------------
'''
>>> doGame( )
Level 1
The number: 459
Remember number and Press enter...

The sum of all digits is: 18

Level 2
The number: 5746
Remember number and Press enter...

The shift left number is: 7465

Level 3
The number: 12156
Remember number and Press enter...

The reverse number is: 65121

Level 4
The number: 844502
Remember number and Press enter...

The reverse number is: 205448

Level 5
The number: 4068412
Remember number and Press enter...

The sum of max and min digits: 1

Game over
You win 18 points
'''
