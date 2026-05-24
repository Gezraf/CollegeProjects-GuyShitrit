#include "RDCenter.h"
#define CENTERHEAD 1
#define SENIORDEV 2
#define JUNIORDEV 3
#define QA 4

RDCenter::RDCenter() : db(nullptr), size(0), isHeadExist(false) {}

RDCenter::~RDCenter() {
    for (int i = 0; i < size; i++) {
        delete[] db[i];
    }

    delete db;
}


void RDCenter::Init() {
    cout << "Enter number of employees:" << endl;
    cin >> size;

    db = new Employee*[size];

    for (int i = 0; i < size; i++) {
        int num = -1;

        while ((num != CENTERHEAD && num != SENIORDEV && num != JUNIORDEV && num != QA)
                || (num == CENTERHEAD && isHeadExist))
        {

            cout << "Choose Employee Type (1-Center Head, 2-Senior Dev, 3-Junior Dev, 4-QA):" << endl;
            cin >> num;

            if (num == CENTERHEAD && isHeadExist)
                cout << "Error: Center Head already exists! Please choose another type." << endl;
        }


        string name;
        long id;
        int years, hourlySalary, monthlyHours;

        cout << "Enter Name, ID, Seniority, Hourly Rate, Hours: ";
        cin >> name >> id >> years >> hourlySalary >> monthlyHours;

        switch (num) {
            case CENTERHEAD: {
                float responsibilityFactor;
                cout << "Enter Responsibility Factor (1.0-2.0): ";
                cin >> responsibilityFactor;

                db[i] = new CenterHead(name, id, years, hourlySalary, monthlyHours,
                                        responsibilityFactor);
                isHeadExist = true;
                break;
            }

            case SENIORDEV: {
                int reviewSize;
                cout << "How many Code Reviews? ";
                cin >> reviewSize;

                int* reviews = new int[reviewSize];
                cout << "Enter " << reviewSize << " scores: ";
                for (int j = 0; j < reviewSize; j++) {
                    cin >> reviews[j];
                }

                int bonusSize;
                cout << "How many Bonuses? ";
                cin >> bonusSize;

                double* bonuses = new double[bonusSize];
                cout << "Enter " << bonusSize << " bonus amounts: ";
                for (int j = 0; j < bonusSize; j++) {
                    cin >> bonuses[j];
                }

                db[i] = new SeniorDeveloper(name, id, years, hourlySalary, monthlyHours,
                                                reviews, reviewSize, bonuses, bonusSize);


                // Delete temporary arrays after deep copy
                delete[] reviews;
                delete[] bonuses;

                break;
            }

            case JUNIORDEV: {
                int reviewSize;
                cout << "How many Code Reviews? ";
                cin >> reviewSize;

                int* reviews = new int[reviewSize];
                cout << "Enter " << reviewSize << " scores: ";
                for (int j = 0; j < reviewSize; j++) {
                    cin >> reviews[j];
                }

                db[i] = new JuniorDeveloper(name, id, years, hourlySalary, monthlyHours,
                                                reviews, reviewSize);

                // Delete temporary array after deep copy
                delete[] reviews;

                break;
            }

            case QA: {
                int monthlyBugReports;
                cout << "Enter Monthly Bug Reports: ";
                cin >> monthlyBugReports;

                db[i] = new QAEngineer(name, id, years, hourlySalary, monthlyHours, monthlyBugReports);
                break;
            }
        }
    }
}


void RDCenter::PrintReport() const {
    cout << "--- R&D Center Personnel Report ---" << endl;
    for (int i = 0; i < size; i++) {
        db[i]->printInfo();
        cout << "Final Salary: " << db[i]->calculateSalary() << " NIS" << endl;
        cout << "-----------------------------------" << endl;
    }
}
