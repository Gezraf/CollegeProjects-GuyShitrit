#ifndef CPPWORK_JUNIORDEVELOPER_H
#define CPPWORK_JUNIORDEVELOPER_H
#include "Developer.h"


class JuniorDeveloper : public Developer { // This class represents a junior developer
public:
    JuniorDeveloper(string name, long id, int years, int hourlySalary, int monthlyHours,
                    int* _codeReviews, int reviewSize); // Constructor

    void printInfo() const override;
};



#endif
