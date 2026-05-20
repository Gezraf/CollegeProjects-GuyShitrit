#ifndef OOP_TWODIGITS_H
#define OOP_TWODIGITS_H

class TwoDigits { // Represents a 2-digit number using separate tens and ones digits
    char tens, ones;

public:
    TwoDigits(); // Default constructor
    TwoDigits(int num); // Constructor that gets a 2-digit integer and converts it into characters for both tens and ones digits
    TwoDigits(char tens, char ones); // Constructor that gets 2 characters and sets them to the object's tens and ones digits respectively

    char GetTens() const { return tens; }; // Getter method for the tens digit
    char GetOnes() const { return ones; };// Getter method for the ones digit
    void SetTens(char newTens); // Setter method for the tens digit
    void SetOnes(char newOnes); // Setter method for the ones digit

    int ToInt() const; // Returns the 2-digit integer assembled from the object's tens and ones digits
    void SetNum(int num); // Gets a 2-digit integer and sets its tens and ones digits to the object's fields as characters (by re-using the TwoDigits(int) constructor)
    void Print() const; // Prints the object as its 2-digit number representation
};

#endif //OOP_TWODIGITS_H