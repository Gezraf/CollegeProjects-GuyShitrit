const currQuestion = document.getElementById("currentQuestion");
const options = document.getElementsByName("option");
const answerField = document.getElementById("answerField");
const feedback = document.getElementById("feedback");
const questionCounter = document.getElementById("questionCounter");

const NUMBER_OF_QUESTIONS = 10;

let answer;
let operation = "";
let questionIndex = 0;
let correctAnswers = 0;
let examStarted = false;

function operationPressed() {
    for (let i = 0; i < options.length; i++) {
        if (options[i].checked) {
            return options[i].value;
        }
    }
    return "";
}

function exercise() {
    operation = operationPressed();
    if(!operation) return;

    if (questionIndex >= NUMBER_OF_QUESTIONS) {
        feedback.innerHTML = "Exam finished!";
        return;
    }

    let num1 = Math.round(Math.random() * 100) + 1;
    const num2 = Math.round(Math.random() * 100) + 1;

    switch (operation) {
        case "+":
            answer = num1 + num2;
            break;
        case "-":
            answer = num1 - num2;
            break;
        case "*":
            answer = num1 * num2;
            break;
        case "/":
            num1 = num2 * (Math.round(Math.random()*10) +1); // כדי שיהיו משוואות חילוק עם מנות שלמות עשיתי שהמספר הראשון ייקבע על פי המספר השני עבור חילוק 
            answer = num1 / num2;
            break;
    }

    currQuestion.innerHTML = `${num1} ${operation} ${num2}`;
    if (examStarted)
        questionCounter.innerHTML = `Question ${questionIndex + 1}/${NUMBER_OF_QUESTIONS}`
    answerField.value = "";
}


function checkAnswer() {
    const userInput = parseInt(answerField.value);

    if (userInput === answer) {
        feedback.innerText = "Correct!";
        feedback.style.color = "green";
        if(examStarted) correctAnswers++;
    } else {
        feedback.innerText = "Wrong!";
        feedback.style.color = "red";
    }

    if(examStarted) questionIndex++;

    if (questionIndex === NUMBER_OF_QUESTIONS) {
        const finalScore = (correctAnswers / NUMBER_OF_QUESTIONS) * 100;
        feedback.style.color = "blue";
        feedback.innerHTML = `Your final score: ${Math.round(finalScore)}%`;
        questionCounter.innerHTML = '';
        examStarted = false;
    }
}

function exam() {
    if(operationPressed()){
    questionIndex = 0;
    correctAnswers = 0;
    examStarted = true;

    feedback.style.color = "black";
    feedback.innerHTML = `Exam started! Solve ${NUMBER_OF_QUESTIONS} questions.`;

    exercise();
}
}
