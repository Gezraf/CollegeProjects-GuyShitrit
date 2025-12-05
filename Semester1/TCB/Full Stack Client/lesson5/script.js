/* Assignment: 4
   Author: Guy Shitrit, ID: 330707761
*/

// הערה: תשים הערה על כל קוד שאתה לא רוצה להריץ כדי להריץ תרגיל מסוים (כי רצית בלי פונקציות)


// ex1
let guy = "";
for(let i = 1; i < 50; i+=2) 
   guy += (i + " "); // קופץ ב-2 החל מ-1 במקום לבדוק אי-זוגיות

alert(guy);


// ex2
let num = parseInt(prompt("Enter a number: "))
let oddDigits = 0;
let remainder;

while(num != 0) {
    remainder = num % 10;
    if (remainder % 2 == 1) 
        oddDigits++;

    num = Math.floor(num / 10);
}

alert(`The amount of odd digits is ${oddDigits}`);


// ex3
let sum = 0;

for(let i = 200; i <= 300; i++) {
    sum += i;
}

alert(`The sum is ${sum}`);


// ex4
let guy = "";
for (let i = 1000; i <= 9999; i++) {
    const ones = i % 10;
    const tens = Math.floor(i / 10) % 10;
    const hundreds = Math.floor(i / 100) % 10;
    const thousands = Math.floor(i / 1000);

    const left = thousands * 10 + hundreds;
    const right = tens * 10 + ones;

    const sum = left + right;

    if (sum * sum == i) 
        guy += (i + " ");
}

alert(guy);


// ex5
const num = parseInt(prompt("Enter a number: "));
let divisorSum = 0;

for (let i = 1; i < num; i++) {
    if (num % i == 0) 
        divisorSum += i;
}

if (divisorSum == num) {
    alert("The number is balanced.")
} else {
    alert("The number is NOT balanced.");
}
