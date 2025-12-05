# Assignment: 4
# Author: Guy Shitrit, ID: 330707761


def Q1(n1, n2):
    if (n1 + n2) % 2 == 0:
        return n1

    return n2


def Q2(num):
    if not (10000 <= num <= 99999):
        print("Number is not 5-digits")
        return -1

    ones = num % 10
    tens = (num // 10) % 10
    hundreds = (num // 100) % 10
    thousands = (num // 1000) % 10
    ten_thousands = num // 10000

    reversed_num = ones * 10000 + tens * 1000 + hundreds * 100 + thousands * 10 + ten_thousands
    summ = ones + tens + hundreds + thousands + ten_thousands

    if num == reversed_num:
        return summ

    return reversed_num


def Q3(n1, n2, n3):
    if (n1 <= n2 <= n3):
        print("ascending")
    elif (n3 <= n2 <= n1):
        print("descending")
    else:
        print("not sorted")


def Q4(x, y, z):
    if x < 0 or y < 0 or z < 0:
        print("Lengths must be positive.")
        return False

    if x > y + z or y > x + z or z > x + y:
        print("Lengths must be smaller than the sum of the other two lengths in a triangle.")
        return False

    return True


def Q5(num):
    def max(n1, n2):
        if n1 >= n2:
            return n1

        return n2

    if 10 <= num <= 99:  # 2 ספרות
        return (num // 10) - (num % 10)

    elif 100 <= num <= 999:  # 3 ספרות
        ones = num % 10
        tens = num // 10 % 10
        hundreds = num // 100

        return max(max(ones, tens), hundreds)

    elif 1000 <= num <= 9999:  # 4 ספרות
        ones = num % 10
        tens = num // 10 % 10
        hundreds = num // 100 % 10
        thousands = num // 1000

        reversedNum = ones * 1000 + tens * 100 + hundreds * 10 + thousands

        if num == reversedNum:
            return True

        return False

    elif 10000 <= num <= 99999:  # 5 ספרות
        ones = num % 10
        tens = (num // 10) % 10
        hundreds = (num // 100) % 10
        thousands = (num // 1000) % 10
        ten_thousands = num // 10000

        result = ones * 10000 + thousands * 1000 + hundreds * 100 + tens * 10 + ten_thousands
        return result


    else:
        return "input error"


def Q6(num1, num2):
    if not ((100 <= num1 <= 999) and (100 <= num2 <= 999)):
        return "The numbers must all be 3-digits."

    ones1 = num1 % 10
    tens1 = (num1 // 10) % 10
    hundreds1 = num1 // 100

    ones2 = num2 % 10
    tens2 = (num2 // 10) % 10
    hundreds2 = num2 // 100

    if (
        (hundreds1 == hundreds2 and tens1 == tens2 and ones1 == ones2) or
        (hundreds1 == hundreds2 and tens1 == ones2 and ones1 == tens2) or
        (hundreds1 == tens2 and tens1 == hundreds2 and ones1 == ones2) or
        (hundreds1 == tens2 and tens1 == ones2 and ones1 == hundreds2) or
        (hundreds1 == ones2 and tens1 == hundreds2 and ones1 == tens2) or
        (hundreds1 == ones2 and tens1 == tens2 and ones1 == hundreds2)
        ):
            return "same digits"

    return "not same digits"



def Q7(num):
    if not (10000 <= num <= 99999):
        print("Number is not 5-digits.")
        return -1

    LENGTH = 5  # המספר חייב להיות 5 ספרות

    odd_count = 0
    even_count = 0

    ones = num % 10
    tens = (num // 10) % 10
    hundreds = (num // 100) % 10
    thousands = (num // 1000) % 10
    ten_thousands = num // 10000

    if ones % 2 == 0:
        even_count += 1
    else:
        odd_count += 1

    if tens % 2 == 0:
        even_count += 1
    else:
        odd_count += 1

    if hundreds % 2 == 0:
        even_count += 1
    else:
        odd_count += 1

    if thousands % 2 == 0:
        even_count += 1
    else:
        odd_count += 1

    if ten_thousands % 2 == 0:
        even_count += 1
    else:
        odd_count += 1


    if even_count == LENGTH:
        print("only even digits")
    elif odd_count == LENGTH:
        print("not even digits")
    else:
        print(f"{even_count}, {odd_count}")


if __name__ == "__main__":
    print(Q1(14, 21))
    print(Q1(15, 21))

    # print(Q2(14541))
    # print(Q2(14532))
    #
    # Q3(2.5, 23, 128.2)
    # Q3( 2.5, 230, 128.2)
    #
    # print(Q4(7.8 ,45.6 ,12.3))
    # print(Q4(7.76 ,6.67 ,5.54))
    #
    # print(Q5(39))
    # print(Q5(391))
    # print(Q5(1331))
    # print(Q5(12345))
    # print(Q5(123456))
    #
    # print(Q6(423, 234))
    # print(Q6(214, 234))
    #
    # Q7(24268)
    # Q7(17539)
    # Q7(12576)
