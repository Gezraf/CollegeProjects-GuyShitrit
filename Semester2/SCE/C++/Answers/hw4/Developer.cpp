#include "Developer.h"

Developer::Developer(string name, long id, int years, int hourlySalary, int monthlyHours,
int* _codeReviews, int reviewSize) :
        Employee(name, id, years, hourlySalary, monthlyHours), reviewSize(reviewSize)
{
    codeReviews = new int[reviewSize];

    for (int i = 0; i < reviewSize; i++) {
        codeReviews[i] = _codeReviews[i];
    }
}

Developer::~Developer() {
    delete[] codeReviews;
}

double Developer::calculateSalary() const {
    double sum = 0;

    if (reviewSize <= 0)
        return 0;

    for (int i = 0; i < reviewSize; i++) {
        sum += codeReviews[i];
    }
    
    const double average = sum / reviewSize;
    return (hourlySalary * monthlyHours) + average;
}


void Developer::printInfo() const {
    Employee::printInfo();

    cout << "Code Reviews: ";

    double sum = 0;
    for (int i = 0; i < reviewSize; i++) {
        if (i != reviewSize - 1)
            cout << codeReviews[i] << ", ";
        else
            cout << codeReviews[i];

        sum += codeReviews[i];
    }

    const double average = sum / reviewSize;
    cout << " (Average: " << average << ")" << endl;
}