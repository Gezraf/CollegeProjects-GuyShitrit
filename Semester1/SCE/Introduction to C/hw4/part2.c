/* Assignment: 4
Author: Guy Shitrit, ID: 330707761
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void printArray(int* arr, int size) { // פונקציית עזר שמדפיסה מערך ויזואלית
    printf("{");
    for (int i = 0; i < size; i++) {
        printf("%d", arr[i]);

        if (i != size - 1)
            printf(",");
    }

    printf("}");
}


char* CreateString(char* string1, char* string2) {
    const int length1 = strlen(string1), length2 = strlen(string2);

    const int size = length1 + length1 * length2 + 1; // כמות התווים במחרוזת החדשה, הפלוס אחד בסוף זה בשביל עוצר המחרוזת
    char* new_string = (char*)malloc(size); // הקצאת זיכרון לגודל המחרוזת החדשה

    int index = 0;

    for (int i = 0; i<length1; i++) {
        new_string[index] = string1[i];
        index++;
        for (int j = 0; j<length2; j++) {
            new_string[index] = string2[j];
            index++;
        }
    }

    new_string[index] = '\0'; // לא לשכוח לשים את עוצר המחרוזת בסוף

    return new_string;
}

int* Start(int* big, int big_size, int* small, int small_size, int* psize) {
    int* result = NULL;

    for (int i = 0; i <= big_size - small_size; i++) {
        int match_flag = 1;

        for (int j = 0; j < small_size; j++) {
            if (big[i + j] != small[j]) {
                match_flag = 0;
                break;
            }
        }

        if (match_flag) {
            int* temp = realloc(result, (*psize + 1) * sizeof(int));
            if (!temp) {
                free(result);
                return NULL;
            }
            result = temp;
            result[*psize] = i;
            (*psize)++;
        }
    }

    if (*psize == 0)
        return NULL;

    return result;
}


int main() {
    #define MAX_SIZE 1000

    char string1[MAX_SIZE];
    char string2[MAX_SIZE];

    printf("Enter first string: ");
    fgets(string1, sizeof(string1), stdin);
    string1[strcspn(string1, "\n")] = '\0'; // עדכון האינדקס של ירידת השורה במחרוזת בעוצר מחרוזת על מנת שהמחרוזת תהיינה תקינה

    printf("Enter second string: ");
    fgets(string2, sizeof(string2), stdin);
    string2[strcspn(string2, "\n")] = '\0'; // עדכון האינדקס של ירידת השורה במחרוזת בעוצר מחרוזת על מנת שהמחרוזת תהיינה תקינה

    char* new_string = CreateString(string1, string2);
    printf("%s\n", new_string);
    free(new_string);


    int big_size, small_size;
    printf("Enter the size of the big array: ");
    scanf("%d", &big_size);

    printf("Enter the size of the small array: ");
    scanf("%d", &small_size);

    int big[big_size];
    int small[small_size];

    for (int i = 0; i<big_size; i++) {
        printf("Insert number into big array: ");
        scanf("%d", &big[i]);
    }

    for (int i = 0; i<small_size; i++) {
        printf("Insert number into small array: ");
        scanf("%d", &small[i]);
    }

    int result_size = 0;
    int* arr = Start(big, big_size, small, small_size, &result_size);
    printArray(arr, result_size);
    free(arr);

    return 0;
}
