#include "Menu.h"

void Menu::StartMenu() {
    int option = 0;

    while (option != 5) {
        // print menu
        cout << "Menu:\n"
             << "1) Add new element\n"
             << "2) Remove element\n"
             << "3) Unite the char sets\n"
             << "4) Print set\n"
             << "5) Exit"
             << endl;

        cout << "Enter option: ";
        cin >> option;

        // inputting setType for options 1,2,4
        string setType = "";
        while (option == 1 || option == 2 || option == 4) {
            cout << "Enter set type (int/long/char1/char2/string): ";
            cin >> setType;

            if (setType == "int" || setType == "long" || setType == "char1" || setType == "char2" || setType == "string")
                break;
            else
                cout << "Invalid set type!";
        }

        switch (option) {
            case 1: // Add new element
                if (setType == "int") {
                    int value;
                    cout << "Enter int: "; cin >> value;
                    intSet += value;
                } else if (setType == "long") {
                    long value;
                    cout << "Enter long: "; cin >> value;
                    longSet += value;
                } else if (setType == "char1") {
                    char value;
                    cout << "Enter char for 1st char set: "; cin >> value;
                    charSet1 += value;
                } else if (setType == "char2") {
                    char value;
                    cout << "Enter char for 2nd char set: "; cin >> value;
                    charSet2 += value;
                } else if (setType == "string") {
                    string value;
                    cout << "Enter string: "; cin >> value;
                    wordSet += value;
                }
                break;


            case 2: // Removing element
                if (setType == "int") {
                    int value;
                    cout << "Enter value to remove: ";
                    cin >> value;
                    intSet -= value;
                } else if (setType == "long") {
                    long value;
                    cout << "Enter value to remove: ";
                    cin >> value;
                    longSet -= value;
                } else if (setType == "char1") {
                    char value;
                    cout << "Enter value to remove: ";
                    cin >> value;
                    charSet1 -= value;
                } else if (setType == "char2") {
                    char value;
                    cout << "Enter value to remove: ";
                    cin >> value;
                    charSet2 -= value;
                } else if (setType == "string") {
                    string value;
                    cout << "Enter value to remove: ";
                    cin >> value;
                    wordSet -= value;
                }
                break;


            case 3: // Print union of the two char sets
                cout << charSet1.Union(charSet2) << endl;
                break;


            case 4: // Print the chosen set
                if (setType == "int") {
                    cout << intSet;
                } else if (setType == "long") {
                    cout << longSet;
                } else if (setType == "char1") {
                    cout << charSet1;
                } else if (setType == "char2") {
                    cout << charSet2;
                } else if (setType == "string") {
                    cout << wordSet;
                }

                cout << endl;
                break;


            case 5: // Exit
                cout << "Goodbye!";
                break;

            default:
                cout << "Invalid option!" << endl;
                break;
        }
    }
}