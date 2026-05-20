const gameBoard = document.getElementById('game-board');
const levelIndicator = document.getElementById('level-indicator');

/*
Legend:
# = wall
. = floor
P = player
B = box
G = goal
*/

const originalLevelMap = [
    ['#','#','#','#','#','#','#','#','#','#','#','#','.','.'],
    ['#','G','G','.','.','#','.','.','.','.','.','#','#','#'],
    ['#','G','G','.','.','#','.','B','.','.','B','.','.','#'],
    ['#','G','G','.','.','#','B','#','#','#','#','.','.','#'],
    ['#','G','G','.','.','.','.','P','.','#','#','.','.','#'],
    ['#','G','G','.','.','#','.','#','.','.','B','.','#','#'],
    ['#','#','#','#','#','#','.','#','#','B','.','B','.','#'],
    ['.','.','#','.','B','.','.','B','.','B','.','B','.','#'],
    ['.','.','#','.','.','.','.','#','.','.','.','.','.','#'],
    ['.','.','#','#','#','#','#','#','#','#','#','#','#','#'],
];

let levelMap = [];
let playerPos = [0, 0];
let totalBoxes = 0;
let goalPositions = [];


function resetLevel() {
    levelMap = structuredClone(originalLevelMap);
    document.querySelector('.winMessage')?.remove();
    initializeLevelData();
    createBoard();
}


function initializeLevelData() {
    totalBoxes = 0;
    goalPositions = [];

    const rows = levelMap.length;
    const cols = levelMap[0].length;

    for (let row = 0; row < rows; row++) {
        for (let col = 0; col < cols; col++) {
            if (levelMap[row][col] === 'B') totalBoxes++;
            if (levelMap[row][col] === 'G') goalPositions.push([row, col]);
        }
    }
}


function createBoard() {
    gameBoard.innerHTML = '';

    const rows = levelMap.length;
    const cols = levelMap[0].length;

    gameBoard.style.gridTemplateColumns = `repeat(${cols}, 40px)`;

    for (let row = 0; row < rows; row++) {
        for (let col = 0; col < cols; col++) {
            const cell = document.createElement('div');
            cell.classList.add('cell');

            const tile = levelMap[row][col];

            if (tile === '#') cell.classList.add('wall');
            if (tile === 'P') {
                cell.classList.add('player');
                playerPos = [row, col];
            }
            if (tile === 'B') cell.classList.add('box');
            if (tile === 'G') cell.classList.add('goal');

            gameBoard.appendChild(cell);
        }
    }
}


addEventListener('keydown', (event) => {
    if (event.code === 'Space') {
        resetLevel();
        return;
    }

    switch (event.key) {
        case 'ArrowUp': movePlayer('up'); break;
        case 'ArrowDown': movePlayer('down'); break;
        case 'ArrowLeft': movePlayer('left'); break;
        case 'ArrowRight': movePlayer('right'); break;
    }
});


function isGoalTile(row, col) {
    return goalPositions.some(([gr, gc]) => gr === row && gc === col);
}

function setTile(row, col, value) {
    levelMap[row][col] = value;
}

function clearTile(row, col) {
    setTile(row, col, isGoalTile(row, col) ? 'G' : '.');
}


function movePlayer(direction) {
    let rowOffset = 0;
    let colOffset = 0;

    switch (direction) {
        case 'up': rowOffset = -1; break;
        case 'down': rowOffset = 1; break;
        case 'left': colOffset = -1; break;
        case 'right': colOffset = 1; break;
    }

    const [playerRow, playerCol] = playerPos;
    const nextRow = playerRow + rowOffset;
    const nextCol = playerCol + colOffset;

    if (!levelMap[nextRow] || levelMap[nextRow][nextCol] === undefined) return;

    const nextTile = levelMap[nextRow][nextCol];

    // Move into empty tile or goal
    if (nextTile === '.' || nextTile === 'G') {
        clearTile(playerRow, playerCol);      // ✅ restore G if needed
        setTile(nextRow, nextCol, 'P');
        playerPos = [nextRow, nextCol];
        createBoard();
        checkVictory();
        return;
    }

    // Push box
    if (nextTile === 'B') {
        const boxNextRow = nextRow + rowOffset;
        const boxNextCol = nextCol + colOffset;

        if (!levelMap[boxNextRow] || levelMap[boxNextRow][boxNextCol] === undefined) return;

        const tileBeyondBox = levelMap[boxNextRow][boxNextCol];

        if (tileBeyondBox === '.' || tileBeyondBox === 'G') {
            setTile(boxNextRow, boxNextCol, 'B'); // move box forward
            setTile(nextRow, nextCol, 'P');       // player into box spot
            clearTile(playerRow, playerCol);      // ✅ restore G if needed
            playerPos = [nextRow, nextCol];
            createBoard();
            checkVictory();
        }
    }
}



function checkVictory() {
    let boxesOnGoals = 0;

    for (const [row, col] of goalPositions) {
        if (levelMap[row][col] === 'B') boxesOnGoals++;
    }

    if (boxesOnGoals === totalBoxes) {
        showVictoryMessage();
    }
}

function showVictoryMessage() {
    if (document.querySelector('.winMessage')) return;

    const message = document.createElement('div');
    message.className = 'winMessage';
    message.textContent = 'Victory!';
    document.body.appendChild(message);
}


resetLevel();
