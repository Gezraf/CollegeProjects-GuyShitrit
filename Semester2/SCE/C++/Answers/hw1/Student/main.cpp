#include <iostream>
#include "Student.h"

using namespace std;

int main()
{
    int* p = nullptr;   //use to saving grades of st2
    int* t = nullptr;   //use to saving grades of st3

    cout << "-------- st1--------" << endl;
    Student st1;   //use default constructor
    st1.Print();

    cout << "---------st2(Tom,123,p,5)-----" << endl;
    Student st2("Tom", 123, nullptr, 5);
    p = st2.GetGrades();  //grades array of st2
    st2.GetStudentName();
    st2.GetStudentID();
    int av = st2.GradeAverage();   //calculating the average value of st2
    cout << "average is " << av << endl;

    cout <<endl<< "-----------st3(st2)------------" << endl;
    Student st3(st2);//st3 //st3 is a copy of s2
    st3.Print();

    cout << endl<<"---------- - change st3--------" << endl;  //changing student's data
    st3.SetStudentName("Nati");
    st3.GetStudentName();
    st3.SetStudentID(45);
    st3.GetStudentID();
    st3.SetSize(6);
    t = st3.GetGrades();  //grades array of st3
    av = st3.GradeAverage();   //calculating the average value of st3
    cout << "average is " << av << endl;
    st3.Print();

    cout <<endl<< "------Big Average-st2 & st3-------" << endl;
    st3.PrintBigAverage(st2);    //comparison of average values st2 and st3

    return 0;
}