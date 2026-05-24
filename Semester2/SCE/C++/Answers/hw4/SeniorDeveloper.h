#ifndef CPPWORK_SENIORDEVELOPER_H
#define CPPWORK_SENIORDEVELOPER_H
#include "Developer.h"


class SeniorDeveloper : public Developer { // This class represents a senior developer (with bonuses)
    double *specialBonuses;
    int bonusSize;
public:
    SeniorDeveloper(string name, long id, int years, int hourlySalary, int monthlyHours,
                    int* _codeReviews, int reviewSize, double* _specialBonuses, int bonusSize); // Constructor
    ~SeniorDeveloper(); // Destructor
    double calculateSalary() const override;
    void printInfo() const override;
};



#endif
