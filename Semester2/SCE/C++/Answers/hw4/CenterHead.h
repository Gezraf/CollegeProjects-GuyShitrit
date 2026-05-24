#ifndef CPPWORK_CENTERHEAD_H
#define CPPWORK_CENTERHEAD_H
#include "Employee.h"


class CenterHead : public Employee { // This class represents the center head employee
    double responsibilityFactor;
public:
    CenterHead(string name, long id, int years, int hourlySalary, int monthlyHours,
                float responsibilityFactor); // Constructor
    double calculateSalary() const override;
    void printInfo() const override;
};


#endif
