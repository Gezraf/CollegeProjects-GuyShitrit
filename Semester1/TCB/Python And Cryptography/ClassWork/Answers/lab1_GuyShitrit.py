# תרגילי מעבדה 1
#מגיש: גיא שטרית


from math import sqrt

# Q1 Shell:

# >>> 2+3
# 5
# >>> (2+3.5)/3
# 1.8333333333333333
# >>> a,b,c=2,5,7.3
# >>> (7+3*c)**a
# 835.2099999999999
# >>> (7*b)/3
# 11.666666666666666
# >>> (7*b)//3
# 11
# >>> (7*b)%3
# 2
# >>> a
# 2
# >>> a+=1
# >>> a
# 3
# >>> a*=b
# >>> a
# 15
# >>> print('Numbers: ',a,b,c)
# Numbers:  15 5 7.3


# Q2:

def Q2():
    num = int(input("Enter your number: "))
    print(f"{num} {num + 1} {num - 1}")


# Q3:

def Q3():
    num1 = float(input("Enter number 1: "))
    num2 = float(input("Enter number 2: "))
    print(f"Sum: {num1 + num2}\nSub: {abs(num1 - num2)}\nMul: {num1 * num2}")


# Q4:

def Q4():
    def expression1(a, b, c):
        expr1 = (a + (b-2) / (c + 5)) ** 5 + 18 / a
        return expr1

    def expression2(a, b, c):
        expr2 = sqrt(1/a - a / (2*b /(c-5)))
        return expr2

    a = 2
    b = 3
    c = 4
    res1_expr1 = expression1(a,b,c)
    res1_expr2 = expression2(a,b,c)
    print(f"res1: {res1_expr1}\nres2: {res1_expr2}")

    a = 3.5
    b = 2.5
    c = -17
    res2_expr1 = expression1(a,b,c)
    res2_expr2 = expression2(a,b,c)
    print(f"res1: {res2_expr1}\nres2: {res2_expr2}")


if __name__ == "__main__":
    Q2()
    Q3()
    Q4()

    #תקרא בבקשה לכל פונקציה בנפרד כדי לבדוק שאלה שאלה
