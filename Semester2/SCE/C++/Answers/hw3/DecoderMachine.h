#include "AncientScroll.h"
#pragma once

#ifndef CPPWORK_DECODERMACHINE_H
#define CPPWORK_DECODERMACHINE_H



class DecoderMachine {
    AncientScroll* scroll;
    int* key;
    int keyLen;

public:
    DecoderMachine(const AncientScroll&); // בנאי
    DecoderMachine(const DecoderMachine&); // בנאי מעתיק
    ~DecoderMachine(); // הורס

    DecoderMachine& operator+=(const int[]); // טוען מפתח חדש שנשלח כפרמטר
    DecoderMachine& operator!(); // מבצע את כל הפקודות שעל המפתח

    friend ostream& operator<<(ostream&, const DecoderMachine&); // אופרטור הדפסה
};



#endif
