#ifndef CPPWORK_DEVELOPER_H
#define CPPWORK_DEVELOPER_H
#include "Employee.h"


class Developer : public Employee { // This class represents a developer employee
protected:
    int* codeReviews;
    int reviewSize;

public:
    Developer(string name, long id, int years, int hourlySalary, int monthlyHours,
              int* codeReviews, int reviewSize); // Constructor
    virtual ~Developer(); // Virtual destructor for polymorphism deletion among developers
    virtual double calculateSalary() const;
    virtual void printInfo() const;
};


#endif
