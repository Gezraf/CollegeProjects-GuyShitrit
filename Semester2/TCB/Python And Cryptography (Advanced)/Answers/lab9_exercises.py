import os
import random


MAX_OFFSET = 128
BLACKLIST_CHARS = ['_', '.', ',', '?', '\n']

def caesar_encrypt(text, offset):
    cipher = ""

    for c in text:
        if c != '\n' and is_valid(c):
            new_ascii = (ord(c) - ord('a') + offset) % 26 + ord('a')
            new_char = chr(new_ascii)
        else:
            new_char = c

        cipher += new_char

    return cipher


def caesar_decrypt_with_offset(cipher, orig_offset):
    text = caesar_encrypt(cipher, -orig_offset)
    return text


def is_valid(line):
    if len(line) == 1:
        c = line[0]
        return c.isalpha() or c.isnumeric() or c in BLACKLIST_CHARS

    for c in line:
        if not (c.isalpha() or c.isnumeric() or c in BLACKLIST_CHARS):
            return False

    return True


def Q1(txt_path):
    with open(txt_path, "r") as f:
        lines = f.readlines()

        for line in lines:
            if not is_valid(line.strip()):
                return False

        return True


def Q2(file_path, offset):
    dir = os.path.dirname(file_path)
    filename, extension = os.path.splitext(file_path)
    output_path = f"{dir}/{filename}-encrypt{extension}"

    res = ""
    with open(file_path, "r") as f:
        lines = f.readlines()

    for line in lines:
        res += caesar_encrypt(line, offset)


    with open(output_path, "w") as f:
        f.write(res)


def Q3(file_path, offset):
    dir = os.path.dirname(file_path)
    filename, extension = os.path.splitext(file_path)
    output_path = f"{dir}/{filename}-decrypt{extension}"

    res = ""
    with open(file_path, "r") as f:
        lines = f.readlines()

    for line in lines:
        res += caesar_decrypt_with_offset(line, offset)


    with open(output_path, "w") as f:
        f.write(res)


def Q4(txt_path, words):
    with open(txt_path, "r") as f:
        file_words = {word for line in f.readlines() for word in line.strip().split()}
        print(file_words)

    picked_offset = MAX_OFFSET + 1 # שם ערך בלתי אפשרי שרירותי התחלתי להיסט שננסה למצוא בהמשך
    for offset in range(0, MAX_OFFSET + 1):
        flag = True
        for word in file_words:
            if caesar_decrypt_with_offset(word, offset) not in words:
                flag = False
                break

        if flag:
            picked_offset = offset
            break


    return -1 if picked_offset == MAX_OFFSET + 1 else picked_offset


def Q5(folder_path):
    folder = os.listdir(folder_path)

    for filename in folder:
        file_path = f"{folder_path}/{filename}"

        if os.path.isfile(file_path):
            filename = os.path.basename(file_path) # לא למדנו, משיג את השם קובץ עצמו בלי הנתיב
            name, extension = os.path.splitext(filename)

            offset = random.randint(1, MAX_OFFSET)

            res = ""
            output_path = f"{folder_path}/{name}-offset{extension}"

            with open(file_path, "r") as src_file:
                lines = src_file.readlines()

            file_content = ''.join(lines)

            if is_valid(file_content):
                for line in lines:
                    res += caesar_encrypt(line, offset)

            else:
                for line in lines:
                    res += caesar_decrypt_with_offset(line, offset)

            with open(output_path, "w") as out_file:
                out_file.write(res)
