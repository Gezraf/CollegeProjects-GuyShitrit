def transposition(text):
    return text[::-1]


def zigzag_preprocess(text):
    strip = text.strip()
    n = len(strip)

    mat = [[''] * n] + [[''] * n]

    i, j = 0, 0

    while i < n:
        mat[j][i] = strip[i]

        if j == 0:
            j = 1
        elif j == 1:
            j = 0

        i += 1

    return mat

def zigzag_encrpyt(text):
    mat = zigzag_preprocess(text)

    func = lambda c: c != ''
    line1, line2 = ''.join(list(filter(func, mat[0]))), ''.join(list(filter(func, mat[1])))
    res = ''

    for c in line1:
        res += c
    for c in line2:
        res += c

    res = ''

    for line in mat:
        print(line)

    return res

print(zigzag_encrpyt(transposition("אני מגיע רק מחרתיים")))