#ifndef CPPWORK_CSET_H
#define CPPWORK_CSET_H
#include <iostream>
using namespace std;

template<typename T>
class CSet {
    T* arr;
    int size;
public:
    CSet(); // Default Constructor
    CSet(const CSet& other); // Copy Constructor
    ~CSet(); // Destructor
    CSet& operator=(const CSet other); // Copy assignment operator

    bool operator==(const CSet<T>& other) const;
    CSet& operator+=(T val); // Gets a new value and appends it to the end of the set if not in the set already (otherwise prints an invalid error)
    CSet& operator-=(T val); // Gets a value and removes it if it exists (otherwise prints an invalid error)

    CSet& Union(const CSet& other); // Unites the current set with another one
    friend ostream& operator<<(ostream& os, const CSet<T>& set); // Prints the current set
};


#endif
