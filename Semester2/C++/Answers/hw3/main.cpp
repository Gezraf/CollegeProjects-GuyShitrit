#include "AncientWord.h"
#include "AncientScroll.h"
#include "DecoderMachine.h"

int main() {
    cout << "--- Testing AncientWord ---" << endl;
    AncientWord word("Abz9");
    cout << "Original: " << word << endl; // Abz9
    cout << "After ! : " << !word << endl; // aBZ9 (Case Flip)
    cout << "After ~ : " << ~word << endl; // bCA0 (Shift)
    cout << "After & : " << &word << endl; // 0ACb (Mirror)
    cout << "Index 1: " << word[1] << endl; // A
    cout << endl;


    cout << "--- Testing AncientScroll ---" << endl;
    AncientScroll myScroll;
    myScroll += "Abz9";
    myScroll += "Test";
     cout << "0. Start: " << myScroll << endl;
     cout << "1. After ! : " << (!myScroll[0]) << endl;
     cout << "2. After ~ : " << (~myScroll[0]) << endl;
     cout << "3. After & : " << (&myScroll[0]) << endl;
     cout << "4. Scroll &: " << (&myScroll) << endl;
     cout << "Access [0][1]: " << myScroll[0][1] << endl; // e (מתוך Test)
     cout << endl;


    cout << "--- Testing DecoderMachine ---" << endl;
    DecoderMachine machine(myScroll);
    cout << machine << endl;
     int keyData[] = {
            1,1,0,
            2,1,0,
            3,0,0,
            -2
         };

    !(machine += keyData);
    cout << "Final Results:" << endl;
    cout << "Machine Decoded Scroll: " << machine << endl;
    cout << "Original Scroll (Unchanged): " << myScroll << endl;


    cout << "\n--- Testing Copy & Assignment ---" << endl;
    DecoderMachine machine2 = machine; // בנאי מעתיק

    int keyData2[] = {
        2, 0, 0,
        -2
     };

    !(machine2 += keyData2);

    cout << "Machine 2 (copied & updated): " << machine2 << endl;
    cout << "Machine 1 (remains same): " << machine << endl;

    return 0;
}