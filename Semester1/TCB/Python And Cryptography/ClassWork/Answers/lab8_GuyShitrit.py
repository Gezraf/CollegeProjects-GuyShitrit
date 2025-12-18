# Assignment: 8
# Author: Guy Shitrit, ID: 330707761

def integral(a,b,f):
    delta_x = (b - a) / 100
    sum = 0

    expression = lambda k: f(a + k * delta_x) * delta_x # ביטוי

    for k in range(0, 100): # [0-99]
        sum += expression(k)

    return sum

def derivat(f):
    delta_x = 0.0001
    return lambda x: (f(x + delta_x) - f(x)) / delta_x # יחזיר את פונקציית הנגזרת בהתאם לנוסחה

def derivat_twice(f):
    return derivat(derivat(f)) # נגזרת של נגזרת

def partial_derivat_x(f):
    delta_x = 0.0001
    return lambda x,y: (f(x + delta_x,y) - f(x,y)) / delta_x  # יחזיר את פונקציית הנגזרת החלקית ע"פ איקס בהתאם לנוסחה

def partial_derivat_y(f):
    delta_y = 0.0001
    return lambda x, y: (f(x,y + delta_y) - f(x,y)) / delta_y  # יחזיר את פונקציית הנגזרת החלקית ע"פ איקס בהתאם לנוסחה

def like_fib(f):
    g = lambda n: f(n-2) + f(n-1)
    return g

def smooth(f):
    g = lambda n: (f(n - 1) + f(n) + f(n+1)) / 3
    return g