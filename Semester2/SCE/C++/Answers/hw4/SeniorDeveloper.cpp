#include "SeniorDeveloper.h"

SeniorDeveloper::SeniorDeveloper(string name, long id, int years, int hourlySalary, int monthlyHours,
    int *_codeReviews, int reviewSize, double* _specialBonuses, int bonusSize) :
    Developer(name, id, years, hourlySalary, monthlyHours, _codeReviews, reviewSize),
    bonusSize(bonusSize)
{
    specialBonuses = new double[bonusSize];

    for (int i = 0; i < bonusSize; i++) {
        specialBonuses[i] = _specialBonuses[i];
    }
}

SeniorDeveloper::~SeniorDeveloper() {
    delete[] specialBonuses;
}

double SeniorDeveloper::calculateSalary() const {
    double bonusSum = 0;

    for (int i = 0; i < bonusSize; i++) {
        bonusSum += specialBonuses[i];
    }

    return Developer::calculateSalary() + bonusSum;
}


void SeniorDeveloper::printInfo() const {
    cout << "Type: Senior Developer" << endl;
    Developer::printInfo();

    cout << "Project Bonuses: ";

    double total = 0;
    for (int i = 0; i < bonusSize; i++) {
        if (i != bonusSize - 1)
            cout << specialBonuses[i] << ", ";
        else
            cout << specialBonuses[i];

        total += specialBonuses[i];
    }

    cout << " (Total: " << total << ")" << endl;
}