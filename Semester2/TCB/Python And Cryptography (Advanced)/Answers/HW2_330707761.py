# Author : Guy Shitrit
from functools import reduce


def Q1(data):
    """
    הפונקציה מקבלת מילון ובודקת האם לפחות אחד מהמפתחות מופיע גם בין הערכים של המילון
    אם כן מוחזר אמת אחרת שקר
    """
    for key in data.keys():
        if key in data.values():
            return True
    return False


def Q2(tup):
    """
    הפונקציה מקבלת רצף של מספרים שלמים ומחזירה מילון
    שבו כל מפתח הוא כמות הספרות במספר, וכל ערך הוא קבוצה של המספרים המתאימים.
    מספר שמופיע יותר מפעם אחת יירשם כמחרוזת עם # וכמות ההופעות
    """
    def get_length(num):
        return len(str(abs(num)))

    counts = {}
    for num in tup:
        if num in counts:
            counts[num] += 1
        else:
            counts[num] = 1

    res = {get_length(num): set() for num in tup}

    for num in tup:
        length = get_length(num)
        if counts[num] <= 1:
            res[length].add(num)
        else:
            res[length].add(f"{num}#{counts[num]}")

    return res


def Q3(data):
    """
    הפונקציה מקבלת מילון ובודקת האם כל הערכים בו הם מטיפוסים שלא ניתנים לשינוי
    אם כן יוחזר מילון חדש עם החלפה בין המפתחות לערכים, אחרת תוחזר קבוצה של הערכים המתאימים בלבד
    """
    immutable = set(filter(lambda elem: type(elem) in [int, float, bool, str, tuple], data.values()))
    if len(immutable) != len(data.values()): # אם לא כל הערכים הם טיפוסים שלא ניתנים לשינוי נחזיר את הקבוצה מוקדם
        return immutable

    res = {value: key for key, value in data.items()}
    return res


def Q4(sentence, ban_words):
    ban_words = {word.lower() for word in ban_words}
    words = sentence.split()
    res = {word.lower(): 0 for word in words if word.isalpha() and word.lower() not in ban_words}
    for word in words:
        word = word.lower()
        if word in res:
            res[word] += 1
    return res


def Q5(string):
    """
    הפונקציה מקבלת מחרוזת שמכילה כתובות רשת ובודקת אילו מהן תקינות
    הפונקציה מחזירה מילון שבו המפתחות הם מספרי הרשת והערכים הם כמות התחנות בכל רשת
    """
    res = {}
    addresses = [address for address in string.split() if len(address.split('.')) == 4
                 and reduce(lambda flag, part: flag and part.isnumeric() and 0 <= int(part) <= 255, address.split('.'), True)
                ]

    for address in addresses:
        parts = address.split('.')
        parts[-1] = 'x'
        network = '.'.join(parts)

        if network not in res:
            res[network] = 1
        else:
            res[network] += 1

    return res
