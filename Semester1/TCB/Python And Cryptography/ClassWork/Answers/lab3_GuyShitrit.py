# Lab Assignment 3
# Name: Guy Shitrit, ID: 330707761

def Q1(num):
    if 10000 <= num <= 99999:
        ten_thousands = num // 10000
        thousands = num % 10000 // 1000
        hundreds = num % 10000 % 1000 // 100
        tens = num % 10000 % 1000 % 100 // 10
        ones = num % 10

        res = ten_thousands + thousands + hundreds + tens + ones
        return res

    print("Enter a 5-digit number.")
    return -1

# print(Q1(12345))

def Q2(num):
    if 1000 <= num <= 9999:
        thousands = num // 1000
        hundreds = num  % 1000 // 100
        tens = num % 1000 % 100 // 10
        ones = num % 10

        res = "{}{}{}{}".format(hundreds, tens, ones, thousands)

        return int(res)

    print("Enter a 4-digit number.")
    return -1

# print(Q2(1873))

def Q3(num, n): # n is the base
    def complete_digit(d ,n):
        return (n-1) - d

    if 100 <= num <= 999:
        hundreds = num // 100
        tens = num % 100 // 10
        ones = num % 10

        if n > hundreds and n > tens and n > ones:
            res = "{}{}{}".format(complete_digit(hundreds, n), complete_digit(tens, n), complete_digit(ones, n))
            return int(res)
        else:
            print("The base must be bigger or equal to digit + 1 for each digit in the number for this operation to work.")
            return -1

    print("Please enter a 3-digit number.")
    return -1

print(Q3(241, 5))

def Q4(num):
    def move_up(digit):
        return (digit + 1) % 10

    if 10000 <= num <= 99999:
        ten_thousands = num // 10000
        thousands = num % 10000 // 1000
        hundreds = num % 10000 % 1000 // 100
        tens = num % 10000 % 1000 % 100 // 10
        ones = num % 10

        res = "{}{}{}{}{}".format(move_up(ten_thousands), move_up(thousands), move_up(hundreds), move_up(tens), move_up(ones))
        return int(res)

    print("Please enter a 5-digit number.")
    return -1

# print(Q4(39821))


def Q5(num):
    if 100 <= num <= 999:
        hundreds = num // 100
        tens = num % 100 // 10
        ones = num % 10

        res = "{}{}{}"

        option1 = num
        option2 = res.format(hundreds, ones, tens)
        option3 = res.format(tens, hundreds, ones)
        option4 = res.format(tens, ones, hundreds)
        option5 = res.format(ones, hundreds, tens)
        option6 = res.format(ones, tens, hundreds)

        print("{},{},{},{},{},{}".format(option1, option2, option3, option4, option5, option6)) # יש למספר תלת-ספרתי 3 ספרות מה שאומר שישנם 6 אפשרויות לסידור הספרות סה"כ לפי !3

# Q5(234)


def Q6(a, b, c):
    def add(x, y): return x + y
    def sub(x, y): return x - y
    def mul(x, y): return x * y
    def div(x, y): return x / y
    def power(x, y): return x ** y

    first_expression = div(1, a)
    second_expression = div(a, (div(mul(2, b), sub(c, 5))))

    res = power((add(first_expression, second_expression)),0.5)
    return res

# print(Q6(2,3,4))