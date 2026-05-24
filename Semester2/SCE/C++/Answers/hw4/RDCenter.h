#ifndef CPPWORK_RDCENTER_H
#define CPPWORK_RDCENTER_H

#include "Employee.h"

#include "CenterHead.h"
#include "QAEngineer.h"

#include "Developer.h"
#include "JuniorDeveloper.h"
#include "SeniorDeveloper.h"


class RDCenter { // This class manages all employees in the R&D center
    Employee** db;
    int size;
    bool isHeadExist;

public:
    RDCenter(); // Default Constructor
    ~RDCenter(); // Destructor
    void Init(); // Initialize all employees
    void PrintReport() const; // Print all employee information
};



#endif
