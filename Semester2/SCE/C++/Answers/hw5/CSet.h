#ifndef CPPWORK_CSET_H
#define CPPWORK_CSET_H

#include <iostream>
#include <string>
using namespace std;

template<typename T>
class CSet;

template<typename T>
ostream& operator<<(ostream& os, const CSet<T>& set);

template<typename T>
class CSet {
    T* arr;
    int size;

public:
    CSet();
    CSet(const CSet& other);
    ~CSet();
    CSet<T>& operator=(CSet<T> other);

    bool operator==(const CSet<T>& other) const;

    CSet& operator+=(T val);
    CSet& operator-=(T val);
    CSet Union(const CSet& other);

    friend ostream& operator<< <T>(ostream& os, const CSet<T>& set);
};

#endif