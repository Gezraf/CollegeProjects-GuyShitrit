# Assignment: 5
# Author: Guy Shitrit, ID: 330707761

def Q1(num):
    evenCount = 0

    while (num != 0):
        digit = num % 10

        if digit % 2 == 0:
            evenCount += 1

        num //= 10

    return evenCount

def Q2(num):
    def sum_digits(num): # פונקציה שמחזירה את סכום ספרות מספר כלשהו
        summ = 0
        while (num != 0):
            digit = num % 10
            summ += digit
            num //= 10

        return summ

    while not (0 <= num <= 9): # כל עוד המספר לא חד ספרתי לאחר השמתו לסכום ספרותיו
        num = sum_digits(num)

    return num

def Q3():
    def is_symmetric(num):
        temp = num
        reversed_num = 0

        while (temp != 0):
            digit = temp % 10
            reversed_num = reversed_num * 10 + digit
            temp //= 10

        return num == reversed_num

    num = -1
    maxx = -1

    while (num != 0):
        num = abs(int(input("Enter a number (enter 0 to stop): ")))  # מוודא שכל קלט חיובי ושלם

        if is_symmetric(num) and num > maxx:
            maxx = num

    return maxx # הפעם בשאלה כתוב להחזיר ערך ולא להדפיס

def Q4(n1, n2):
    n1 = abs(n1)
    n2 = abs(n2)

    for d in range(10):
        count_n1 = 0
        count_n2 = 0

        temp = n1
        while temp > 0:
            if temp % 10 == d:
                count_n1 += 1
            temp //= 10

        temp = n2
        while temp > 0:
            if temp % 10 == d:
                count_n2 += 1
            temp //= 10

        if count_n1 != count_n2:
            return False

    return True

def Q5():
    num1 = float(input("Enter a number: "))
    num2 = num1 - 1 # ערך זבל שבחיים לא שווה לערך הראשון כדי שייכנס ללולאה
    first_num = num1 # המספר הראשון שנקלט

    ASCENDING, DESCENDING = 0, 0

    while True:
        num1 = float(input("Enter a number: "))

        if num1 == first_num: # אם זה שווה למספר הראשון, צא מהלולאה מוקדם
            break

        num2 = float(input("Enter a number: "))

        if num2 > num1:
            ASCENDING = 1
        if num2 < num1:
            DESCENDING = 1

        if num2 == first_num:  # אם המספר השני שווה לראשון, צא מהלולאה
            break

    if ASCENDING and DESCENDING:
        print("Not ascending and not descending")
    elif ASCENDING:
        print("Ascending")
    elif DESCENDING:
        print("Descending")


def Q6(num):
    if num <= 1: # אפס ואחד הם לא ראשוניים
        return False

    for i in range(2, num):
        if num % i == 0: # אם יש מחלק למספר אז המספר לא ראשוני
            return False

    return True