def substitution_encrypt(text):
    cipher = ""
    for c in text:
        new = 127-ord(c)
        new_char = chr(new)
        cipher = cipher + new_char

    return cipher

def transposition(text):
    return text[::-1]


def zigzag_preprocess(text):
    strip = text.replace(' ', '')
    n = len(strip)

    mat = [[''] * n for _ in range(2)]

    i, j = 0, 0

    while i < n:
        mat[j][i] = strip[i]

        if j == 0:
            j = 1
        elif j == 1:
            j = 0

        i += 1

    return mat


def zigzag_encrypt(text):
    space_positions = [i for i in range(len(text)) if text[i] == ' ']
    mat = zigzag_preprocess(text)

    processLine = lambda arr: ''.join(list(filter(lambda c: c != '', arr)))
    line1, line2 = processLine(mat[0]), processLine(mat[1])
    string = (line1 + line2)

    res = ' '.join([string[i:i+4] for i in range(0, len(string), 4)])

    for line in mat:
        print(line)

    return res, space_positions

def zigzag_decrypt(encrypted_text, spaces):
    encrypted_text = encrypted_text.replace(' ', '')
    n = len(encrypted_text)

    middle = (n + 1) // 2

    line1 = encrypted_text[:middle]
    line2 = encrypted_text[middle:]

    res = ''

    i, j = 0, 0

    for index in range(n):
        if index % 2 == 0:
            res += line1[i]
            i += 1
        else:
            res += line2[j]
            j += 1

    arr = list(res)
    for pos in spaces:
        arr.insert(pos, ' ')

    res = ''.join(arr)
    return res
