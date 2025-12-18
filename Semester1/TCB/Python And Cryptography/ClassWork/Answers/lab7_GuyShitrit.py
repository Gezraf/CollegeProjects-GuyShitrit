# Assignment: 7
# Author: Guy Shitrit, ID: 330707761

def Q1a(num):
        temp = num
        reversed_num = 0

        while temp != 0:
            digit = temp % 10
            reversed_num = reversed_num * 10 + digit
            temp //= 10

        res = 0
        while reversed_num != 0:
            digit = reversed_num % 10
            if digit % 2 == 0:
                res = res * 10 + digit
            reversed_num //= 10

        return res


f11 = lambda n: n % 2 == 0        # even digit?
f12 = lambda n: n % 10            # last digit
f13 = lambda n: n // 10           # drop last digit
f14 = lambda n: n * 10            # multiply by 10
f15 = lambda n, d: n + d     # append digit

def f16(n):  # מחזיר פרמטר עם סדר ספרות הפוך
    reversed_num = 0
    while n != 0:
        digit = f12(n)
        reversed_num = f15(f14(reversed_num), digit)
        n = f13(n)
    return reversed_num


def Q1b(num):
    temp = num
    reversed_num = 0

    while temp != 0:
        digit = f12(temp)
        reversed_num = f15(f14(reversed_num), digit)
        temp = f13(temp)

    res = 0
    while reversed_num != 0:
        digit = f12(reversed_num)
        if f11(digit):
            res = f15(f14(res), digit)
        reversed_num = f13(reversed_num)

    return res


def Q1c(num):
    f11 = lambda n: n % 2 == 0           # האם מספר זוגי
    f12 = lambda n: n % 10               # ספרה אחרונה
    f13 = lambda n: n // 10              # הורדת ספרה אחרונה
    f14 = lambda n: n * 10               # הכפלה ב-10
    f15 = lambda n, digit: n + digit   # הוספת ספרה לסוף

    def f16(n):  # מחזיר פרמטר עם סדר ספרות הפוך
        reversed_num = 0
        while n != 0:
            digit = f12(n)
            reversed_num = f15(f14(reversed_num), digit)
            n = f13(n)
        return reversed_num

    reversed_num = f16(num)

    res = 0
    while reversed_num != 0:
        digit = f12(reversed_num)
        if f11(digit):                       # אם הספרה זוגית
            res = f15(f14(res), digit)       # res = res * 10 + digit
        reversed_num = f13(reversed_num)

    return res


def Q2(num):
    def is_even(num):
        return num % 2 == 0

    def sum_digits(num, flag=-1): # ערך דיפולטיבי בהתחלה בשביל חישוב הספרות ואז מתן ערכים בהמשך בהתאם לחישוב ספרות זוגיות או אי זוגיות
        sum = 0
        while num != 0:
            digit = num % 10
            if flag == 0 or flag == 1:
                if digit % 2 == flag:
                    sum += num % 10
            else:
                sum += num % 10
            num //= 10

        return sum


    digit_sum = sum_digits(num)

    if is_even(digit_sum):
        return sum_digits(num, flag=0)

    return sum_digits(num, flag=1)


def Q3(num1, num2):
    if num2 > num1 or num1 < 0 or num2 < 0: # ייצא מוקדם אם המספר השני גדול מהראשון או אם אחד/שני המספרים שליליים
        return -1

    mul = lambda x,y: x * y
    sum = lambda x,y: x + y
    diff = lambda x,y: x - y

    def length(num):
        if num == 0:
            return 1

        count = 0
        while num != 0:
            count += 1
            num //= 10

        return count


    mul_res = mul(num1, num2)
    sum_res = sum(num1, num2)
    diff_res = diff(num1, num2)

    sum_len = length(sum_res)
    diff_len = length(diff_res)


    res = (  mul_res * (10 ** (sum_len + diff_len))
           + sum_res * (10 ** diff_len)
           + diff_res)


    return res


def Q4():
    f1 = (lambda x: x-1) # מחזיר מספר שקטן ב1 מהפרמטר
    f2 = (lambda x: x//100 + (x//10) % 10 + x % 10) # מאות + עשרות + אחדות
    f3 = (lambda x: x > 0 ) # בדיקה האם המספר חיובי
    f4 = (lambda x: (x // 10 + x % 10) % 2 == 0) # בדיקת האם סכום הספרות זוגי
    f5 = (lambda x: (x//1000 == x % 10) and (x // 100 % 10 == x // 10 % 10)) # השוואת ספרה רא שונה עם ספרה אחרונה, וספרה שנייה עם ספרה שלישית
    f6 = (lambda x: x % 10 * 10 + x // 10) # החלפת ספרת עשרות עם ספרת אחדות
    f7 = (lambda x,y: x - y) # הפרש
    f8 = (lambda x,y: x**y) # חזקה
    f9 = (lambda x,y,z: 100 <= (x + y + z) <= 999) # בדיקת טווח מספר תלת ספרתי לסכום הפרמטרים


    x1 = int(input("Enter number: ")) # א
    print(f1(x1))

    x2 = int(input("Enter number: ")) # ב
    if 100 <= x2 <= 999:
        print(f2(x2))

    x3 = float(input("Enter number: ")) # ג
    print(f3(x3))

    x4 = int(input("Enter number: ")) # ד
    print(f4(x4))

    x5 = int(input("Enter number: ")) # ה
    print(f5(x5))

    x6 = int(input("Enter number: ")) # ו
    print(f6(x6))

    x7, y7 = float(input("Enter number 1: ")), float(input("Enter number 2: ")) # ז
    print(f7(x7,y7))

    x8, y8 = int(input("Enter number 1: ")), int(input("Enter number 2: ")) # ח
    print(f8(x8, y8))

    x9, y9, z9 = int(input("Enter number 1: ")), int(input("Enter number 2: ")), int(input("Enter number 3: ")) # ט
    print(f9(x9,y9,z9))

Q4()


