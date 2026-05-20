#ifndef OOP_STUDENT_H
#define OOP_STUDENT_H

class Student {
    char* name;
    int id, *arr, size;

    public:
        Student();
        Student(char[], int, int*, int);
        Student(Student&);
        ~Student();

        char* GetStudentName() { return name; }
        int GetStudentID() { return id; }
        int* GetGrades();

        void SetStudentName(char*);
        void SetStudentID(int);
        void SetSize(int);

        void Print();
        int GradeAverage();
        void PrintBigAverage(Student&);
};

#endif //OOP_STUDENT_H