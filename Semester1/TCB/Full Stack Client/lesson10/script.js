let numbers = [];
let currentGuess = null;
let secretCode = null;
let gameActive = false;

const CODE_LENGTH = 3;
const feedbackElement = document.getElementById('feedback');
const botGuessElement = document.getElementById('botGuess');
const messageElement = document.getElementById('message');

function isValid(num) {
    let s = String(num);
    return s[0] !== s[1] && s[0] !== s[2] && s[1] !== s[2];
}

function startGame() {
    numbers = [];

    messageElement.style.color = "black";

    secretCode = Math.floor(Math.random() * (499 - 100 + 1)) + 100;

    for (let n = 100; n <= 499; n++) {
        if (isValid(n)) numbers.push(n);
    }

    gameActive = true;
    messageElement.innerText = "Game Started!";
    makeGuess();
}

function makeGuess() {
    if (!gameActive) return;

    if (numbers.length === 0) {
        messageElement.innerText = "No numbers left!";
        messageElement.style.color = "red";
        return;
    }

    currentGuess = numbers[Math.floor(Math.random() * numbers.length)];
    botGuessElement.innerHTML = `Bot's Guess: ${currentGuess}`;
}

function bc(guess, real) {
    let g = String(guess);
    let r = String(real);

    let bulls = 0, cows = 0;
    for (let i = 0; i < CODE_LENGTH; i++) {
        if (g[i] === r[i]) bulls++;
        else if (r.includes(g[i])) cows++;
    }
    return { bulls, cows };
}

function sendBC() {
    if (!gameActive) return;

    messageElement.style.color = "black";

    let B = parseInt(document.getElementById("bulls").value);
    let C = parseInt(document.getElementById("cows").value);

    if (isNaN(B) || isNaN(C) || B < 0 || B > CODE_LENGTH || C < 0 || C > CODE_LENGTH) {
        alert("Please enter valid values for Bulls and Cows (0-CODE_LENGTH).");
        return;
    }

    numbers = numbers.filter(num => {
        let res = bc(currentGuess, num);
        return res.bulls === B && res.cows === C;
    });

    feedbackElement.innerHTML = `<p>Number List: ${numbers}</p>`;
    makeGuess();
}

function checkWin() {
    if (!gameActive) return;

    if (currentGuess === secretCode) {
        messageElement.innerText = "Bot correctly guessed the secret code!";
        gameActive = false;
    } else {
        messageElement.innerText = "Bot has not yet guessed the correct code.";
    }
}
