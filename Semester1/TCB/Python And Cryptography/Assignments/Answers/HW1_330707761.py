# ------------------------------------------------
# Name: Guy Shitrit
# ID: 330707761
# ------------------------------------------------
#                   Q1
# ------------------------------------------------
def Q1(num):
    if 10000 <= num <= 99999:
        oddSum = 0

        ones = num % 10
        tens = (num // 10) % 10
        hundreds = (num // 100) % 10
        thousands = (num // 1000) % 10
        ten_thousands = num // 10000

        print("Even digits: ", end="")
        if ones % 2 == 0: #אם הספרה זוגית
            print(f"{ones}, ", end="") # הדפס את הספרה הזוגית
        else:
            oddSum += ones #אחרת הוסיף לסכום הספרות האי-זוגיות את הספרה

        if tens % 2 == 0:
            print(f"{tens}, ", end="")
        else:
            oddSum += tens

        if hundreds % 2 == 0:
            print(f"{hundreds}, ", end="")
        else:
            oddSum += hundreds

        if thousands % 2 == 0:
            print(f"{thousands}, ", end="")
        else:
            oddSum += thousands

        if ten_thousands % 2 == 0:
            print(f"{ten_thousands}", end="")
        else:
            oddSum += ten_thousands


        print(f"\nSum odd digits: {oddSum}")
    else:
        print("The number must be 5-digits long.")

# ------------------------------------------------
#                   Q2
# ------------------------------------------------
def Q2(n1, n2, n3, n4):
    biggest = n1  # נניח שהמספר הראשון הוא הגדול ביותר תחילה

    if n2 > biggest:
        biggest = n2

    if n3 > biggest:
        biggest = n3

    if n4 > biggest:
        biggest = n4

    return biggest

# ------------------------------------------------
#                   Q3
# ------------------------------------------------
def Q3(num):
    # הערה לבודק: ההרצות בדיקה עבור פונקציה זו לא נכונות כי הן מחזירות אמת עבור מספרים בעל 5-ספרות ולא 4-ספרות
    """
    תנאים לסיסמה תקינה:
    1) כל הספרות שונות
    2) המספר כולל גם ספרות זוגיות וגם אי-זוגיות
    3) סכום כל הספרות הוא בין 10 ל-30
    """

    if 1000 <= num <= 9999:
        ones = num % 10
        tens = num // 10 % 10
        hundreds = num // 100 % 10
        thousands = num // 1000

        flag1 = (
                    ones != tens and
                    ones != hundreds and
                    ones != thousands and
                    tens != hundreds and
                    tens != thousands and
                    hundreds != thousands
                )
                # בדיקה קפדנית שבודקת האם כל הספרות שונות זו מזו

        has_even = False
        has_odd = False

        if thousands % 2 == 0:
            has_even = True
        if thousands % 2 == 1:
            has_odd = True

        if hundreds % 2 == 0:
            has_even = True
        if hundreds % 2 == 1:
            has_odd = True

        if tens % 2 == 0:
            has_even = True
        if tens % 2 == 1:
            has_odd = True

        if ones % 2 == 0:
            has_even = True
        if ones % 2 == 1:
            has_odd = True

        flag2 = (has_even and has_odd) # האם מכיל גם ספרה זוגית לפחות וספרה אי-זוגית לפחות

        summ = ones + tens + hundreds + thousands # סכום כל הספרות
        flag3 = (10 <= summ <= 30) # בדיקה האם נמצא בטווח

        if not flag1 or not flag2 or not flag3:
            print("This number cannot be used as a password because:")
            if not flag1:
                print("it consists of the same digits")
            if not flag2:
                if has_odd and not has_even:
                    print("it consists of odd digits")
                elif has_even and not has_odd:
                    print("it consists of even digits")
            if not flag3:
                if summ < 10:
                    print("sum of digits is smaller than 10")
                elif summ > 30:
                    print("sum of digits is greater than 30")
            return False

        return True # אם לא יצא מהפונקציה סימן שהמספר תקין ולכן יחזיר אמת

    print("The number must be 4-digits long!")
    return False # אם הסיסמה לא בת 4 ספרות יחזיר שקר


# ------------------------------------------------
#                   Q4
# ------------------------------------------------
def Q4(mark):
    if 0 <= mark <= 100:
        factor = 0
        if mark > 95:
            pass
        elif 86 <= mark <= 95:
            factor = 4
        elif 55 <= mark <= 85:
            factor = 6
        else:
            pass
        
        final_mark = mark + factor # העלאת נקודות לפי הפקטור שניתן בהתאם לטווח הציון

        if mark <= 95:
            print(f"Mark: {mark}\nFactor: {factor}\nFinal Mark: {final_mark}")
        else: # אם הציון מעל 95
            print(f"Mark: {mark}\nFactor: {factor}\nFinal Mark: {100}") # יינתן ציון סופי 100 עבור כל ציון שגדול מ95

    else:
        print("This number can not be marked")

# ------------------------------------------------
#                   Q5
# ------------------------------------------------
def Q5(height, weight):
    BMI = weight / height**2

    if 0 < BMI < 17:
        print("תת-משקל")
    elif 17 <= BMI < 25:
        print("משקל בריא")
    elif 25 <= BMI < 30:
        print("עודף משקל")
    elif 30 <= BMI < 35:
        print("השמנה")
    elif 35 <= BMI < 44:
        print("השמנת יתר")
    else:
        print("השמנת יתר חמורה")