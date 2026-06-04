// חלק ב' וד'

#include <iostream>
#include <string>

template<typename T>
bool isContain(T arr[], int size, T val) {
    for (int i = 0; i < size; i++) {
        if (arr[i] == val) {
            return true;
        }
    }

    return false;
}

int strlen(const char* str) {
    if (*str == '\0')
        return 0;

    return 1 + strlen(str + 1);
}

char* stringMultiply(const char *str, int n) {
        if (n <= 0) {
            throw std::invalid_argument("Invalid value: " + std::to_string(n));
            // ניסיתי ולא הצלחתי לחבר את המספר n בלי להשתמש בSTL לכן עשיתי הדפסה רגילה ושמתי חריגה ריקה
        }

        const int strSize = strlen(str);
        if (strSize == 0) {
            throw std::invalid_argument("Empty string");
        }

        const int totalSize = n * strSize;

        char* finalStr = new char[totalSize + 1]; // כולל ה'0\'

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < strSize; j++) {
                finalStr[j + i * strSize] = str[j];
            }
        }

        finalStr[totalSize] = '\0';
        return finalStr;
}



