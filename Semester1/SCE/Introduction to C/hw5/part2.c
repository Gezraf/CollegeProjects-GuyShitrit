/*
   Assignment: 5
   Author: Guy Shitrit, ID: 330707761
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define TASK_NAME_SIZE 50

typedef struct {
    char TaskName[TASK_NAME_SIZE];
    int HoursSpent;
} Task;

typedef struct {
    long ID;
    int NumTasks;
    Task* tasks;
    int TotalHours;
} Employee;


void InputTask(Task*);
void PrintTask(Task);
void InputEmployee(Employee*);
void PrintEmployee(Employee);
Employee* InitProject(int*);
void PrintProject(Employee*, int);
void CalculateTotalHours(Employee*, int);


void InputTask(Task* pTask) {
    printf("Enter task name: ");
    fgets(pTask->TaskName, TASK_NAME_SIZE, stdin);
    fgets(pTask->TaskName, TASK_NAME_SIZE, stdin);
    pTask->TaskName[strcspn(pTask->TaskName, "\n")] = '\0';

    printf("Enter hours spent: ");
    scanf("%d", &pTask->HoursSpent);
}


void PrintTask(Task t) {
    printf("Task: %s, Hours: %d\n", t.TaskName, t.HoursSpent);
}


void InputEmployee(Employee* pE) {
    printf("Enter employee ID: ");
    scanf("%ld", &pE->ID);

    printf("Enter number of tasks: ");
    scanf("%d", &pE->NumTasks);

    pE->tasks = (Task*) malloc(pE->NumTasks * sizeof(Task));
    if (pE->tasks == NULL) {
        printf("Not enough space.");
        exit(1);
    }

    for (int i = 0; i < pE->NumTasks; i++) {
        printf("Task %d:\n", i + 1);
        InputTask(&pE->tasks[i]);
    }

    pE->TotalHours = 0; // איפוס השדה
}


void PrintEmployee(Employee e) {
    printf("Employee ID: %ld\nNumber of tasks: %d\n", e.ID, e.NumTasks);

    for (int i = 0; i < e.NumTasks; i++) {
        PrintTask(e.tasks[i]);
    }

    printf("Total Hours: %d\n", e.TotalHours);
    printf("-------------------------\n");
}


Employee* InitProject(int* pSize) {
    Employee* arr = NULL;
    *pSize = 0;

    int size;
    printf("Enter number of employees in the project: ");
    scanf("%d", &size);

    arr = (Employee*) malloc(size * sizeof(Employee));

    if (arr == NULL) {
        printf("Not enough space.");
        exit(1);
    }

    for (int i = 0; i < size; i++) {
        printf("Entering data for employee %d:\n", i + 1);
        InputEmployee(&arr[i]);
    }

    *pSize = size;

    return arr;
}


void PrintProject(Employee* pEmployees, int size) {
    printf("---Project Team---\n");
    for (int i = 0; i < size; i++) {
        PrintEmployee(pEmployees[i]);
    }
}

void CalculateTotalHours(Employee* pEmployees, int size) {
    for (int i = 0; i < size; i++) {
        int total = 0;
        for (int j = 0; j < pEmployees[i].NumTasks; j++) {
            total += pEmployees[i].tasks[j].HoursSpent;
        }

        pEmployees[i].TotalHours = total;
    }
}

int main() {
    Employee* projectTeam = NULL;
    int size;
    projectTeam = InitProject(&size);
    CalculateTotalHours(projectTeam, size);

    int total_hours = 0; // סכום סה"כ שעות עבודה של כל העובדים
    for (int i = 0; i < size; i++) {
        total_hours += projectTeam[i].TotalHours;
    }

    PrintProject(projectTeam, size);
    printf("--- Total hours for Team : %d ---", total_hours);

    for (int i = 0; i < size; i++) {
        free(&projectTeam[i]);
    }

    free(projectTeam);

    return 0;
}