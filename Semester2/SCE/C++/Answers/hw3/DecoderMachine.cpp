#include "DecoderMachine.h"
#define FLIP 1
#define SHIFT 2
#define MIRROR 3

DecoderMachine::DecoderMachine(const DecoderMachine& other) {
    scroll = new AncientScroll(*other.scroll);
    keyLen = 0;
    key = nullptr;
}

DecoderMachine::DecoderMachine(const AncientScroll& _scroll) {
    scroll = new AncientScroll(_scroll);
    keyLen = 0;
    key = nullptr;
}

DecoderMachine::~DecoderMachine() {
    delete scroll;
    delete[] key;
}


DecoderMachine& DecoderMachine::operator+=(const int* _key) {
    int size = 0;
    while (_key[size] != -2)
        size++;
    keyLen = size;

    key = new int[size];
    for (int i = 0; i < size; i++)
        key[i] = _key[i];

    return *this;
}

DecoderMachine& DecoderMachine::operator!() {
    int i = 0;

    while (i + 2 < keyLen) {
        int action = key[i];
        int index = key[i + 1];
        int parameter = key[i + 2];

        AncientWord& word = (*scroll)[index];

        switch (action) {
            case FLIP: // 1 --> !
                !word;
                break;
            case SHIFT: // 2 --> ~
                ~word;
                break;
            case MIRROR: // 3 --> &
                &word;
                break;
        }

        i += 3;
    }

    keyLen = 0;
    delete[] key;

    return *this;
}

ostream& operator<<(ostream& os, const DecoderMachine& machine) {
    os << *machine.scroll;
    return os;
}