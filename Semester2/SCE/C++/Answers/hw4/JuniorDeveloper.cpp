#include "JuniorDeveloper.h"


JuniorDeveloper::JuniorDeveloper(string name, long id, int years, int hourlySalary, int monthlyHours,
    int* _codeReviews, int reviewSize) :
    Developer(name, id, years, hourlySalary, monthlyHours, _codeReviews, reviewSize) {}
    // Initialize junior developer using Developer's constructor


void JuniorDeveloper::printInfo() const {
    cout << "Type: Junior Developer" << endl;
    Developer::printInfo();
}