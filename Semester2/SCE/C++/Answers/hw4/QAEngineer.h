#ifndef CPPWORK_QAENGINEER_H
#define CPPWORK_QAENGINEER_H
#include "Employee.h"


class QAEngineer : public Employee { // This class represents a QA engineer
    int monthlyBugReports;
public:
    QAEngineer(string name, long id, int years, int hourlySalary, int monthlyHours,
                int monthlyBugReports); // Constructor
    double calculateSalary() const override;
    void printInfo() const override;
};


#endif
