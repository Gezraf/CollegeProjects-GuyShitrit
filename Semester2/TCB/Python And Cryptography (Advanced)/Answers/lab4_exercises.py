from functools import reduce


def Q1(s):
    return {num for num in s if num % 2 == 0}


def Q2(text):
    s = set()
    res = []
    for word in text.split():
        if word.lower() not in s:
            s.add(word.lower())
            res.append(word)

    return ' '.join(res)


def Q31(arr):
    res = []
    for num in arr:
        if len(set(str(abs(num)))) == len(str(abs(num))):
            res.append(num)

    return res


def Q32(arr):
    return list(filter(lambda num: len(set(str(abs(num)))) == len(str(abs(num))), arr))


def Q33(arr):
    return [num for num in arr if len(set(str(abs(num)))) == len(str(abs(num)))]


def Q4(s):
    types = set()
    res = ()
    for elem in s:
        if type(elem) not in types:
            types.add(type(elem))

    for typ in types:
        res += (set(filter(lambda elem: type(elem) == typ, s)),)

    return res


# Q5
def doSet(tup):
    temp = []
    for num in tup:
        if num not in temp and 1 <= num <= 20:
            temp.append(num)

    return sorted(temp)

def inSet(arr, val):
    return val in arr

def notInSet(arr, val):
    return not inSet(arr, val)

def view(arr):
    return "{" + ','.join(str(num) for num in arr) + "}"


def notSet(arr):
    return [num for num in range(1, 21) if notInSet(arr, num)]


def union(arr1, arr2):
    return doSet(arr1 + arr2) # שני המערכים ממילא אמורים להיות ממוינים כי הם מתקבלים כרשימות שמייצגות קבוצות

def xor(arr1, arr2):
    def intersect(arr1, arr2): # פונקציית חיתוך כדי שהכל ייראה נקי לפי נוסחה
        return doSet([num for num in arr1 if num in arr2])

    return intersect(notSet(intersect(arr1, arr2)), union(arr1, arr2)) # p xor q = not(p and q) and (p or q)