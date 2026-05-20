#ifndef OOP_STRINGMANIPULATOR_H
#define OOP_STRINGMANIPULATOR_H

class StringManipulator {
    char string[80];

    public:
        StringManipulator(char[]);

        char* GetString() { return string; }
        void SetString(char[]);

        void Display_String();
        void Rotate_Left(int);
        void Rotate_Right(int);
        void Display_Substring(int, int);
        int Sum_Of_Number();
        char Most_Common_Letter();
        int Count_Of_Words();

};

#endif //OOP_STRINGMANIPULATOR_H