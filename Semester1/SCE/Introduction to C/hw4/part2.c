/* Assignment: 4
Author: Guy Shitrit, ID: 330707761
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>


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
    *psize = 0;

    for (int i = 0; i <= big_size - small_size; i++) {
        int match = 1;

        for (int j = 0; j < small_size; j++) {
            if (big[i + j] != small[j]) {
                match = 0;
                break;
            }
        }

        if (match) {
            int* tmp = realloc(result, (*psize + 1) * sizeof(int));
            if (!tmp) {
                free(result);
                return NULL;
            }
            result = tmp;
            result[*psize] = i;
            (*psize)++;
        }
    }

    return (*psize == 0) ? NULL : result;
}


int main() {
    // char* string1 = "Chocolate";
    // char* string2 = "123";
    //
    // char* new_string = CreateString(string1, string2);
    // printf("%s", new_string);
    // free(new_string);

    #define BIG_SIZE 9
    #define SMALL_SIZE 3

    int big[BIG_SIZE] = {5,17,5,17,5,17,55,17,5};
    int small[SMALL_SIZE] = {17,5,17};

    int size = 0;

    int* arr = Start(big, BIG_SIZE, small, SMALL_SIZE, &size);
    for (int i = 0; i<size; i++) {
        printf("%d,", arr[i]);
    }

    return 0;
}
