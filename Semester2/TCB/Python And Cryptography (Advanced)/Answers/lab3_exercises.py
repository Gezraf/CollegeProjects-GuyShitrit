from functools import reduce

def countPast(arr):
    return len(list(filter(lambda x: 55 <= x <= 100, arr)))



def reverse2Digits(arr):
    def reverseNum(num):
        sign = 1 if num > 0 else -1
        num *= sign

        res = 0
        while (num > 0):
            digit = num % 10
            res = res * 10 + digit
            num //= 10

        return res * sign

    res = filter(lambda num: str(num)[0] != '-' and len(str(num)) == 2 or (str(num)[0] == '-' and len(str(num)) == 3), arr)
    return tuple(reverseNum(num) for num in res)



def retEvens3Times(tup):
    return tuple(num for num in filter(lambda x: x % 2 == 0, tup) for _ in range(3))


def convertStrToIntList(string):
    return list(filter(lambda x: int(x) if x.isnumeric() else None, string.replace(',', '').split()))


def retClearText(string):
    return ' '.join(word.lower() for word in filter(lambda x: x.isalpha(), string.split()))


def getRound(arr):
    return list(map(lambda val: round(val[1], val[0] + 1), enumerate(arr)))


def doPower(tup):
    def calc(x, y):
        if x < 0 and y < 0:
            return None
        elif y < 0:
            return x ** (1 / -y)

        return x ** y

    return tuple(filter(lambda x: x is not None, (reduce(lambda x, y: calc(x, y), pair) for pair in tup)))
