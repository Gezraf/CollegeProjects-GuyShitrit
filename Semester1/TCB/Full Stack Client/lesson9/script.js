let secretCode = generateCode().split('');
let roundNumber = 1;
let possibleGuesses = generateAllCodes();
let gameEnded = false;

const feedback = document.getElementById('feedback');

function generateCode() {
    const digits = '0123456789';
    let code = '';
    while (code.length < 4) {
        const digit = digits[Math.floor(Math.random() * digits.length)];
        if (!code.includes(digit)) {
            code += digit;
        }
    }
    return code;
}

function checkInput() {
    const userInput = document.getElementById('guess').value;
    if (userInput.length !== 4 || new Set(userInput).size !== 4) {
        alert('Please enter a 4-digit code with different digits!');
        return;
    } else {
        checkUserGuess(userInput);
        return;
    }

}

function checkUserGuess(userInput) {
    const userGuess = userInput.split('');
    const bullsAndCows = getBullsAndCows(userGuess);

    const table = document.getElementById('table');
    const newRow = table.insertRow();
    newRow.innerHTML = `<td>${roundNumber}</td><td>${userGuess.join('')}</td><td>${bullsAndCows.bulls} Bulls, ${bullsAndCows.cows} Cows</td>`;
    roundNumber++;
}

function getBullsAndCows(guess) {
    let bulls = 0;
    let cows = 0;
    const secretCopy = [...secretCode];
    const guessCopy = [...guess];

    for (let i = 0; i < 4; i++) {
        if (guess[i] === secretCode[i]) {
            bulls++;
            secretCopy[i] = null;
            guessCopy[i] = null;
        }
    }

    for (let i = 0; i < 4; i++) {
        if (guessCopy[i] !== null && secretCopy.includes(guessCopy[i])) {
            cows++;
            secretCopy[secretCopy.indexOf(guessCopy[i])] = null;
        }
    }

    return { bulls, cows };
}

function generateAllCodes() {
    const allCodes = [];
    for (let i = 1000; i <= 9999; i++) {
        const codeString = i.toString();
        if (new Set(codeString).size === 4) {
            allCodes.push(codeString);
        }
    }
    return allCodes;
}


function updatePossibleGuesses(guessArray, bullsAndCows) {
    possibleGuesses = possibleGuesses.filter(code => {
        const codeArray = code.split('');
        const codeBullsAndCows = getBullsAndCows(codeArray);

        return codeBullsAndCows.bulls === bullsAndCows.bulls && codeBullsAndCows.cows === bullsAndCows.cows;
    });
}

function resetGame() {
    secretCode = generateCode().split('');
    roundNumber = 1;
    possibleGuesses = generateAllCodes();
    gameEnded = false;

    table.innerHTML = "";
    feedback.innerHTML = "<p style='color: red; font-size: 150%;'>Game Over</p>";
}
