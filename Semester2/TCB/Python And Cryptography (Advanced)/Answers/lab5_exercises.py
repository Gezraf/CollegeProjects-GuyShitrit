def Q1(n):
    return {i: i**2 for i in range(1,n+1)}

def Q2(arr):
    return {typ: typ for typ in filter(lambda x: type(x) in [int, float, str, tuple], arr)}

def Q3(hotel1, hotel2):
    res = {}
    for c in hotel1:
        if c not in hotel2:
            hotel2[c] = 0
        res[c] = hotel1[c] + hotel2[c]

    for c in hotel2:
        if c not in res:
            res[c] = hotel2[c]
    return res

def Q4(hotel):
    res = []

    for student in hotel.values():
        tup = ()
        summ = 0
        length = 0
        name = ""

        for val in student.values():
            if type(val) is str:
                name = val
            else:
                summ += val
                length += 1

        if length != 0:
            avg = summ / length
            if avg % 1 != 0:
                dec = avg % 1
                if dec >= 0.5: # מוודא שאנחנו מעגלים למעלה את הממוצע אם החלק העשרוני שלו לפחות חצי
                    avg += 1
            avg = int(avg)
        else:
            avg = 0

        tup += (name,)
        tup += (round(avg),)
        res.append(tup)

    return res

def Q5(arr):
    res = {i: [] for i in range(10)}

    for digit in res.keys():
        for num in arr:
            if str(digit) in str(num):
                res[digit].append(num)

    for key in list(res.keys()):
        if not res[key]:
            del res[key]
    return res