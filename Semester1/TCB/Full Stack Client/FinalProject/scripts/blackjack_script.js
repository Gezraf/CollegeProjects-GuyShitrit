let card_x = 670;
let card_y = -520;

let p1_points = 0;
let p2_points = 0;

const LIMIT = 21;
const cards_pics = [
  '../images/blackjack/ace.png',
  '../images/blackjack/2.png',
  '../images/blackjack/3.png',
  '../images/blackjack/4.png',
  '../images/blackjack/5.png',
  '../images/blackjack/6.png',
  '../images/blackjack/7.png',
  '../images/blackjack/8.png',
  '../images/blackjack/9.png',
  ['../images/blackjack/jack.png', '../images/blackjack/king.png', '../images/blackjack/queen.png']
];

const cards = Array.from(cards_pics.children);


const betBtn = document.querySelector(".betBtn");

const hitBtn = document.querySelector(".hitBtn");
const standBtn = document.querySelector(".standBtn");
const doubleBtn = document.querySelector(".doubleBtn");


let gameRunning = false;

const BET_COLOR = "rgb(37, 200, 37)";
const DISABLED_BET_COLOR = "rgb(132, 245, 132)";

const HIT = "rgb(255, 0, 0)";
const STAND = "rgb(255, 0, 0)";


function shuffle(arr) {
  const copy = [...arr];
  for (let i = copy.length - 1; i > 0; i--) {
    const j = Math.floor(Math.random() * (i + 1));
    [copy[i], copy[j]] = [copy[j], copy[i]];
  }
  return copy;
}


function endGame(player_num) {
  gameRunning = false;
  // betBtn.backgroundColor = BET_COLOR;
  // betBtn.style.cursor = "pointer";
  // betBtn.addEventListener('mouseenter', () => {
  //       betBtn.style.boxShadow = "3px 3px 20px rgb(2, 142, 2)";
  //       betBtn.style.backgroundColor = "lime";
  // });
  
  // betBtn.addEventListener('mouseleave', () => {
  //   betBtn.style.boxShadow = "0px 0px 0px black";
  //   betBtn.style.backgroundColor = "none";
  // });

  if (player_num == 1) {
    {}
  } else {
    {}
  }
}


function isRevealed(card) {
  return card.classList.contains("isRevealed");
}

function handleCardClick(card) {
  if (!gameRunning) return;
  if (isRevealed(card)) return;


  if (gameRunning)
    betBtn.style.backgroundColor = DISABLED_BET_COLOR;

//   if (hits === safecards) {
//       setTimeout(() => {
//         alert(`JACKPOT! You cashed out ALL gems!`);
//         endGame(true);
//         return;
//       }, 100);
//   }
}


function createTable() {
  for (let i = 1; i <= totalCards; i++) {
    const card = document.createElement("button");
    card.id = `card${i}`;

    card.addEventListener("click", () => handleCardClick(card));
    boardContainer.appendChild(card);
  }
}


function resetBoard() {
  for (let card of boardContainer.children) {
    // card.classList.remove("isMine", "isRevealed");
    card.style.border = "solid black 0px";
    card.style.animation = "none";
  }
}


function placeBet() {
  if (gameRunning) return;

  gameRunning = true;
  betBtn.style.backgroundColor = DISABLED_BET_COLOR;
  betBtn.style.cursor = "default";

  betBtn.addEventListener('mouseenter', () => {
    betBtn.style.boxShadow = "0px 0px 0px black";
    betBtn.style.backgroundColor = "none";
  });

  card.style.backgroundImage = "url('../images/blackjack/2.png')"
  card.style.transform = `translate(${card_x}px, ${card_y}px)`;

//   resetBoard();
}

function hit() {
  if (!gameRunning) return;

  if (p1_points > LIMIT)
      endGame(1);
    else if (p1_points == LIMIT)
      endGame(2);

  if (p2_points > LIMIT)
    endGame(2);
  else if (p2_points == LIMIT)
    endGame(1);

  let card = document.createElement("button");
  let index = Math.floor(Math.random() * (cards.length - 1));
  let points = index + 1;


  card.classList.add("card");
  card.style.transform = `translate(${card_x}px, ${card_y}px)`;

  if (index == 9) {
    let list = cards[index];
    card.style.backgroundImage = `url(${list[Math.random() * (list.length - 1)]})`;
  } else 
      card.style.backgroundImage = `url(${cards[index]})`;
  
  card_x += 30;

  betBtn.addEventListener('mouseenter', () => {
    betBtn.style.boxShadow = "0px 0px 0px black";
    betBtn.style.backgroundColor = "none";
  });

//   resetBoard();  
}


// createTable();


betBtn.addEventListener("click", placeBet);
hitBtn.addEventListener("click", hit);
