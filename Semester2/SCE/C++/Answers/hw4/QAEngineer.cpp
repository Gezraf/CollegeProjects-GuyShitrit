#include "QAEngineer.h"

QAEngineer::QAEngineer(string name, long id, int years, int hourlySalary, int monthlyHours,
                        int monthlyBugReports) :
                        Employee(name, id, years, hourlySalary, monthlyHours),
                        monthlyBugReports(monthlyBugReports) {}

double QAEngineer::calculateSalary() const {
    return (hourlySalary * monthlyHours) + (monthlyBugReports * 15);
}


void QAEngineer::printInfo() const {
    cout << "Type: QA Engineer" << endl;
    Employee::printInfo();
    cout << "      Bug Reports: " << monthlyBugReports << endl;
}