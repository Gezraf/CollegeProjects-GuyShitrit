#include "Employee.h"


Employee::Employee(string name, long id, int years, int hourlySalary, int monthlyHours) :
    name( name), id(id), years(years),
    hourlySalary(hourlySalary), monthlyHours(monthlyHours) {}


void Employee::printInfo() const {
    cout << "Name: " << name <<  " | ID: " << id << " | Seniority: " << years << " years" << endl;
    cout << "Stats:" << "Rate " << hourlySalary << "/hr" << ", Hours: " << monthlyHours << endl;
}
