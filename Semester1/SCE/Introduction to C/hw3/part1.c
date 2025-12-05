/* Assignment: 3
Author: Guy Shitrit, ID: 330707761
*/

#include <stdio.h>
#include <math.h>
#define COUNTS_SIZE 21

void printAsteriks(int);

void HistogramArray(int arr[], int size) {
    int counts[COUNTS_SIZE]; // המספרים במערך arr יכולים להיות בין 0-20, סה"כ 21 מספרים, ולכן נצטרך 21 תאים במערך עזר כדי לספור אותם

    for(int i = 0; i<COUNTS_SIZE; i++)
        counts[i] = 0; // נאתחל כל תא במערך עזר ל0

    for(int i = 0; i<size; i++)
        counts[arr[i]]++; // נעלה את הספירה של אותו מספר ע"י קידום הספירה באינדקס המתאים לפי ערך המספר

    printf("Value\tHistogram\n");

    for(int i = 0; i<COUNTS_SIZE; i++) {
        if(counts[i]) {
            printf("%d\t", i);
            printAsteriks(counts[i]);
            printf("\n");
        }
    }

}

void printAsteriks(int count) { // פונקציה שמקבלת מספר שלם ומדפיסה מספר כוכביות בהתאם למספר
    for(int i = 0; i<count; i++) {
        printf("*");
    }
}



void PrintMaxPartAscending(int arr[], int size) {
    int currentSequence = 0, maxSequence = 0, endIndex = 0;

    for(int i = 0; i<size - 1; i++) {
        if(arr[i] < arr[i+1]) // אם האיבר הבא גדול מהאיבר הנוכחי, נקדם את הרצף העולה הנוכחי
            currentSequence++;
        else
            currentSequence = 0;

        if(currentSequence > maxSequence) { //  נעדכן את הרצף העולה המקסימלי, ונשמור את האינדקס בו הרצף נגמר (כולל)
            maxSequence = currentSequence;
            endIndex = i + 1;
        }
    }

    if (maxSequence == 0) {
        printf("No such segment!");
    } else {
        int startIndex = endIndex - maxSequence; // חישוב האינדקס ההתחלתי של הרצף העולה הגדול ביותר לפי הפרש האינדקס הסופי ברצף המקסימלי שנמצא
        for(int i = startIndex; i<endIndex + 1; i++) {
            printf("%d ", arr[i]);
        }
    }
}

int main() {
    int arr[10] = {-2, 8, 23, -160, -74, 8, 85, -47, 12, 7};

    PrintMaxPartAscending(arr, 10);
    return 0;
}