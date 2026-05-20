import os
import shutil

def Q1(folder_path):
    folder = os.walk(folder_path)

    file_count = 0
    directory_count = 0

    for dirpath, dirnames, filenames in folder:
        file_count += len(filenames)
        directory_count += len(dirnames)


    if file_count == 0 or directory_count == 0:
        print("No files / directories found")
        return


    print(f"File count: {file_count}")
    print(f"Directory count: {directory_count}")



def Q2(folder_path):
    FILE = "listdir.txt"
    file_path = os.path.join(folder_path, FILE)

    curr_items = { item for item in os.listdir(folder_path) if item != FILE }

    if not os.path.exists(file_path):
        print("File not found, creating it...")

        with open(file_path, 'w') as file:
            for item in curr_items:
                file.write(item + "\n")

        return None # לא ביקשו את זה אבל נחזיר None במידה והקובץ לא קיים

    else:
        with open(file_path, "r") as file:
            written_items = { line.strip() for line in file }

        return curr_items == written_items


def Q3(folder_path):
    folder = os.walk(folder_path)

    for dirpath, _, filenames in folder:
        for filename in filenames:
            name, extension = os.path.splitext(filename)
            split = name.split("_")
            if len(split) == 2:
                new_name = split[1] + "_" + split[0] + extension

                old_path = f"{dirpath}/{filename}"
                new_path = f"{dirpath}/{new_name}"
                os.rename(old_path, new_path)



def move_content(old_dir, new_dir): # פונקציית עזר להעברת קבצים מתיקייה מסוימת לתיקייה אחרת
    for filename in os.listdir(old_dir):
        file_path = f"{old_dir}/{filename}"

        if os.path.isfile(file_path):
            shutil.move(file_path, new_dir)


def Q4(folder_path):
    non_empty_dirs = []
    def is_valid_dir(folder_path):
        nonlocal non_empty_dirs
        current_dir = os.listdir(folder_path)

        non_empty_dir_count = 0
        for name in current_dir:
            dirpath = f"{folder_path}/{name}"
            if os.path.isdir(dirpath):
                for _, _, files in os.walk(dirpath):
                    if files:
                        non_empty_dir_count += 1

                        if non_empty_dir_count > 2:
                            return False

                        non_empty_dirs.append(dirpath)
                        break

        if non_empty_dir_count != 2:
            return False

        return True

    if is_valid_dir(folder_path):
        temp_path = './temp'

        if not os.path.exists(temp_path):
            os.mkdir(temp_path)

        dir1, dir2 = non_empty_dirs[0], non_empty_dirs[1]

        move_content(dir1, temp_path)
        move_content(dir2, dir1)
        move_content(temp_path, dir2)

        os.rmdir(temp_path)


def Q5(folder_path):
    file_counter = dict()
    for file in os.listdir(folder_path):
        path = f"{folder_path}/{file}"

        if os.path.isdir(path):
            for dirpath, _, filenames in os.walk(path):
                for filename in filenames:
                    name, extension = os.path.splitext(filename)
                    if filename not in file_counter:
                        file_counter[filename] = 1
                    else:
                        file_counter[filename] += 1

                    if file_counter[filename] > 1:
                        n = file_counter[filename] - 1
                        new_name = f"{name}{n}{extension}"
                        os.rename(f"{dirpath}/{filename}", f"{dirpath}/{new_name}") # נשנה את השם של קובץ העותק לאותו שם + n סידורי

                move_content(dirpath, folder_path)
