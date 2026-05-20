#ifndef CPPWORK_ANCIENTWORD_H
#define CPPWORK_ANCIENTWORD_H
#pragma once
#include <iostream>
using namespace std;


class AncientWord {
    char* data;
    int len;

public:
    AncientWord(const char*); // בנאי
    AncientWord(const AncientWord&); // בנאי מעתיק
    ~AncientWord(); // הורס

    AncientWord& operator!(); // אותיות קטנות <--> אותיות גדולות
    AncientWord& operator~(); // משנות את כל התווים במילה לתווים הבאים שלהם בצורה מעגלית בהתאם לאות קטנה/גדולה או ספרה
    AncientWord& operator&(); // הופך את המילה

    char& operator[](int index) const; // data[index]
    friend ostream& operator<<(ostream& os, const AncientWord&); // אופרטור הדפסה
};

#endif
