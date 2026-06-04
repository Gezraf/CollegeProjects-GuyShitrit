#ifndef CPPWORK_MENU_H
#define CPPWORK_MENU_H
#include "CSet.h"


class Menu {
    CSet<int> intSet;
    CSet<long> longSet;
    CSet<char> charSet1, charSet2;
    CSet<string> wordSet;

public:
    void StartMenu();
};



#endif
