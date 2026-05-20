#include <iostream>
#include "Menu.h"
using namespace std;

void Menu::MainMenu() {
    int option = 0;

    while (option != 3) {
        cout << "Menu:\n" << "1) NumMenu\n" << "2) BoolMenu\n" << "3) Exit" << endl;
        cout << "Enter option: ";
        cin >> option;
        cout << endl;

        switch (option) {
            case 1:
                NumMenu();
                break;
            case 2:
                BoolMenu();
                break;
            case 3:
                cout << "Goodbye!";
                break;
            default:
                cout << "Invalid option!";
                break;
        }
    }
}


void Menu::NumMenu() {
    char tens, ones;

    cout << "Enter tens: ";
    cin >> tens;

    while (tens < '0' || tens > '9') {
        cout << "Invalid input, c2 must be a digit!" << endl;
        cout << "Enter tens: ";
        cin >> tens;
    }

    cout << "Enter ones: ";
    cin >> ones;

    while (ones < '0' || ones > '9') {
        cout << "Invalid input, ones must be a digit!" << endl;
        cout << "Enter ones: ";
        cin >> ones;
    }

    n1 = TwoDigits(tens, ones);

    int num;

    cout << "Enter num: ";
    cin >> num;

    while (num < 10 || num > 99) {
        cout << "Invalid input, num must be 2 digits long." << endl;
        cout << "Enter num: ";
        cin >> num;
    }

    n2 = TwoDigits(num);

    cout << "NumMenu:\n" << "1) SetNum\n" << "2) Display Sum\n" << "3) Print Nums\n"<< "4) Exit" << endl;
    int option = 0;

    while (option != 4) {
        cout << "Enter option: ";
        cin >> option;
        cout << endl;

        switch (option) {
            case 1: {
                int n;
                cout << "Enter n: ";
                cin >> n;

                while (n < 10 || n > 99) {
                    cout << "Invalid input, n must be 2 digits long." << endl;
                    cout << "Enter n: ";
                    cin >> n;
                }

                n1.SetNum(n);
                break;
            }

            case 2: {
                const int int1 = n1.ToInt(), int2 = n2.ToInt(), res = int1 + int2;
                cout << "The sum of "; n1.Print(); cout << "+"; n2.Print(); cout << " is " << res << endl;
                break;
            }

            case 3:
                cout << "First two digit number "; n1.Print(); cout << endl;
                cout << "Second two digit number "; n2.Print(); cout << endl;
                break;

            case 4:
                cout << "Exiting to main menu!" << endl;
                return;
            default:
                cout << "Invalid option!";
                break;
        }

    }
}



void Menu::BoolMenu() {
    bArr.SetLength(0);
    cout << "BoolMenu:\n" << "1) SetLength\n" << "2) InputArr\n" << "3) ChangeValue\n" << "4) Peek\n" << "5) Print Array\n" << "6) Exit" << endl;

    int option = 0;

    while (option != 6) {
        cout << "Enter option: ";
        cin >> option;
        cout << endl;

        switch (option) {
            case 1: {
                int length;

                cout << "Enter length: ";
                cin >> length;

                bArr.SetLength(length);
                break;
            }

            case 2: {
                bArr.InputArr();
                break;
            }

            case 3: {
                int index;
                bool val;

                cout << "Enter index: ";
                cin >> index;

                if (index < 0 || index > bArr.GetLength() - 1) {
                    cout << "Index invalid!" << endl;
                    break;
                }


                cout << "Enter boolean value: ";
                cin >> val;
                bArr.ChangeValue(val, index);
                break;
            }
            case 4: {
                int index;

                cout << "Enter index: ";
                cin >> index;

                if (index < 0 || index > bArr.GetLength() - 1) {
                    cout << "BoolArray is false." << endl;
                    break;
                }

                if (bArr.Peek(index))
                    cout << "The value in index " << index << " is True"<< endl;
                else
                    cout << "The value in index " << index << " is False"<< endl;
                break;
            }

            case 5:
                bArr.Print();
                break;
            case 6:
                cout << "Exiting to main menu!" << endl;
                return;
            default:
                cout << "Invalid option!";
                break;
        }

    }
}