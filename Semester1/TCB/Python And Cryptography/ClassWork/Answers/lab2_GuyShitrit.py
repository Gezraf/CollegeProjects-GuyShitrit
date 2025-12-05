# Assigned by Guy Shitrit (ID: 330707761)

def ex1():
    num = int(input("1) Enter a 3-digited number: "))
    if 100 <= num <= 999:
        hundreds = num // 100
        tens = num % 100 // 10
        ones = num % 10

        summ = hundreds + tens + ones
        mul = hundreds * tens * ones

        print(summ , mul)

    else:
        print("The number you entered is not 3-digited.")


def ex2():
    num = int(input("2) Enter a 4-digited number: "))

    if 1000 <= num <= 9999:
        thousands = num // 1000
        hundreds = num % 1000 // 100
        tens = num % 1000 % 100 // 10
        ones = num % 10

        res = f"{ones}{tens}{hundreds}{thousands}"
        print(res)

    else:
        print("The number you entered is not 4-digited.")


def ex3():
    num = int(input("3) Enter a 4-digited number: "))

    if 1000 <= num <= 9999:
        thousands = num // 1000
        hundreds = num % 1000 // 100
        tens = num % 1000 % 100 // 10
        ones = num % 10

        res = f"{tens}{ones}{thousands}{hundreds}"
        print(res)

    else:
        print("The number you entered is not 4-digited.")


def ex4():
    num = int(input("4) Enter a 5-digited number: "))

    if 10000 <= num <= 99999:
        ten_thousands = num // 10000
        thousands = num % 10000 // 1000
        tens = num % 10000 % 1000 % 100 // 10
        ones = num % 10

    else:
        print("The number you entered is not 5-digited.")

    res = f"{ten_thousands}{thousands}{tens}{ones}"
    print(res)


def ex5():
    rate = float(input("5) Enter the current rate of exchange: "))

    print("1$ - %.1f" % (1 * rate) + "₪")
    print("10$ - %.1f" % (10 * rate) + "₪")
    print("100$ - %.1f" % (100 * rate) + "₪")
    print("1000$ - %.1f" % (1000 * rate) + "₪")


    print("1$ - {:.1f}".format(1 * rate) + "₪")
    print("10$ - {:.1f}".format(10 * rate) + "₪")
    print("100$ - {:.1f}".format(100 * rate) + "₪")
    print("1000$ - {:.1f}".format(1000 * rate) + "₪")


def ex6():
    rate = float(input("6) Enter the current rate of exchange: "))

    print("1₪ - %.1f" % (1 / rate) + "$")
    print("10₪ - %.1f" % (10 / rate) + "$")
    print("100₪ - %.1f" % (100 / rate) + "$")
    print("1000₪ - %.1f" % (1000 / rate) + "$")

    print("1₪ - {:.1f}".format(1 / rate) + "$")
    print("10₪ - {:.1f}".format(10 / rate) + "$")
    print("100₪ - {:.1f}".format(100 / rate) + "$")
    print("1000₪ - {:.1f}".format(1000 / rate) + "$")


def ex7():
    rate = float(input("7) Enter the current rate of exchange (ILS -> USD): "))
    percent = float(input("Enter the VAT percentage: "))
    price = float(input("Enter the price of the product in ILS (VAT included): "))

    price *= (1 - (percent / 100)) # חישוב מחיר לפני מע"מ
    usd_price = price / rate # המרה לדולרים

    print(f"The price without VAT: {usd_price}$")

if __name__ == "__main__":
    ex1()
    ex2()
    ex3()
    ex4()
    ex5()
    ex6()
    ex7()