#include "TwoDigits.h"
#include <iostream>
using namespace std;

int digitToInt(const char c) {
    return c - '0';
}

char intToDigit(const int n) {
    return '0' + n;
}

TwoDigits::TwoDigits() : tens('0'), ones('0') {}
TwoDigits::TwoDigits(const int num) : tens(intToDigit(num / 10)), ones(intToDigit(num % 10)) {}
TwoDigits::TwoDigits(const char tens, const char ones) : tens(tens), ones(ones) {}


void TwoDigits::SetTens(const char newTens) {
    tens = newTens;
}

void TwoDigits::SetOnes(const char newOnes) {
    ones = newOnes;
}

int TwoDigits::ToInt() const {
    return digitToInt(tens) * 10 + digitToInt(ones);
}

void TwoDigits::SetNum(const int num) {
    *this = TwoDigits(num);
}

void TwoDigits::Print() const {
    cout << tens << ones;
}
