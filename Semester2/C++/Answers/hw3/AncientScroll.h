#ifndef CPPWORK_ANCIENTSCROLL_H
#define CPPWORK_ANCIENTSCROLL_H
#pragma once
#include "AncientWord.h"


class AncientScroll {
    AncientWord** words;
    int count;

public:
    AncientScroll(); // בנאי
    AncientScroll(const AncientScroll&); // בנאי מעתיק
    ~AncientScroll(); // הורס

    AncientScroll& operator+=(const char*); // מוסיף מילה חדשה לסוף המגילה
    AncientScroll& operator&(); // הופך את סדר המילים במגילה
    AncientWord& operator[](int index); // words[index]
    const AncientWord& operator[](int index) const; // words[index] read-only
    friend ostream& operator<<(ostream& os, const AncientScroll&); // אופרטור הדפסה

};



#endif
