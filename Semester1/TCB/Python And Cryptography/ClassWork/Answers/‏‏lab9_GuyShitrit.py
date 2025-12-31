# Assignment: 9
# Author: Guy Shitrit, ID: 330707761

def Count(tup, val):
    count = 0

    for i in range(len(tup)):
        if tup[i] == val: # אם הערך מופיע במיקום הנוכחי, תוסיף לסופר
            count += 1

    return count


def double_tup(tup):
    if len(tup) % 2 == 1: # לא יכול להיות רצף מספרים כפול עבור רצף עם אורך אי זוגי
        return False

    middle = len(tup) // 2

    for i in range(middle): # עובר על חצי מהמערך כיוון שאנחנו בודקים שני איברים בו זמנית וזה גם עוזר כי זה עוזר לנו גם לבדוק מהאמצע
        if tup[i] != tup[middle + i]:
            return False

    return True

def max_grades(tupA, tupB):
    def max(n1, n2): # פונקציית עזר פשוטה שבודקת ערך מקסימלי בין שני מספרים
        if n1 >= n2:
            return n1
        return n2

    res = ()
    for i in range(len(tupA)): # אנחנו מניחים שהאורכים של שני הרצפים שווים כי זה מועד א ומועד ב
        res += (max(tupA[i], tupB[i]),)

    return res

def insort(tup, val):
    # נשתמש באלגוריתם של חיפוש בינארי
    left, right = 0, len(tup) - 1

    while left <= right:
        middle = (left + right) // 2

        if tup[middle] > val:
            right = middle - 1

        elif tup[middle] < val:
            left = middle + 1

        else:
            break

    res = tup[:left] + (val,) + tup[left:]

    return res

def even_odd(tup):
    odds = ()
    evens = ()

    for i in range(len(tup)):
        if tup[i] % 2 == 0:
            evens += (tup[i],) # הוסף לרצף עזר של זוגיים
        else:
            odds += (tup[i],) # הוסף לרצף עזר של אי-זוגיים

    return evens + odds





