#include "Student.h"
#include <iostream>
#include <string.h>

using namespace std;

Student::Student() : id(0), arr(nullptr), size(0) {
    cout << "Default Constructor" << endl;
    name = new char[100];
    strcpy(name, "Unknown");
    name[99] = '\0';
}

Student::Student(char* NAME, int ID, int* ARR, int SIZE) : id(ID), size(SIZE) {
    cout << "Constructor with parameters" << endl;
    name = new char[100];
    strcpy(name, NAME);
    name[99] = '\0';

    arr = new int[size];

    if (ARR == nullptr) {
        delete[] arr;
        arr = nullptr;
    } else {
        for (int i = 0; i < size; i++) {
            arr[i] = ARR[i];
        }
    }
}

Student::Student(Student& other) : id(other.id), size(other.size) {
    cout << "Copy Constructor" << endl;
    name = new char[100];
    strcpy(name, other.name);
    name[99] = '\0';

    arr = new int[size];
    if (other.arr != nullptr)
        for (int i = 0; i < size; i++) {
            arr[i] = other.arr[i];
        }
}

Student::~Student() {
    delete[] name;
    delete[] arr;
}


int* Student::GetGrades() {
    if (arr == nullptr)
        arr = new int[size];

    for (int i = 0; i < size; i++) {
        cout << "Input a number: ";
        cin >> arr[i];
    }

    return arr;
}

void Student::SetStudentName(char* other) {
    strcpy(name, other);
}

void Student::SetStudentID(int ID) { id = ID; }
void Student::SetSize(int SIZE) { size = SIZE; }

void Student::Print() {
    cout << "Student's name is " << name << endl;
    cout << "Student's ID is " << id << endl;
    cout << "Count of grades is " << size << endl;

    cout << "Student's grades: ";
    if (arr != nullptr)
        for (int i = 0; i < size; i++) {
            cout << arr[i] << " ";
        }

    cout << endl;
}

int Student::GradeAverage() {
    if (size == 0 || arr == nullptr) // אם המערך ריק נחזיר 0
        return 0;

    int sum = 0;
    for (int i = 0; i < size; i++) {
        sum += arr[i];
    }

    return sum / size;
}


void Student::PrintBigAverage(Student& other) {
    if (arr == nullptr || other.arr == nullptr)
        return;

    double avg1 = GradeAverage(), avg2 = other.GradeAverage();

    if (avg1 > avg2)
        cout << name << " average is big" << endl;
    else
        cout << name << " average is small" << endl;
}

