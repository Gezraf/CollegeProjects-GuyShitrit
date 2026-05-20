# Author : Guy Shitrit

import os
import shutil

def Q1(txt_path):
    """
    הפונקציה מקבלת קובץ טקסט עם מקצוע וציונים
    היא בודקת שכל שורה מתחילה בשם מקצוע תקין ואחריו ציונים תקינים
    אם כל השורות תקינות יוחזר אמת אחרת יוחזר שקר
    """
    try:
        with open(txt_path, "r") as f:
            lines = f.readlines()

        for line in lines:
            line = line.strip()

            if line == "":
                return False

            parts = line.split(",")
            subject = parts[0].strip()

            if not subject.isalpha():
                return False

            if len(parts) < 2:
                return False

            for grade in parts[1:]:
                grade = grade.strip()

                if not grade.isdigit():
                    return False

                grade = int(grade)

                if grade < 0 or grade > 100:
                    return False

        return True


    except FileNotFoundError:
        print("File not found")
        return False

    except PermissionError:
        print("No permission to access file")
        return False

    except Exception as e:
        print(f"Q1() error: {e}")
        return False


def Q2(txt_path, S1, S2):
    """
    הפונקציה קוראת קובץ טקסט ומחליפה כל הופעה של מחרוזת אחת באחרת
    לפני כל החלפה מתווסף מספר סידורי לפי סדר ההופעות
    התוצאה נכתבת לקובץ חדש עם סיומת output
    """
    try:
        with open(txt_path, "r") as f:
            text = f.read()

        res = ""
        i = 0
        count = 0

        length = len(S1)

        while i < len(text):
            if text[i:i + length] == S1:
                count += 1
                res += f"[{count}]{S2}"
                i += length
            else:
                res += text[i]
                i += 1

        filename, extension = os.path.splitext(txt_path)

        with open(f"{filename}-output{extension}", "w") as f:
            f.write(res)


    except FileNotFoundError:
        print("File not found")

    except PermissionError:
        print("No permission to access file")

    except Exception as e:
        print(f"Q2() error: {e}")


def Q3(txt_path):
    """
    הפונקציה קוראת קובץ עם ערים ומדידות טמפרטורה
    עבור כל עיר היא מחשבת ממוצע מינימום ומקסימום
    שורות לא תקינות נכתבות לקובץ דוח עם הודעת שגיאה מתאימה
    """
    try:
        def isnumber(s):
            try:
                float(s)
                return True
            except ValueError:
                return False

        with open(txt_path, "r") as f:
            lines = f.readlines()

        data = {}

        for line in lines:
            line = line.strip()

            pair = line.split(':', 1)

            if len(pair) != 2:
                data[line] = "line error"
                continue

            city, temps_str = pair

            if temps_str == "":
                data[city] = "no temperature"
                continue

            temps = temps_str.split(',')

            summ = 0
            minn, maxx = float("inf"), float("-inf")
            flag = True

            for temp in temps:
                if not isnumber(temp):
                    data[line] = "temperature error"
                    flag = False
                    break

                value = float(temp)
                summ += value

                if value > maxx:
                    maxx = value

                if value < minn:
                    minn = value

            if not flag:
                continue

            avg = summ / len(temps)

            data[city] = f"avg({avg}),min({minn}),max({maxx})"

        filename, extension = os.path.splitext(txt_path)

        with open(f"{filename}-report{extension}", "w") as f:
            for key, value in data.items():
                if "error" in value:
                    f.write(f"{key} {value}\n")
                else:
                    f.write(f"{key}:{value}\n")


    except FileNotFoundError:
        print("File not found")

    except PermissionError:
        print("No permission to access file")

    except Exception as e:
        print(f"Q3() error: {e}")



def Q4(txt_path, domains_set, forbidden_words):
    """
    הפונקציה קוראת קובץ הודעות מייל המחולק לפי סימן סולמית
    היא בודקת האם כתובת המייל והטקסט תקינים לפי הדומיינים והמילים האסורות
    הודעות תקינות נכתבות לקובץ send והודעות לא תקינות לקובץ log
    """
    try:
        filename, extension = os.path.splitext(txt_path)

        with open(txt_path, "r") as f:
            lines = [line.strip() for line in f]

        send_lines = []
        log_lines = []

        i = 0

        while i < len(lines):
            if i + 1 >= len(lines):
                break

            address = lines[i]
            subject = lines[i + 1]
            i += 2

            content = []

            while i < len(lines) and lines[i] != "#":
                content.append(lines[i])
                i += 1

            i += 1

            full_email = [address, subject] + content + ["#"]

            valid = True
            reason = ""

            if "@" not in address:
                valid = False
                reason = "# invalid address"
            else:
                domain = address.split("@")[1]
                if domain not in domains_set:
                    valid = False
                    reason = "# domain black list"

            for line in content:
                for word in forbidden_words:
                    if word in line:
                        valid = False
                        reason = "# text mail in black list"
                        break
                if not valid:
                    break

            if valid:
                send_lines.extend(full_email)
            else:
                log_lines.extend(full_email + [reason])

        send_path = f"{filename}-send{extension}"
        log_path = f"{filename}-log{extension}"

        with open(send_path, "w") as f:
            for line in send_lines:
                f.write(line + "\n")

        with open(log_path, "w") as f:
            for line in log_lines:
                f.write(line + "\n")

    except FileNotFoundError:
        print("File not found")

    except PermissionError:
        print("No permission to access file")

    except Exception as e:
        print(f"Q4() error: {e}")



def Q5(folder_path):
    """
    הפונקציה מקבלת נתיב לתיקייה וממיינת את הקבצים לפי הסיומת שלהם
    לכל סיומת נוצרת תיקייה מתאימה אם היא עדיין לא קיימת
    כל קובץ מועבר לתיקייה שמתאימה לסיומת שלו
    """
    try:
        if not os.path.isdir(folder_path):
            print("Path is not a folder")
            return

        folder = os.listdir(folder_path)

        dirs = set(filter(lambda name: os.path.isdir(os.path.join(folder_path, name)), folder))

        for file_name in folder:
            file_path = os.path.join(folder_path, file_name)

            if os.path.isfile(file_path):
                _, extension = os.path.splitext(file_path)
                extension_strip = extension[1:] if extension else "none"

                new_dir_path = os.path.join(folder_path, extension_strip)

                if extension_strip not in dirs:
                    os.mkdir(new_dir_path)
                    dirs.add(extension_strip)

                shutil.move(file_path, new_dir_path)

    except FileNotFoundError:
        print("Folder not found")

    except PermissionError:
        print("No permission to access folder or move files")

    except Exception as e:
        print(f"Q5() error: {e}")