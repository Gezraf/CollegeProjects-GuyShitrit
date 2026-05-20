#ifndef OOP_BOOLARRAY_H
#define OOP_BOOLARRAY_H


class BoolArray { // Represents a dynamic boolean array with access to its length
    bool* arr;
    int length;

public:
    BoolArray(); // Default constructor
    BoolArray(int n); // Constructor that gets an integer and sets the array's length to it (by re-using the SetLength(int) method)
    ~BoolArray(); // Destructor

    int GetLength() const { return length; } // Getter for the array's length
    bool* GetArr() const { return arr; } // Getter for the pointer to the array
    void SetLength(int n); // Setter for the array's length (if the array isn't empty it'll be freed before re-allocating it to its new length)

    void InputArr(); // Allows the user to input the entire array with boolean values
    int ChangeValue(bool val, int index); // Changes a boolean value in a specific index (if the index is invalid it'll return an error value)
    bool Peek(int index) const; // Returns the boolean value at the specific index (if the index is invalid it'll return false)
    void Print() const; // Prints the array with T's and F's respectively to the boolean values separated by tab spaces
};

#endif //OOP_BOOLARRAY_H