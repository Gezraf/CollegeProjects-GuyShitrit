cmake_minimum_required(VERSION 4.2)
project(cppWork)

set(CMAKE_CXX_STANDARD 20)

add_executable(cppWork main.cpp
        Employee.cpp
        Employee.h
        JuniorDeveloper.cpp
        JuniorDeveloper.h
        SeniorDeveloper.cpp
        SeniorDeveloper.h
        Developer.cpp
        Developer.h
        CenterHead.cpp
        CenterHead.h
        QAEngineer.cpp
        QAEngineer.h
        RDCenter.cpp
        RDCenter.h
)
