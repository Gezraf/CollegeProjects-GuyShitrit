/*
   Assignment: 5
   Author: Guy Shitrit, ID: 330707761
*/

#include <stdio.h>

int SumPrimeDigits(int num) {
    if (num == 0) {
        return 0;
    }

    const int digit = num % 10;
    if (digit == 2 || digit == 3 || digit == 5 || digit == 7) { // אם הספרה הימנית חלק מ2,3,5,7 אז היא ראשונית
        return digit + SumPrimeDigits(num / 10);
    }

    return SumPrimeDigits(num / 10);
}


int EvenMinusOdd(int num) {
    if (num == 0)
        return 0;

    if ((num % 10) % 2 == 0)
        return 1 + EvenMinusOdd(num / 10); // הוסף 1 עבור ספרה זוגית

    return -1 + EvenMinusOdd(num / 10); // החסר 1 עבור ספרה אי-זוגית
}


void PrintOctal(int num) {
    if (num == 0)
        return;

    PrintOctal(num / 8); // קריאה רקורסיבית לפני הדפסה כדי שנגיע עד לתו האחרון קודם (דרך מחסנית הרקורסיה)
    printf("%d", num % 8);
}

int IsDescSorted(int* arr, int size) {
    if (size <= 1) {
        // בגלל שאנחנו עשויים לחרוג מהמערך בסופו בגלל הבדיקה הבאה, נצטרך לבדוק החל מקטן או שווה ל1
        return 1;
    }

    if (*arr < *(arr + 1)) // אם התא הנוכחי קטן מהתא הבא המערך כבר לא ממויין בסדר יורד
        return 0;

    return IsDescSorted(arr + 1, size - 1);
    // נעבור לתא הבא ונפחית מהגודל (כדי שנפגוש את בסיס הרקורסיה)
}

#define FAIL 56
int CountFailed(int* arr, int size) {
    if (size == 0) {
        return 0;
    }

    if (*arr < FAIL) {
        return 1 + CountFailed(arr + 1, size - 1);
    }

    return CountFailed(arr + 1, size - 1);
}

int SumDigits(char* str) {
    if (*str == '\0') {
        return 0;
    }

    return (*str - '0') + SumDigits(str + 1);
}


int helper(char* str, int balance) { // פונקציית עזר שמקבלת את המחרוזת ומספר שלם שמאזן את ערכו בהתאם לסוגריים
    if (*str == '\0') { // אם הגענו לסוף, נחזיר אמת או שקר בהתאם להאם המספר שווה אפס או לא
        return balance == 0;
    }

    if (balance < 0)
        return 0;

    if (*str == '(') // אם התו הנוכחי הוא סוגר 'פותח' נעלה את המספר המאזן ב1
        return helper(str + 1, balance + 1);

    if (*str == ')') // אם התו הנוכחי הוא סוגר 'סוגר' נפחית את המספר המאזן ב1
        return helper(str + 1, balance - 1);

    return 0; // מקרה קצה - אם הגענו לפה סימן שהתו הנוכחי הוא לא סוגר
}

int isValidParentheses(char* str) {
    return helper(str, 0); // קריאה לפונקצייה העזר
}

int main() {
    int ar1[]={9,7,5,2}, ar2[]={1,7,5,2};
    int grade[]={100,81,49,32,56,81,56,49};
    char str[]="123456";
    char s1[] = "((()))";
    char s2[] = "(()()";
    char s3[] = "(())()";

    printf("%d\n", SumDigits(str)); //21
    PrintOctal(100); //144
    printf("\n");

    printf("%d\n", EvenMinusOdd(4827)); //2
    printf("%d %d\n", SumPrimeDigits(35241), SumPrimeDigits(2468)); //10 2
    printf("%d %d\n", IsDescSorted(ar2,4), IsDescSorted(ar1,4)); //0 1
    printf("%d\n", CountFailed(grade,8)); //3

    printf("%s -> %d\n", s1, isValidParentheses(s1)); //1
    printf("%s -> %d\n", s2, isValidParentheses(s2)); //0
    printf("%s -> %d\n", s3, isValidParentheses(s3)); //0

    return 0;
}