import os

def substitution_encrypt(text):
    cipher = ""

    for c in text:
        if 'a' <= c <= 'z':
            new = ord('a') + ord('z') - ord(c)
            cipher += chr(new)
        else:
            cipher += c

    return cipher

def transposition(text):
    return text[::-1]

def zigzag_preprocess(text, n=2):
    strip = text.replace(' ', '')
    length = len(strip)

    mat = [[''] * length for _ in range(n)]
    direction = 1

    i, j = 0, 0

    while i < length:
        mat[j][i] = strip[i]

        if n > 1:
            if j == 0:
                direction = 1
            elif j == n - 1:
                direction = -1

            j += direction

        i += 1

    return mat


def zigzag_encrypt(text, n=2):
    space_positions = [i for i in range(len(text)) if text[i] == ' ']
    mat = zigzag_preprocess(text, n)

    processLine = lambda arr: ''.join(list(filter(lambda c: c != '', arr)))

    string = ''.join(processLine(line) for line in mat)

    res = ' '.join([string[i:i+4] for i in range(0, len(string), 4)])
    return res, space_positions

def zigzag_decrypt(encrypted_text, spaces, n=2):
    encrypted_text = encrypted_text.replace(' ', '')
    cols = len(encrypted_text)

    mat = [[''] * cols for _ in range(n)]

    row = 0
    direction = 1

    for col in range(cols):
        mat[row][col] = '*'

        if n > 1:
            if row == 0:
                direction = 1
            elif row == n - 1:
                direction = -1

            row += direction

    index = 0

    for row in range(n):
        for col in range(cols):
            if mat[row][col] == '*':
                mat[row][col] = encrypted_text[index]
                index += 1

    result = ''

    row = 0
    direction = 1

    for col in range(cols):
        result += mat[row][col]

        if n > 1:
            if row == 0:
                direction = 1
            elif row == n - 1:
                direction = -1

            row += direction

    arr = list(result)

    for pos in spaces:
        arr.insert(pos, ' ')

    return ''.join(arr)

def Q1(file_path):
    if not os.path.isfile(file_path): # אם הנתיב הוא לא נתיב לקובץ
        return

    with open(file_path, "r") as f:
        lines = f.readlines()


    result = ''.join(substitution_encrypt(line) for line in lines).strip()
    name, extension = os.path.splitext(file_path)
    result_path = f"{name}-result{extension}"

    with open(result_path, "w") as f:
        f.write(result)

def Q2():
    letters = "abcdefghijklmnopqrstuvwxyz"
    encrypted = substitution_encrypt(letters)

    d = dict()
    for i in range(len(letters)):
        d[letters[i]] = encrypted[i]

    return d

def Q3(text):
    encrypted = substitution_encrypt(text)
    d = dict()

    for i in range(len(text)):
        d[text[i]] = encrypted[i]

    return d

def Q4(file_path, key):
    if not os.path.isfile(file_path): # אם הנתיב הוא לא נתיב לקובץ
        return

    with open(file_path, "r") as f:
        lines = f.readlines()

    result = ''.join(key[c] if c in key else c for line in lines for c in line).strip()
    print(result)

    name, extension = os.path.splitext(file_path)
    result_path = f"{name}-result{extension}"

    with open(result_path, "w") as f:
        f.write(result)

def Q5(text, n):
    return zigzag_encrypt(text, n)
"""
    דוגמת שימוש לקידוד זיגזג
    txt = "אני מגיע רק מחרתיים"
    encrypted, spaces = zigzag_encrypt(txt, 2)
    print(encrypted)
"""
def Q6(text, spaces, n):
    return zigzag_decrypt(text, spaces, n)

# print(Q6(encrypted, spaces ,2)) דוגמה לשימוש בפענוח
