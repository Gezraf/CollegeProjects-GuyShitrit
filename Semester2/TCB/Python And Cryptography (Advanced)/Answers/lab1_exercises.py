def Q1(arr):
    odds = []
    evens = []
    merged = []

    for num in arr:
        if len(str(num)) % 2 == 1:
            odds.append(num)
        else:
            evens.append(num)

    if len(odds) == len(evens):
        for i in range(len(odds)):
            merged.append(odds[i])
            merged.append(evens[i])

    return merged

def Q2(string):
    def ends_with(string, target):
        if len(target) > len(string):
            return False
        return string[len(string) - len(target):] == target # ככה אפשר לבדוק אם מחרוזת נגמרת במחרוזת אחרת

    allowed = [".ac.il", ".gov.il"]
    domains = string.split()
    res = ""

    for domain in domains:
        for name in allowed:
            if len(domain) - len(name) >= 3 and ends_with(domain, name): # אם ההפרש בין שם הדומיין לשם המותר הוא לפחות 3 ואם הדומיין נגמר בשם המותר
                res += f"{domain} "

    return res


def Q3(string):
    words = string.split()
    n = len(words)
    half1 = words[:n//2]
    half2 = words[n//2:]

    for word1 in half1:
        for word2 in half2:
            if word1 == word2:
                return True

    return False

def Q4(string1, string2):
    string = f"{string1} {string2}"  # מחרוזת מאוחדת
    return " ".join(sorted(string.split(), key=lambda x: len(x))) # פה עשיתי שורה קצת ארוכה אבל זה חיבור של הרשימת מילים של המחרוזת המאוחדת שממוינת לפי אורך מילים

def Q5(string):
    def unique(word):
        for i in range(len(word)):
            if word[i] in word[:i]: # האם תו נמצא בתת מחרוזת עד האינדקס הנוכחי, אם כן אז המחרוזת מכילה אות שמופיעה יותר מפעם אחת
                return False
        return True

    words = string.split()
    res = ""

    for word in words:
        if unique(word):
            res += f"{word} "

    return res

def Q6(arr):
    def isSymm(string):
        return string == string[::-1]

    for num in arr:
        string = str(num)
        length = len(string)
        mid_char = string[length // 2]
        if isSymm(string) and length % 2 == 1:
            if mid_char not in string[:length // 2]:
                return num


    return 0

def Q7(tup):
    maxx = -1
    string = str(tup)
    string = string.replace("(", "") # קיזוז סוגר שמאל
    string = string.replace(")", "") # קיזוז סוגר ימין
    string = string.replace(" ", "") # הפשטת רווחים

    nums = string.split(",")
    nums = [int(num) for num in nums if num.isnumeric()] # שינוי המערך כך שייכלל רק המחרוזות שהם מספרים ויומרו למספרים שלמים בתהליך

    for num in nums:
        if num > maxx:
            maxx = num

    return maxx


def Q8(string):
    oper = string[:3]
    end = string.index(")")
    nums = string[4:end].split(",")
    nums = [int(num) for num in nums] # המרה לשלמים

    res = -1
    if oper == "add":
        res = nums[0] + nums[1]
    elif oper == "sub":
        res = nums[0] - nums[1]
    elif oper == "mul":
        res = nums[0] * nums[1]

    return res