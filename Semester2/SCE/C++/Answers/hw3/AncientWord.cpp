#include "AncientWord.h"

//
int strlen(const char* str) { // מחזיר אורך מחרוזת
    if (*str == '\0')
        return 0;

    return 1 + strlen(str + 1);
}


bool isdigit(char c) { // בודק האם תו הוא ספרה
    return c >= '0' && c <= '9';
}

bool islower(char c) { // בודק האם תו היא אות קטנה
    return c >= 'a' && c <= 'z';
}

bool isupper(char c) { // בודק האם תו היא אות גדולה
    return c >= 'A' && c <= 'Z';
}

char tolower(char c) { // אם התו הוא אות גדולה אז זה יחזיר אות קטנה
    if (isupper(c))
        return c + ('a' - 'A');
    return c;
}

char toupper(char c) { // אם התו הוא אות קטנה אז זה יחזיר אות גדולה
    if (islower(c))
        return c - ('a' - 'A');
    return c;
}

char inverse(char c) { // יחזיר אות גדולה אם התו הוא אות קטנה ולהפך, אחרת אם התו הוא לא אות אז יחזיר אותו כרגיל
    if (isupper(c))
        return tolower(c);

    if (islower(c))
        return toupper(c);

    return c;
}

char nextChar(char c) { // מחזירה את התו הבא בצורה מעגלית בהתאם לאות קטנה/גדולה או ספרה
    if (islower(c))
        return 'a' + (c -'a' + 1) % ('z' - 'a' + 1);
    if (isupper(c))
        return 'A' + (c - 'A' + 1) % ('Z' - 'A' + 1);
    if (isdigit(c))
        return '0' + (c - '0' + 1) % ('9' - '0' + 1);

    return c;
}

//

AncientWord::AncientWord(const char* _data) {
    len =  strlen(_data);
    data = new char[len + 1]; // + '\0'

    for (int i = 0; i < len; i++)
        data[i] = _data[i];

    data[len] = '\0';
}


AncientWord::AncientWord(const AncientWord& other) {
    len = other.len;
    data = new char[len + 1]; // + '\0'

    for (int i = 0; i < len; i++) {
        data[i] = other.data[i];
    }

    data[len] = '\0';
}

AncientWord::~AncientWord() {
    delete[] data;
}


AncientWord& AncientWord::operator!() {
    for (int i = 0; i < len; i++)
        data[i] = inverse(data[i]);

    return *this;
}

AncientWord& AncientWord::operator~() {
    for (int i = 0; i < len; i++)
        data[i] = nextChar(data[i]);

    return *this;
}

AncientWord& AncientWord::operator&() {
    for (int i = 0; i < len / 2; i++) {
        char temp = data[i];
        data[i] = data[len - i - 1];
        data[len - i - 1] = temp;
    }

    return *this;
}


char& AncientWord::operator[](int index) const {
    return data[index];
}

ostream& operator<<(ostream& os, const AncientWord& word) {
    for (int i = 0; i < word.len; i++)
        os << word.data[i];

    return os;
}