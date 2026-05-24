#ifndef CPPWORK_EMPLOYEE_H
#define CPPWORK_EMPLOYEE_H

#include <string>
#include <iostream>
#pragma once

using namespace std;

class Employee { // This class represents an employee in the company
protected:
    string name;
    long id;
    int years;
    int hourlySalary;
    int monthlyHours;

public:
    Employee(string name, long id, int years, int hourlySalary, int monthlyHours); // Constructor
    virtual ~Employee() {} // Virtual destructor for polymorphism deletion
    virtual double calculateSalary() const = 0; // Calculates employee salary
    virtual void printInfo() const; // Prints employee information
};


#endif