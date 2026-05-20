#include "BoolArray.h"
#include <iostream>
using namespace std;

BoolArray::BoolArray() : arr(nullptr), length(0) {}
BoolArray::BoolArray(const int n) { SetLength(n); }
BoolArray::~BoolArray() { delete[] arr; }

void BoolArray::SetLength(int n) {
    if (arr)
        delete[] arr;

    if (n < 0)
        n = 0;

    length = n;
    if (n == 0)
        arr = nullptr;
    else
        arr = new bool[n]();
}


void BoolArray::InputArr() {
    if (!arr) {
        cout << "The array is empty, can't input values." << endl;
        return;
    }

    bool val;

    for (int i = 0; i < length; i++) {
        cout << "Index " << "#" << i << ":";
        cin >> val;
        ChangeValue(val, i);
    }

    cout << endl;
}

int BoolArray::ChangeValue(const bool val, const int index) {
   if (index < 0 || index > length - 1)
       return -1;

    arr[index] = val;
    return 0;
}

bool BoolArray::Peek(const int index) const {
    if (index < 0 || index > length - 1)
        return false;

    return arr[index];
}


void BoolArray::Print() const {
    for (int i = 0; i < length; i++) {
        if (arr[i]) {
            cout << "T\t";
        } else {
            cout << "F\t";
        }
    }

    cout << endl;
}
