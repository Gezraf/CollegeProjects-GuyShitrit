#include <iostream>
#include <string.h>
#include "StringManipulator.h"

using namespace std;

int main() {
    char input[80];

    cout << "Enter a string: ";
    cin.getline(input, 80);

    StringManipulator sm(input);

    cout << "String is ";
    sm.Display_String();

    cout << "\nupdate string ";
    cin.getline(input, 80);
    sm.SetString(input);

    cout << "Display_string\n";
    sm.Display_String();

    cout << "\nRotate_left(2)\n";
    sm.Rotate_Left(2);
    cout << "Display_string\n";
    sm.Display_String();

    cout << "\nRotate_right(5)\n";
    sm.Rotate_Right(5);
    cout << "Display_string\n";
    sm.Display_String();

    cout << "\nDisplay_substring(5,10)\n";
    sm.Display_Substring(5, 10);

    cout << "\nSum_of_numbers\n";
    int sum = sm.Sum_Of_Number();
    cout << "Sum of numbers is " << sum << endl;

    cout << "\nMost_common_letter\n";
    char c = sm.Most_Common_Letter();

    cout << "\nCount_of_words\n";
    int words = sm.Count_Of_Words();
    cout << "counter of words is " << words << endl;

    return 0;
}