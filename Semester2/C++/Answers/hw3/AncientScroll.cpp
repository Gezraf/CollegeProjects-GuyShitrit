#include "AncientScroll.h"

AncientScroll::AncientScroll() {
    count = 0;
    words = nullptr;
}

AncientScroll::AncientScroll(const AncientScroll& other) {
    count = other.count;
    words = new AncientWord*[count];

    for (int i = 0; i < count; i++)
        words[i] = new AncientWord(*other.words[i]);
}

AncientScroll::~AncientScroll() {
    for (int i = 0; i < count; i++) {
        delete words[i];
    }

    delete[] words;
}

AncientScroll& AncientScroll::operator+=(const char* word) {
    AncientWord** temp = words;
    words = new AncientWord*[count + 1];

    for (int i = 0; i < count; i++)
        words[i] = temp[i];

    words[count] = new AncientWord(word);
    count++;

    delete[] temp;
    return *this;
}

AncientScroll& AncientScroll::operator&() {
    for (int i = 0; i < count / 2; i++) {
        AncientWord* temp = words[i];
        words[i] = words[count - i - 1];
        words[count - i - 1] = temp;
    }

    return *this;
}

AncientWord& AncientScroll::operator[](int index) {
    return *words[index];
}

const AncientWord& AncientScroll::operator[](int index) const {
    return *words[index];
}

ostream& operator<<(ostream& os, const AncientScroll& scroll) {
    for (int i = 0; i < scroll.count; i++) {
        os << *scroll.words[i];

        if (i != scroll.count - 1)
            os << '-';
    }

    return os;
}