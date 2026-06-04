/*
 Assignment: 5
 Author: Guy Shitrit, ID: 330707761
*/

#include <iostream>
#include "Menu.h"

int strlen(const char* str);
char* stringMultiply(const char *str, int n); // מייבא מתוך part2and4.cpp

int main() {
    // הרצה של חלק ג'
    Menu menu;
    menu.StartMenu();

    // הרצה של חלק ד' (לפי מה ביקשו בסוף המסמך)
    try {
        char* str = stringMultiply("abcd", 4);

        for (int i = 0; str[i] != '\0'; i++) {
            std::cout << str[i];
        }

        delete[] str;

    } catch (std::exception &e) {
        std::cout << e.what();
    }

    return 0;
}




