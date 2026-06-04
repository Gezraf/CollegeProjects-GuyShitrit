#include "CSet.h"

template<typename T>
CSet<T>::CSet() : arr(nullptr), size(0) {}


template<typename T>
CSet<T>::CSet(const CSet<T>& other) {
    size = other.size;
    arr = new T[size];

    for (int i = 0; i < size; i++)
        arr[i] = other.arr[i];
}


template<typename T>
CSet<T>::~CSet() {
    delete[] arr;
}

template<typename T>
bool CSet<T>::operator==(const CSet<T>& other) const {
    if (size != other.size)
        return false;

    if (this == &other)
        return true;

    for (int i = 0; i < size; i++) {
        bool exists = false;

        for (int j = 0; j < other.size; j++) {
            if (arr[i] == other.arr[j]) {
                exists = true;
                break;
            }

        }

        if (!exists)
            return false;
    }

    return true;
}



template<typename T>
CSet<T>& CSet<T>::operator=(const CSet<T> other) {
    if (this == &other)
        return *this;

    delete[] arr;

    size = other.size;
    arr = new T[size];
    for (int i = 0; i < size; i++)
        arr[i] = other.arr[i];

    return *this;
}


template<typename T>
CSet<T>& CSet<T>::operator+=(T val) {
    for (int i = 0; i < size; i++) {
        if (arr[i] == val) {
            cout << val << " already exists in the set!" << endl;
            return *this;
        }
    }

    T* new_arr = new T[size + 1];
    for (int i = 0; i < size; i++) {
        new_arr[i] = arr[i];
    }

    new_arr[size] = val;
    delete[] arr;

    arr = new_arr;
    size++;

    return *this;
}


template<typename T>
CSet<T>& CSet<T>::operator-=(T val) {
    if (size == 0) {
        cout << "Set is empty!" << endl;
        return *this;
    }

    int idx = -1;
    for (int i = 0; i < size; i++) {
        if (arr[i] == val) {
            idx = i;
            break;
        }
    }


    if (idx == -1) {
        cout << val << "does not exist in the set!" << endl;
        return *this;
    }

    T* new_arr = new T[size - 1];

    for (int i = 0, j = 0; i < size; i++) {
        if (i == idx)
            continue;
        new_arr[j++] = arr[i];
    }

    delete[] arr;

    arr = new_arr;
    size--;
    return *this;
}

template<typename T>
CSet<T> CSet<T>::Union(const CSet& other) {
    CSet<T> unionSet;

    for (int i = 0; i < size; i++) {
        unionSet += arr[i];
    }


    for (int i = 0; i < other.size; i++) {
        unionSet += other.arr[i];
    }


    return unionSet;
}

template<typename T>
ostream& operator<<(ostream& os, const CSet<T>& set) {
    os << "(";
    for (int i = 0; i < set.size; i++) {
        if (i == set.size - 1) {
            os << set.arr[i];
            continue;
        }

        os << set.arr[i] << ",";
    }

    os << ")";
    return os;
}


template class CSet<int>;
template class CSet<long>;
template class CSet<char>;
template class CSet<string>;

template ostream& operator<<(ostream& os, const CSet<int>& set);
template ostream& operator<<(ostream& os, const CSet<long>& set);
template ostream& operator<<(ostream& os, const CSet<char>& set);
template ostream& operator<<(ostream& os, const CSet<string>& set);