from functools import reduce


def Q1(x, y):
    return x ** y if y % 2 == 0 else x ** 0.5


Q2 = lambda num: 1 if num > 0 else (2 if num < 0 else 3) # יחזיר 1 אם חיובי אחרת 2 אם שלילי אחרת 3 (אם אפס)


def Q3_map(tup):
    return sum(map(lambda x: x % 2,tup)) # סוכם את כל התוצאות שארית של המספרים בחילוק ב2

def Q3_generator(tup):
    return sum(1 for num in tup if num % 2 == 1)


def Q4_map(tup):
    return tuple(map(lambda x: int(str(x)[::-1]), tup[::-1]))

def Q4_generator(tup):
    return tuple(int(str(x)[::-1]) for x in tup[::-1])


def Q5_filter():
    return list(filter(lambda num: num % 10 + num // 10 % 10 + num // 100 in [3,8], [num for num in range(100, 1000)]))
# סינון המספרים שסכום ספרתם מתחלק ב3 או 8 מהמספרים התלת ספרתיים
def Q5_generator():
    return list(num for num in range(100, 1000) if num % 10 + num // 10 % 10 + num // 100 in [3,8])


def Q6():
    return reduce(lambda x,y: x * y, [num for num in range(10, 100) if num % 8 == 0]) # תוצאת כפל כל מספר דו ספרתי שמתחלק ב8 במספר העוקב שלו


def Q7(tup):
    return reduce(lambda res,x: res and x % 2 == 0, tup, True)


add = lambda x,y : x + y # (רק בשביל הדוגמת ריצה הראשונה)
def accumulate(initial, function, tup):
    res = initial
    for elem in tup:
        res = function(res, elem)

    return res


def mymap(function, iterable):
    new = ()
    for elem in iterable:
        new += (function(elem), )

    return new