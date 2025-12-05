# Assignment: 6
# Author: Guy Shitrit, ID: 330707761

def Q1(n):
    x = 0
    y = 1

    for i in range(n):
        print(f"{x},",end="")
        temp = x + y
        x = y
        y = temp


def Q2():
    for num in range(1001, 10000, 2): # קפיצות של 2 החל מ1001 מוודא שהמספר תמיד יהיה אי זוגי
        thousands = num // 1000
        hundreds = num // 100 % 10
        tens = num // 10 % 10
        ones = num % 10

        sum1 = thousands + hundreds
        sum2 = tens + ones

        if sum1 == sum2:
            print(num)


def Q3(n):
    def selfExponent(num):
        temp = num
        for i in range(num - 1):
            num *= temp
        return num

    summ = 0

    for i in range(1, n + 1):
        summ += selfExponent(i)

    return summ

def Q4():
    for num in range(10000, 100000):
        ten_thousands = num // 10000
        thousands = num // 1000 % 10
        hundreds = num // 100 % 10
        tens = num // 10 % 10
        ones = num % 10

        if ones > tens > hundreds > thousands > ten_thousands:
            print(num)

def Q5(n):
    if not (1 <= n <= 9):
        print("Number must be in the range [1-9].")
    else:
        for i in range(n+1):
            if i % 2 == 1: # אם האיטרציה אי זוגית
                for j in range(1, i+1):
                    print(j, end="")
                print()
            else: # אם האיטרציה זוגית
                for j in range(i, 0, -1):
                    print(j, end="")
                print()

def Q6(n):
    asterisks = 1
    for i in range(n):
        res = "*" * asterisks
        spaces = " " * (n-i)
        print(f"{spaces}{res}{spaces}")
        asterisks += 2

def Q7(n):
    for i in range(1, n + 1):
        res = "*" * i
        hashtags = "#" * (n-i)
        print(f"{res}{hashtags}")

def Q8(n):
    line = 1
    for i in range(1, n+1):
        spaces = " " * (n - i)

        print(spaces, end="")

        for j in range(1, line+1):
            print(j, end="")

        for j in range(line-1, 0, -1):
            print(j, end="")

        print()
        line += 1

Q8(5)