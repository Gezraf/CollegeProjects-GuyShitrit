import os

SPIRAL_PATH_RIGHT_4X4 = [
    (0, 0), (0, 1), (0, 2), (0, 3),
    (1, 3), (2, 3), (3, 3),
    (3, 2), (3, 1), (3, 0),
    (2, 0), (1, 0),
    (1, 1), (1, 2),
    (2, 2), (2, 1)
]

OPEN_CLOCKWISE_PATH_4X4 = [
    (2, 1), (1, 1), (1, 2), (2, 2), (3, 2),
    (3, 1), (3, 0),
    (2, 0), (1, 0), (0, 0),
    (0, 1), (0, 2), (0, 3),
    (1, 3), (2, 3), (3, 3)
]

def matricize(text):
    text = text.strip()
    return [list(text[i:i+4]) for i in range(0, 16, 4)]

def open_clockwise(text):
    mat = [[''] * 4 for _ in range(4)]

    text = text.strip()
    idx = 0
    for i, j in OPEN_CLOCKWISE_PATH_4X4:
        if idx >= len(text):
            break

        mat[i][j] = text[idx]
        idx += 1

    return mat


def shvil_mitpatel_right(text):
    mat = [[''] * 4 for _ in range(4)]
    text = text.strip()

    rows, cols = len(mat), len(mat[0])
    i, j = rows - 1, 0
    dir = -1

    idx = 0
    while j < cols:
        if idx >= len(text):
            break

        mat[i][j] = text[idx]
        i += dir

        if i < 0 or i > rows - 1:
            dir *= -1
            j += 1
            i += dir

        idx += 1

    return mat


def Q1(text):
    mat = [[''] * 4 for _ in range(4)]
    text = text.strip()

    idx = 0
    for i, j in (SPIRAL_PATH_RIGHT_4X4):
        if idx >= len(text):
            break

        mat[i][j] = text[idx]
        idx += 1

    res = ''.join(''.join(row) for row in mat)
    return res


def Q2(text):
    spiral = open_clockwise(text)

    res = ''.join(''.join(spiral[row]) for row in range(len(spiral)))
    return res


def Q3(text):
    text = text.strip()
    mat = matricize(text)

    res = ""
    for i, j in (OPEN_CLOCKWISE_PATH_4X4):
        res += mat[i][j]

    return res


def Q4(text):
    mat = shvil_mitpatel_right(text)
    res = ''.join(''.join(mat[row]) for row in range(len(mat)))
    return res


def Q5(text):
    mat = matricize(text)
    rows, cols = len(mat), len(mat[0])

    i, j = rows - 1, 0
    dir = -1

    res = ""

    while j < cols:
        res += mat[i][j]

        i += dir

        if i < 0 or i > rows - 1:
            dir *= -1
            j += 1
            i += dir

    return res


def Q6(file_path):
    if not os.path.isfile(file_path):
        return

    with open(file_path, "r") as f:
        lines = f.readlines()

    result = '\n'.join(Q2(line) for line in lines)
    print(result)

    name, extension = os.path.splitext(file_path)
    result_path = f"{name}-result{extension}"

    with open(result_path, "w") as f:
        f.write(result)


def Q7(file_path):
    if not os.path.isfile(file_path):
        return

    with open(file_path, "r") as f:
        lines = f.readlines()

    result = '\n'.join(Q3(line) for line in lines)
    print(result)

    name, extension = os.path.splitext(file_path)
    result_path = f"{name}-result{extension}"

    with open(result_path, "w") as f:
        f.write(result)