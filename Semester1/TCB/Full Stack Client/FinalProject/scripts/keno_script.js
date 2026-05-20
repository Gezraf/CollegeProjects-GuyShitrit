const boardContainer = document.getElementById("board");
const rows = 5;
const cols = 8;
const totalCells = rows * cols;

let pressed_buttons = document.querySelectorAll(".board-cell.active").length;
const min_pressed = 3;
const max_pressed = 10;
const chosen_amount = 10;

let gameRunning = false;

const paytable = {
                    3:  {1: 1.2, 2: 3, 3: 8},
                    4:  {1: 1.1, 2: 2, 3: 6, 4: 15},
                    5:  {2: 1.5, 3: 4, 4: 10, 5: 30},
                    6:  {2: 1.3, 3: 3, 4: 8, 5: 20, 6: 60},
                    7:  {3: 2, 4: 6, 5: 15, 6: 40, 7: 120},
                    8:  {3: 1.8, 4: 5, 5: 12, 6: 30, 7: 80, 8: 250},
                    9:  {4: 2, 5: 6, 6: 15, 7: 40, 8: 120, 9: 400},
                    10: {4: 2, 5: 5, 6: 12, 7: 30, 8: 80, 9: 250, 10: 800}
                 };



const BLANK = "rgb(30, 31, 35)";
const ACTIVE = "rgb(119, 23, 255)";
const HIT = "rgb(0, 255, 0)";
const MISS = "rgb(20, 20, 20)";

const error = document.getElementById("error");
const multiplier = document.getElementById("multiplier");

function isActive(button) {
    return button.classList.contains("active");
}

function createNumberBoard() {
    let index = 1;
    for (let i = 1; i <= rows; i++) {
        for(let j = 1; j <= cols; j++) {
            const cell = document.createElement('button');
            cell.classList.add("board-cell");
            cell.textContent = index;
            cell.style.cursor = 'pointer';
            cell.id = `cell${index}`;

            cell.addEventListener("click", () => {
                if (!isActive(cell)) {
                    if (pressed_buttons < max_pressed) {
                        cell.classList.add("active");
                        cell.style.backgroundColor = ACTIVE;
                        pressed_buttons++;
                    }
                } else {
                    cell.classList.remove("active");
                    cell.style.backgroundColor = BLANK;
                    pressed_buttons--;
                }
            });

            boardContainer.appendChild(cell);

            index++;
        } 
    }
}


function clearBoard() {
    if(gameRunning) return;
    pressed_buttons = 0;
    for (let btn of boardContainer.children) {
        btn.style.color = "white";
        btn.style.backgroundColor = BLANK;
        btn.classList.remove("active");
    }
}

function resetBoard() {
    for (let btn of boardContainer.children) {
        if(btn.style.backgroundColor === MISS)
            btn.style.backgroundColor = BLANK;
            btn.style.color = "white";
            multiplier.style.animation = "none";

        if(btn.style.backgroundColor === HIT)
            btn.style.backgroundColor = ACTIVE;
    }
}

function sample(arr, count) {
  const shuffled = [...arr].sort(() => Math.random() - 0.5);
  return shuffled.slice(0, count);
}

function calculateMultiplier(picked, hits) {
  return paytable[picked]?.[hits] ?? 0;
}


function placeBet() {
    if(gameRunning) return;

    let intersects = 0;

    if (pressed_buttons < min_pressed || pressed_buttons > max_pressed) {
        error.innerText = "Please select 3-10 boxes";
        error.style.animation = "fadeIn 0.1s linear";
        return;
    }

    gameRunning = true;
    resetBoard();
    
    error.innerText = "";
    multiplier.textContent = "";
    const cells = Array.from(document.getElementsByClassName("board-cell"));
    const drawn = sample(cells, chosen_amount);
    const DELAY = 150;

    drawn.forEach((btn, index) => {
        setTimeout(() => {
            if (isActive(btn)) {
                btn.style.backgroundColor = HIT;
                intersects++;
            } else {
                btn.style.backgroundColor = MISS;
                btn.style.color = "rgb(175, 0, 0)";
            }

            btn.style.animation = "fadeIn 0.4s ease-out";

            setTimeout(() => {
                btn.style.animation = "none";
            }, 400);

        }, index * DELAY);
    });


    const totalRevealTime = drawn.length * DELAY + 400;

    setTimeout(() => {
        const mult = calculateMultiplier(pressed_buttons, intersects);

        if (mult > 1) {
            multiplier.textContent = `x${mult}`;
            multiplier.style.boxShadow = "-3px 3px 0px 2px rgb(61 209 121)";
            multiplier.style.animation = "appear 3s ease-out";
        }

        gameRunning = false;
        
    }, totalRevealTime);

}


createNumberBoard();