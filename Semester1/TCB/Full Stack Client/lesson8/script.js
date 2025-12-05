const now = new Date();

const time = now.toLocaleTimeString();
const date = now.toLocaleDateString();

const field = document.getElementById("field");


function onlyDigits() {
    const numberInput = document.getElementById("numberInput").value;

    for (let i = 0; i < numberInput.length; i++) {
        if (!(numberInput[i] >= '0' && numberInput[i] <= '9')) { // טווח טבלת אסקי לבדיקה האם התו הוא ספרה בין 0 ל-9
            field.innerHTML = "Number must only contain digits.";
            return;
        }
    }

    field.innerHTML = "Valid number!";
}


function onlyLetters() {
    const nameInput = document.getElementById("nameInput").value;

    for (let i = 0; i < nameInput.length; i++) {
        if (!(nameInput[i] >= 'A' && nameInput[i] <= 'z')) { // טווח טבלת אסקי לבדיקת האם התו הוא אות
            field.innerHTML = "Name must only contain letters.";
            return;
        }
    }

    field.innerHTML = "Valid name!";
}



function validEmail() {
    const emailInput = document.getElementById("emailInput").value;
    const index = emailInput.indexOf('@'); // השג את האינדקס של התו הראשון שבו @ מופיע

    if (index != -1) {
        const substr = emailInput.substring(index + 1); // תשיג את התת מחרוזת החל מהתו אחרי @ עד סוף המחרוזת

        if(substr != "gmail.com") {
            field.innerHTML = "Email must have 'gmail.com' at the end.";
            return;
        }

        field.innerHTML = "Valid email!";
        return;
    }

    field.innerHTML = "Email must have '@'."
}

function showTime() {
    field.innerHTML = `Current time: ${time}`;
}


function showDate() {
    field.innerHTML = `Current date: ${date}`;
}

