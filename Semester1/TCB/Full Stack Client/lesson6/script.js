const num1Span = document.getElementById("num1");
const num2Span = document.getElementById("num2");
const winSpan = document.getElementById("wins");
const failSpan = document.getElementById("fails");
const img = document.getElementById("img");

let winCount = 0;
let failCount = 0;

function gamble() {
    const num1 = Math.round(Math.random()*5) + 1;
    const num2 = Math.round(Math.random()*5) + 1;

    num1Span.innerHTML = `${num1}`;
    num2Span.innerHTML = `${num2}`;

    if (num1 == num2) {
        winCount++;
        img.src = 'win.jpg';
    } else {
        failCount++;
        img.src = 'fail.jpg';
    }

    winSpan.innerHTML = `${winCount}`;
    failSpan.innerHTML = `${failCount}`;
}