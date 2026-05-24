#include "CenterHead.h"


CenterHead::CenterHead(string name, long id, int years, int hourlySalary, int monthlyHours,
                        float responsibilityFactor) :
                        Employee(name, id, years, hourlySalary, monthlyHours),
                        responsibilityFactor(responsibilityFactor) {}

double CenterHead::calculateSalary() const {
    return (hourlySalary * monthlyHours) * responsibilityFactor;
}


void CenterHead::printInfo() const {
    cout << "Type: Center Head" << endl;
    Employee::printInfo();
    cout << "      Factor: " << responsibilityFactor << endl;

}