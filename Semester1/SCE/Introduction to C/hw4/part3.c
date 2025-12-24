/* Assignment: 4
Author: Guy Shitrit, ID: 330707761
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void delete_row(int*** mat, int* rows, int target_row) { // פונקציית עזר שמוחקת שורה ממטריצה
    free((*mat)[target_row]); // נשחרר את השורה הרצויה מהזיכרון

    for (int i = target_row; i < *rows - 1; i++) {
        (*mat)[i] = (*mat)[i + 1];
        // נזיז את כל המערכים במטריצה לכיוון השורה ששוחררה מהזיכרון כך שהשורה האחרונה תהיה זבל ותצטרך להתקצץ מהמטריצה
    }

    (*mat) = realloc((*mat), (*rows - 1) * sizeof(int*)); // נקצה מחדש את המטריצה כך שאנחנו קוצצים את השורה האחרונה

    (*rows)--; // נפחית מכמות השורות של המטריצה (שנשלח על ידי כתובת)
}


void delete_col(int*** mat, int rows, int *cols, int target_col) { // פונקציית עזר שמוחקת עמודה ממטריצה
    if (target_col < *cols - 1) {
        for (int i = 0; i < rows; i++) {
            for (int j = target_col; j < *cols - 1; j++) {
                (*mat)[i][j] = (*mat)[i][j + 1];
                // נזיז את כל העמודות במטריצה לכיוון העמודה הרצויה שתידרס על ידם, ולאחר מכן העמודה האחרונה תהיה זבל ונוכל לשחרר אותה אחר כך
            }
        }
    }

    for (int i = 0; i < rows; i++) {
        (*mat)[i] = realloc((*mat)[i], (*cols - 1) * sizeof(int));
        // לאחר הזזת כל העמודות לעמודה הרצויה, העמודה האחרונה עכשיו זבל שנוכל לקצוץ מהמטריצה
    }

    (*cols)--;
}


void Minor(int*** pArr, int* pSize, int line, int col) {
    delete_row(pArr, pSize, line); // מחיקת שורה רצויה
    delete_col(pArr, *pSize, pSize, col); // מחיקת עמודה רצויה
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


int main() {
    int size = 10;
    int** mat = (int**) malloc(size * sizeof(int*));

    for (int i = 0; i < size; i++) {
        mat[i] = (int*) malloc(size * sizeof(int));
    }


    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            mat[i][j] = j;
        }
    }

    printf("Before:\n");
    printMatrix(mat, size, size);

    Minor(&mat, &size, 1, 1);
    printf("\n\n");

    printf("After: \n");
    printMatrix(mat, size, size);

    for (int i = 0; i < size; i++) {
        free(mat[i]);
    }

    free(mat);

    return 0;
}
