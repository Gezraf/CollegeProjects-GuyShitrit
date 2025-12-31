# Assignment: 10
# Author: Guy Shitrit, ID: 330707761

def Q1(nums):
    def leftDigit(num): # פונקצייה שמחזירה את הספרה הגבוהה (השמאלית) של מספר
        if 0 <= num <= 9:
            return num

        while num > 9:
            num //= 10

        return num

    for i in range(2, len(nums), 3): # מתחיל מהמספר השלישי וקופץ בקפיצות של 3
        nums[i] = leftDigit(nums[i-1]) * 10 + nums[i-2] % 10 # החלפת המספר לפי מה שביקשו בשאלה


def Q2(nums):
    def reverseNum(num): # פונקצייה שמחזירה מספר הפוך למספר שנשלח
        res = 0

        while num != 0:
            digit = num % 10
            res = res * 10 + digit
            num //= 10

        return res

    res = []

    for num in nums:
        temp = num
        evens = [] # מערך ששומר את הספרות הזוגיות של המספר הנוכחי
        odds = [] # מערך ששומר את הספרות האי-זוגיות של המספר הנוכחי

        while temp > 0:
            digit = temp % 10
            if digit % 2 == 0:
                evens.append(digit)
            else:
                odds.append(digit)

            temp //= 10

        new_num = 0

        if len(odds) > len(evens): # אם כמות הספרות האי-זוגיות גדול מכמות הספרות הזוגיות
            for i in range(len(odds)):
                new_num = new_num * 10 + odds[i]

        elif len(evens) > len(odds): # אם כמות הספרות הזוגיות גדול מכמות הספרות האי-זוגיות
            for i in range(len(evens)):
                new_num = new_num * 10 + evens[i]

        if new_num > 0:
            res.append(reverseNum(new_num)) # נוסיף למערך את המספר שמייצג את סדר הספרות הזוגיות/האי-זוגיות של המספר בהתאם

    return res


def Q3(nums1, nums2):
    counts1 = [0] * 10 # שני מערכים שהאינדקסים שלהם מייצגים ספרות מאפס עד תשע כולל
    counts2 = [0] * 10

    for num in nums1:
        if num == 0: # אם המספר כבר אפס, נוסיף 1 לכמות ההופעות של 0
            counts1[0] += 1
        while num > 0: # כל עוד המספר לא אפס, נוסיף אחד לכמות ההופעות של ספרת האחדות ואז נקזז אותה מהמספר
            digit = num % 10
            counts1[digit] += 1
            num //= 10

    for num in nums2: # פה עשיתי אותו דבר רק למערך השני כדי לעדכן גם אותו
        if num == 0:
            counts2[0] += 1
        while num > 0:
            digit = num % 10
            counts2[digit] += 1
            num //= 10

    return counts1 == counts2


def Q4(nums):
    def leftDigit(num): # פונקצייה שמחזירה את הספרה הגבוהה (השמאלית) של מספר
        if 0 <= num <= 9:
            return num

        while num > 9:
            num //= 10

        return num

    nums.sort(key=lambda x: leftDigit(x)) # מיון לפי הספרות השמאליות של המספרים במערך
    return nums


def Q5(nums):
    def evensCount(num): # פונקצייה שמחזירה כמות ספרות זוגיות של מספר
        if num == 0:
            return 1 # אפס נחשב זוגי

        count = 0
        while num > 0:
            digit = num % 10
            if digit % 2 == 0:
                count += 1
            num //= 10

        return count

    nums.sort(key = lambda x: evensCount(x)) # מיון לפי כמות הספרות הזוגיות של המספרים במערך
    return nums


def Q6(nums, n):
    def digitSum(num): # פונקצייה שמחזירה סכום ספרות
        summ = 0

        while num > 0:
            summ += num % 10
            num //= 10

        return summ

    res = ()

    for num in nums:
        if digitSum(num) == n:
            res += (num,)

    if len(res) == 0: # אם הרצף ריק נחזיר הודעת שגיאה
        return 'not found'
    elif len(res) == 1: # אם הרצף הוא מספר אחד נחזיר את המספר
        return res[0]

    return res # אחרת נחזיר רצף של מספרים
