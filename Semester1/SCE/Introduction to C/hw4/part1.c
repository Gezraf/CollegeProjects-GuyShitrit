/* Assignment: 4
Author: Guy Shitrit, ID: 330707761
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>


int floor(float num) { // פונקציית עזר שמחזירה את המספר השלם הקרוב והקטן ביותר למספר העשרוני שנשלח ע"י המרה למספר שלם
    return (int) num;
}

float getDecimal(float num) { // פונקציית עזר שמחזירה את ה"חלק השבור" של המספר העשרוני לפי הפרש המספר בחלקו השלם
    return num - floor(num);
}

float* sums(float arr[], int size) {
    float integerSum = 0;
    float decimalSum = 0;

    float* ptr = (float*)malloc(2*sizeof(float)); // הקצאת זיכרון לשתי מספרים ממשיים כדי לשמור את שני התוצאות

    for (int i = 0; i<size; i++) {
        integerSum += floor(arr[i]);
        decimalSum += getDecimal(arr[i]);
    }

    ptr[0] = integerSum; // שמירת תוצאת סכום החלקים השלמיים בתא הזיכרון הראשון
    ptr[1] = decimalSum; // שמירת תוצאת סכום החלקים ה"שבורים" בתא הזיכרון השני

    return ptr;
}

int main() {
    int size;
    printf("Enter the size of numbers in the array: ");
    scanf("%d", &size); // קלט גודל המערך מהמשתמש

    float arr[size];
    for (int i = 0; i<size; i++) {
        printf("Insert number into array: ");
        scanf("%f", &arr[i]); // קלט מספרים ממשיים לתוך המערך
    }

    float* ptr = sums(arr, size); // המצביע שאמור לקבל את שני התוצאות
    printf("%d , %f", (int) ptr[0], ptr[1]);
    free(ptr); // לא שכחתי לשחרר (:

    return 0;
}
