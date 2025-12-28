/* Assignment: 4
Author: Guy Shitrit, ID: 330707761
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>


void Minor(int*** mat, int* pSize, int target_row, int target_col)
{
    int size = *pSize;


    /*
        מחיקת שורה רצויה
    */

    free((*mat)[target_row]); // נשחרר את השורה הרצויה מהזיכרון

    for (int i = target_row; i < size - 1; i++) {
        (*mat)[i] = (*mat)[i + 1];
        // נזיז את כל המערכים במטריצה לכיוון השורה ששוחררה מהזיכרון כך שהשורה האחרונה תהיה זבל ותצטרך להתקצץ מהמטריצה
    }

    *mat = realloc(*mat, (size - 1) * sizeof(int*));
    // נקטין את גודל המטריצה באחד לאחר ששיחררנו את השורה הרצויה



    /*
        מחיקת עמודה רצויה
    */

    for (int i = 0; i < size - 1; i++) {
        for (int j = target_col; j < size - 1; j++) {
            (*mat)[i][j] = (*mat)[i][j + 1];
            //  נזיז את כל העמודות במטריצה לכיוון העמודה הרצויה שתידרס על ידם, ולאחר מכן העמודה האחרונה תהיה זבל ונוכל לשחרר אותה אחר כך

        }

        (*mat)[i] = realloc((*mat)[i], (size - 1) * sizeof(int));
        // לאחר הזזת כל העמודות לעמודה הרצויה, העמודה האחרונה עכשיו זבל שנוכל לקצוץ מהמטריצה
    }

    (*pSize)--; // עדכון המצביע לגודל המטריצה
}



void printMatrix(int** mat, int rows, int cols) { // פונקציית עזר שמדפיסה מטריצה ויזואלית
    for (int i = 0; i < rows; i++) {
        printf("{");
        for (int j = 0; j < cols; j++) {
            printf("%d", mat[i][j]);

            if (j != cols - 1) {
                printf(", ");
            }
        }
        printf("}");
        printf("\n");
    }
}


char** Decompose(char* str, int* pCount) {
    // בפונקציה זו נשתמש באלגוריתם "שני מצביעים" על מנת לתפוס אורכי מחרוזות המופרדים על ידי רווחים

    char** arr = NULL;
    int count = 0;
    int length = strlen(str);
    int left = 0;

    while (left < length && str[left] == ' ') // אם יש במחרוזת רווחים בהתחלה, נדלג עליהם
        left++;

    for (int right = left; right <= length; right++) {
        if (str[right] == ' ' || str[right] == '\0') {
            int word_len = right - left;
            if (word_len > 0) {
                arr = realloc(arr, (count + 1) * sizeof(char*)); // נאריך את המערך כך שתיווצר מחרוזת אחת יותר
                arr[count] = malloc(word_len + 1); // נקצה בית אחד יותר מאורך המחרוזת כיוון שיש גם את עוצר המחרוזת

                memcpy(arr[count], str + left, word_len); // נעתיק word_len בתים החל מהמצביע השמאלי במחרוזת, לתוך המערך
                arr[count][word_len] = '\0'; // נשים עוצר מחרוזת בסוף המחרוזת שתפסנו והקצנו למערך

                count++;
            }

            while (str[right] == ' ') // בהנחה שניתקל בעוד רווחים בהמשך, נרצה לדלג עליהם
                right++;
            left = right; // נזיז את המצביע השמאלי לימני כדי שנוכל לתפוס את המחרוזות הבאות
        }
    }

    *pCount = count; // נעדכן את count בעזרת המצביע שלו
    return arr;
}

void SortWords(char** arr, int size) { // מיון בועות למחרוזות
    for (int i = 0; i < size - 1; i++) {
        for (int j = 0; j < size - 1 - i; j++) {
            if (strcmp(arr[j], arr[j+1]) > 0) { // הפונקציה strcmp עוזרת לנו לקבוע איזו מחרוזת גדולה/קטנה יותר מבחינת סדר אלפביתי
                char* tmp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tmp;
            }
        }
    }
}

void PrintWords(char** arr, int count) {
    for (int i = 0; i < count; i++) {
        printf("%s", arr[i]);

        if (i != count - 1)
            printf(", ");
    }
}


int main() {
    int size, row, col;
    printf("Enter the size of the matrix: ");
    scanf("%d", &size);

    int** mat = (int**) malloc(size * sizeof(int*));

    for (int i = 0; i < size; i++) {
        mat[i] = (int*) malloc(size * sizeof(int));
    }

    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            printf("Insert number into the matrix (line %d): ", i);
            scanf("%d", &mat[i][j]);
        }
    }

    printf("Enter the line you want to delete: ");
    scanf("%d", &row);

    printf("Enter the column you want to delete: ");
    scanf("%d", &col);


    printf("Before:\n");
    printMatrix(mat, size, size);

    Minor(&mat, &size, row, col);
    printf("\n\n");

    printf("After: \n");
    printMatrix(mat, size, size);

    for (int i = 0; i < size; i++) {
        free(mat[i]);
    }

    free(mat);

    #define SIZE 80

    char string[SIZE];
    printf("Enter string: ");
    fgets(string, SIZE, stdin);
    // היה לי באג שלא נתן לי לקלוט את המחרוזת אחרי השאלה הקודמת, לכן נאלצתי "לאכול" את הn\ שהfgets הקודם קלט בעזרת עוד fgets
    fgets(string, SIZE, stdin);
    string[strcspn(string, "\n")] = '\0'; // לא נשכח להחליף את שובר השורה בסוף המחרוזת בעוצר מחרוזת

    int arr_size = 0;
    char** arr = Decompose(string, &arr_size);
    printf("Before sort:\n");
    PrintWords(arr, arr_size);

    printf("\n\nAfter sort:\n");
    SortWords(arr, arr_size);
    PrintWords(arr, arr_size);

    for (int i = 0; i < arr_size; i++) {
        free(arr[i]);
    }

    free(arr);

    return 0;
}
