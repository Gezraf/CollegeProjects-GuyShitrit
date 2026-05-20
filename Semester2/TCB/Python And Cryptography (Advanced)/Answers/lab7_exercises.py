def Q1(filename):
    line_count, sentence_count, word_count, character_count = 0, 0, 0, 0
    with open(filename) as f:
        for line in f:
            line_count += 1
            character_count += len(line)

            sentences = [sentence.strip() for sentence in line.split('.') if sentence.strip()] # רשימת המשפטים בלי רווחים
            sentence_count += len(sentences)

            for sentence in sentences:
                word_count += len(sentence.split())


        print(f"Line: {line_count}\nSentence: {sentence_count}\nWord: {word_count}\nCharacter: {character_count}")


def Q2(filename):
    longest_words = []
    maxx = 0
    with open(filename) as f:
        for line in f:
            words = line.split()

            for word in words:
                if maxx < len(word):
                    maxx = len(word)
                    longest_words = [word] # ניצור רשימה חדשה ברגע שמצאנו אורך מקסימלי חדש
                elif len(word) == maxx:
                    longest_words.append(word) # ברגע שיש מילה ששווה לאורך המקסימלי הנוכחי נוסיף אותה לרשימה

    if len(longest_words) == 1: # אם נמצאה רק מילה אחת נחזיר רק אותה
        return longest_words[0]
    return longest_words # אחרת נחזיר את הרשימה של כל המילים עם האורך המקסימלי


def Q3(filename):
    def is_valid_date(date):
        if date.isdigit() and len(date) == 4: # yyyy
            return 1900 <= int(date) <= 2026

        if '/' in date:
            sep = '/'
        elif '-' in date:
            sep = '-'
        else:
            return False

        parts = date.split(sep)

        if len(parts) == 3: # dd/mm/yyyy או dd-mm-yyyy
            d, m, y = parts
            if d.isdigit() and m.isdigit() and y.isdigit():
                return 1 <= int(d) <= 31 and 1 <= int(m) <= 12 and 1900 <= int(y) <= 2026

        if len(parts) == 2: # dd/mm או dd-mm
            d, m = parts
            if d.isdigit() and m.isdigit():
                return (1 <= int(d) <= 31 and
                        1 <= int(m) <= 12)

        return False

    with open(filename) as f:
        line_num = 1
        for line in f:
            words = line.split()
            dates = []

            for word in words:

                if is_valid_date(word):
                    dates.append(word)

            print("Line", line_num, ":", dates)
            line_num += 1

def Q4(filename):
    with open(filename) as f:
        for line in f:
            line = line.strip()

            if line == "":
                return False

            current = ""
            found_sentence = False

            for ch in line:
                current += ch

                if ch == '.' or ch == '?':
                    found_sentence = True

                    # בודקים שהמשפט מתחיל באות גדולה
                    sentence = current.strip()

                    first_char = ""
                    for c in sentence:
                        if c != ' ':
                            first_char = c
                            break

                    if first_char == "" or not first_char.isupper():
                        return False

                    current = ""

            # אם נשאר טקסט שלא הסתיים במשפט
            if current != "":
                return False

            if not found_sentence:
                return False

    return True


print(Q4("temp.txt"))



def Q5(filename):
    out_file = filename.split('.')[0] + ".out"

    with open(filename) as f:
        text = f.read()

    sentences = []
    current = ""

    for ch in text:
        current += ch
        if ch == '.' or ch == '?':
            sentences.append(current.strip())
            current = ""

    if current != "":
        sentences.append(current.strip())

    sentences.reverse()

    with open(out_file, 'w') as f:
        for i in range(len(sentences)):
            f.write(sentences[i])
            if i != len(sentences) - 1:
                f.write(" ")