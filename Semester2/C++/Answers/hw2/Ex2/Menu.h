#ifndef OOP_MENU_H
#define OOP_MENU_H
#include "TwoDigits.h"
#include "BoolArray.h"

class Menu { // Represents a menu system for using the TwoDigits and BoolArray classes
    TwoDigits n1, n2;
    BoolArray bArr;

public:
    void MainMenu(); // Starts the main menu that allows access to the TwoDigits and BoolArray menus
    void NumMenu(); // Starts the TwoDigits menu
    void BoolMenu(); // Starts the BoolArray menu
};

#endif //OOP_MENU_H