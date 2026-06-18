/*
Assignment: 5
   Author: Guy Shitrit
*/

#include <stdio.h>

int WorkToAverageFile(FILE* inputPtr, FILE* outputPtr) {
    char name[11]; // כולל שובר המחרוזת, על מנת שהמחרוזת באמת תהיה עד 10 תווים
    int days;
    int hours;

    int sum = 0;

    if (fscanf(inputPtr, "%10s %d", name, &days) != 2) {
        printf("Values not found.");
        return 0; // לא הצלחנו לקרוא מחרוזת עד 10 תווים ו/או מספר שלם, או שפשוט הגענו לסוף הקובץ
    }

    for (int i = 0; i < days; i++) {
        if (fscanf(inputPtr, "%d", &hours) != 1) {
            printf("Value not found."); // לא הצלחנו לקרוא מספר/ים שלמ/ים נוספ/ים, או שפשוט הגענו לסוף הקובץ
            return 0;
        }

        sum += hours;
    }

    float avg = (float) sum / days; // חישוב ממוצע
    fprintf(outputPtr, "%s %.1f\n", name, avg); // כתיבת שם העובד וממוצע שעות העבודה לתוך הקובץ המיועד

    return 1; // הצלחה
}

void main() {
    FILE* workPtr = fopen("workhours.txt", "r"); // פתיחת הקובץ workhours.txt

    if (workPtr == NULL) {
        printf("File wasn't found.");
        return;
    }

    FILE* avgPtr = fopen("averagehours.txt", "w"); // יצירת הקובץ averagehours.txt

    if (avgPtr == NULL) {
        printf("File not found or can't be created.");
        fclose(workPtr); // נרצה לצאת מהתוכנית מוקדם לכן נצטרך לסגור את הקובץ הראשון מוקדם
        return;
    }

    while (WorkToAverageFile(workPtr, avgPtr)) {} // כל עוד אפשר לקרוא מהקובץ הראשון נתונים נקרא לפונקציה

    fclose(workPtr); // סגירת הקבצים
    fclose(avgPtr);
}
