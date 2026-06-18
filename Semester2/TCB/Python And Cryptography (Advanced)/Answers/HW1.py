from functools import reduce

def Q1(arr):
    """מחזירה את המספרים שסכום הספרות שלהם הוא המינימלי או המקסימלי"""
    def sumdigits(num):
        num = -num if num < 0 else num
        summ = 0

        while(num > 0):
            summ += num % 10
            num //= 10

        return summ
    minn, maxx = sumdigits(arr[0]), sumdigits(arr[0])

    for num in arr:
        if sumdigits(num) > maxx:
            maxx = sumdigits(num)

        if sumdigits(num) < minn:
            minn = sumdigits(num)

    minn_arr = [num for num in arr if sumdigits(num) == minn]
    maxx_arr = [num for num in arr if sumdigits(num) == maxx]

    return minn_arr + maxx_arr

print(Q1([7,-17,23,145,809,-14,93,-6,5,-377,78]))
print(Q1([23,-5]))


def Q2(num, slice):
    """מבצעת חיתוך על ספרות המספר לפי מחרוזת חיתוך"""
    sign = -1 if num < 0 else 1
    num *= sign

    parts = slice[1:-1].split(":")
    parts = [None if p == "" else int(p) for p in parts]

    while len(parts) < 3:
        parts.append(None)

    start, end, step = parts

    digits = str(num)
    res = digits[start:end:step]

    if sign == -1:
        return "-" + res
    return res

print(Q2(-1234567,'[1:-1]'))
print(Q2(-1234567,'[3:]'))
print(Q2(1234567,'[:5]'))
print(Q2(-1234567,'[1:-1:2]'))
print(Q2(1234567,'[::3]'))
print(Q2(-1234567,'[::-1]'))
print(Q2(-1234567,'[-2:0:-2]'))
print(Q2(1234567,'[2:10:2]'))


def Q3a(grades):
    """סופרת כמה ציונים (לאחר עיבוד) נמצאים בטווח עובר"""
    return reduce(lambda accum, _: accum + 1, filter(lambda grade: 55 <= grade <= 100, map(lambda num: 10 * (num ** 0.5), filter(lambda x: 0 <= x <= 100, grades))), 0)

print(Q3a([46,199,77,100,199,14]))

def Q3b(grades, func):
    """בודקת האם כל הציונים (לאחר עיבוד ובלי 199) תקינים"""
    return reduce(lambda accum, x: accum and (55 <= x <= 100 and not (x > 100)), map(lambda num: func(num), filter(lambda x: x != 199, grades)), True)

print(Q3b([46,199,77,100,199],lambda x:x+15))
print(Q3b([46,199,77,199],lambda x:x+15))
print(Q3b([46,199,77,100,199,20],lambda x:x+15))


def Q4(funcs,data):
    """מחזירה איברים שעבורם בדיוק פונקציה אחת מחזירה אמת"""
    return (lambda f, d: tuple(dat for dat in d if [func(dat) for func in f].count(True) == 1))(funcs, data)

print(Q4((lambda x: x>0, lambda x: x%2==0, lambda x: 9<abs(x)<100),(20,-45,133,8,400,7,-300,68)))


marks=[('David',80),('Tali',45),('Moshe',86),('Yanir',80)]

Q5a = lambda x: reduce(lambda accum, x: accum and x, [55 <= val[1] <= 100 for val in x], True)
"""בודקת האם כל הציונים בטווח 55-100"""
print(Q5a(marks))
print(Q5a(marks[:1]+marks[2:]))

Q5b = lambda x: list(filter(lambda v: v is not None, map(lambda val: val[0] if not 55 <= val[1] <= 100 else None, x)))
"""מחזירה שמות של תלמידים עם ציון נכשל"""
print(Q5b(marks))
print(Q5b(marks+[('Ran',50)]))

Q5c = lambda x: list(map(lambda tup: (tup[0], tup[1] + 100 - max([tup[1] for tup in x])), x))
"""מעלה את כל הציונים כך שהציון הגבוה ביותר יהיה 100"""
print(Q5c(marks))
print(Q5c(marks+[('Ran',95)]))

Q5d = lambda x: (lambda nums: len([num for num in nums if nums.count(num) > 1]) > 0)([tup[1] for tup in x])
"""בודקת האם יש ציונים כפולים"""
print(Q5d(marks))
print(Q5d(marks[:-1]))
