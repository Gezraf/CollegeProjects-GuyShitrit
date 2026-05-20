def Q1(n):
    if(n == 1):
        return 1

    return n + Q1(n-1)

def Q2(n):
    if n > 1:
        Q2(n // 2) # הרקורסיה פה קודם כדי שנגיע קודם לספרה השמאלית היותר
    print(n % 2, end="")

def Q3(n):
    if (n == 0):
        return 0
    return 1 + Q3(n // 10)

def Q4(d, n):
    if(n == 0):
        return 0
    if(n < 0): # אם המספר שנשלח הוא שלילי נהפוך אותו לחיובי
        return Q4(d, -n)

    if(n % 10 == d):
        return 1 + Q4(d, n // 10)

    return Q4(d, n // 10)

def Q5(n, d):
    if(n == 0):
        return 0

    if(n % 10 != d): # אם הספרה הימנית לא שווה לספרה שנרצה לדלג עליה
        return n % 10 + 10 * Q5(n // 10, d)

    return Q5(n // 10, d) # נדלג על הספרה