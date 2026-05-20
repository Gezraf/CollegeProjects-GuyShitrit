const boardContainer = document.getElementById("board");
const ROWS = 5;
const COLS = 5;
const totalCells = ROWS * COLS;

const input = document.querySelector(".minesInput");
const betBtn = document.querySelector(".betBtn");

const error = document.querySelector(".error");
const multiplier = document.getElementById("multiplier");

let hits = 0;
let gameRunning = false;
let minesAmount = 0;

let safeCells = 0;

const BLANK_NOT_STARTED = "rgba(30, 31, 35, 0.46)";
const BLANK = "rgb(30, 31, 35)";
const HIT = "rgb(0, 255, 0)";
const MINE = "rgb(255, 0, 0)";


function isMine(cell) {
  return cell.classList.contains("isMine");
}

function isRevealed(cell) {
  return cell.classList.contains("isRevealed");
}


function shuffle(arr) {
  const copy = [...arr];
  for (let i = copy.length - 1; i > 0; i--) {
    const j = Math.floor(Math.random() * (i + 1));
    [copy[i], copy[j]] = [copy[j], copy[i]];
  }
  return copy;
}

function endGame(won) {
  gameRunning = false;
  input.disabled = false;
  betBtn.textContent = "Bet";

  if (won) {
    multiplier.textContent = "WIN"; // לשנות לכופל שנחשב אחר כך
    multiplier.style.color = "lime";
  } else {
    multiplier.textContent = "x0";
    multiplier.style.color = "red";
  }
}

function handleCellClick(cell) {
  if (!gameRunning) return;
  if (isRevealed(cell)) return;

  if (isMine(cell)) {
    cell.classList.add("isRevealed");
    cell.style.border =`solid ${MINE} 2px`;
    cell.style.zIndex = "1";
    cell.style.animation = "boom 1s ease-out";
    endGame(false);
    return;
  }

  cell.classList.add("isRevealed");
  cell.style.border = `solid ${HIT} 2px`;
  cell.style.boxShadow = "0px 0px 6px rgb(0, 255, 0)";
  hits++;

  if(hits > 0) {
    betBtn.textContent = "Cashout";
  }

  if (hits === safeCells) {
      setTimeout(() => {
        alert(`JACKPOT! You cashed out ALL gems!`);
        endGame(true);
        return;
      }, 100);
  }
}


function createBoard() {
  for (let i = 1; i <= totalCells; i++) {
    const cell = document.createElement("button");
    cell.classList.add("board-cell");
    cell.style.backgroundColor = BLANK_NOT_STARTED;
    cell.id = `cell${i}`;
    cell.style.cursor = "default";

    cell.addEventListener("click", () => handleCellClick(cell));
    boardContainer.appendChild(cell);
  }
}


function resetBoard() {
  multiplier.textContent = "";
  for (let cell of boardContainer.children) {
    cell.classList.remove("isMine", "isRevealed");
    cell.style.cursor = "pointer";
    cell.style.backgroundColor = BLANK;
    cell.style.border = "solid black 0px";
    cell.style.boxShadow = "0px 0px 0px black";
    cell.style.zIndex = "0";
    cell.style.animation = "none";
  }
}


function placeBet() {
  if (gameRunning && hits > 0) {
      alert(`You cashed out from ${hits} gems!`);
      endGame(true);
      return;
  }

  if (gameRunning) return;

  minesAmount = parseInt(input.value);
  if (isNaN(minesAmount) || minesAmount < 1 || minesAmount >= totalCells) {
    error.innerText = `Please enter 1-${totalCells - 1} mines.`;
    error.style.animation = "fadeIn 0.2s linear";
    return;
  }

  gameRunning = true;
  resetBoard();
  error.innerText = "";
  hits = 0;
  safeCells = totalCells - minesAmount;

  input.disabled = true;

  const cells = Array.from(boardContainer.children);
  const mines = shuffle(cells).slice(0, minesAmount);

  for (let cell of mines) {
    cell.classList.add("isMine");
  }
}

createBoard();


betBtn.addEventListener("click", placeBet);
clearBtn.addEventListener("click", resetBoard);