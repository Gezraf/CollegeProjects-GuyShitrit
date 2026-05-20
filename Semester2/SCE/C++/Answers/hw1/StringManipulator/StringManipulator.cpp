#include "StringManipulator.h"
#include <iostream>
#include <string.h>
#define OFFSET 32

using namespace std;

bool isLower(char c) {
    return 'a' <= c && c <= 'z';
}

bool isUpper(char c) {
    return 'A' <= c && c <= 'Z';
}

void toUpper(char* c) {
    if (isLower(*c))
        *c = *c - OFFSET;
}

char toLower(char c) {
    if (isUpper(c))
        return c + OFFSET;
    return c;
}

bool isdigit(char c) {
    return '0' <= c && c <= '9';
}

int todigit(char c) {
    if (isdigit(c))
        return c - '0';
    return -1;
}

bool isalpha(char c) {
    return isLower(c) || isUpper(c);
}

void fixString(char* str) {
    char buffer[80];
    int len = strlen(str);
    int j = 0;

    for (int i = 0; i < len; i++) {
        if (str[i] == ' ') {
            if (j > 0 && buffer[j - 1] != ' ') {
                buffer[j++] = ' ';
            }
        } else {
            if (j > 0 && buffer[j - 1] != ' ') {
                char prev = buffer[j - 1];
                char cur  = str[i];

                if ((isdigit(prev) && isalpha(cur))  || (isalpha(prev) && isdigit(cur))  || (isdigit(prev) && (cur == '-'))  ||
                    (isalpha(prev) && (cur == '-'))) {
                    buffer[j++] = ' ';
                }
            }
            buffer[j++] = str[i];
        }
    }

    if (j > 0 && buffer[j - 1] == ' ')
        j--;

    buffer[j] = '\0';
    strcpy(str, buffer);

    toUpper(str);
}


StringManipulator::StringManipulator(char str[]) : string("") {
    char buffer[80];
    int i = 0, j = 0;
    bool flag = false;

    while (str[i] != '\0') {
        if (str[i] == ' ') {
            if (!flag) {
                buffer[j++] = ' ';
                flag = true;
            }
        } else {
            buffer[j++] = str[i];
            flag = false;
        }
        i++;
    }

    buffer[j] = '\0';

    strcpy(string, buffer);
    toUpper(string);
}


void StringManipulator::SetString(char str[]) {
    strcpy(string, str);
    toUpper(string);
}


void StringManipulator::Display_String() {
    cout << string << endl;
}


void StringManipulator::Rotate_Left(int n) {
    int len = strlen(string);

    int no_spaces = 0;
    for (int i = 0; i < len; i++)
        if (string[i] != ' ')
            no_spaces++;

    n %= no_spaces;

    if (n > 0) {
        for (int i = 0; i < len; i++) {
            if (string[i] != ' ') {
                string[i] = toLower(string[i]);
                break;
            }
        }

        int skipCount = 0;
        int start = 0;
        while (skipCount < n) {
            if (string[start] != ' ')
                skipCount++;
            start++;
        }

        char temp[80];
        strncpy(temp, string + start, len - start);
        strncpy(temp + (len - start), string, start);
        temp[len] = '\0';

        strcpy(string, temp);
        fixString(string);
    }
}


void StringManipulator::Rotate_Right(int n) {
    int len = strlen(string);

    int no_spaces = 0;
    for (int i = 0; i < len; i++)
        if (string[i] != ' ')
            no_spaces++;

    n %= no_spaces;

    if (n > 0) {
        for (int i = 0; i < len; i++) {
            if (string[i] != ' ') {
                string[i] = toLower(string[i]);
                break;
            }
        }

        int skipCount = 0;
        int split = len - 1;
        while (skipCount < n) {
            if (string[split] != ' ')
                skipCount++;
            split--;
        }
        split++;

        char temp[80];
        strncpy(temp, string + split, len - split);
        strncpy(temp + (len - split), string, split);
        temp[len] = '\0';

        strcpy(string, temp);
        fixString(string);
    }
}

void StringManipulator::Display_Substring(int n1, int n2) {
    for (int i = n1 - 1; i < n2; i++)
        cout << string[i];

    cout << endl;
}


int StringManipulator::Sum_Of_Number() {
    int len = strlen(string);
    int sum = 0;

    for (int i = 0; i < len; i++) {
        int sign = 1;

        if (string[i] == '-') {
            sign = -1;
            i++;
        }

        if (i < len && isdigit(string[i])) {
            int num = 0;

            while (i < len && isdigit(string[i])) {
                num = num * 10 + todigit(string[i]);
                i++;
            }

            sum += sign * num;
            i--;
        }
    }

    return sum;
}


char StringManipulator::Most_Common_Letter() {
    int len = strlen(string);
    int counts[26] = {0};

    for (int i = 0; i < len; i++) {
        if (isalpha(string[i]))
            counts[toLower(string[i]) - 'a']++;
    }

    int max = -1;
    char maxLetter = 'a';

    for (int i = 0; i < 26; i++) {
        if (counts[i] > max) {
            max = counts[i];
            maxLetter = 'a' + i;
        }
    }

    cout << "the most common letter is " << maxLetter << " (" << max << " times)" << endl;
    return maxLetter;
}


int StringManipulator::Count_Of_Words() {
    int len = strlen(string);
    int words = 0;

    for (int i = 0; i < len; i++) {
        if (isalpha(string[i])) {
            int countLetters = 0;

            while (i < len && isalpha(string[i]) && countLetters < 12) {
                countLetters++;
                i++;
            }

            words++;

            while (i < len && isalpha(string[i])) {
                i++;
            }
        }
    }

    return words;
}