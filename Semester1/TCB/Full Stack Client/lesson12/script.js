const defaultTable = [
    [1,2,3,4],
    [5,6,7,8],
    [9,10,11,12],
    [13,14,15,0]
];

let moves = 0;

function shuffle(mat) {
    const flat = mat.flat();

    for (let i = flat.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [flat[i], flat[j]] = [flat[j], flat[i]];
    }

    const res = [];
    for (let i = 0; i < 4; i++) {
        res.push(flat.slice(i * 4, (i + 1) * 4));
    }
    return res;
}

let layout = shuffle(defaultTable);

function checkSolved() {
    for (let r = 0; r < 4; r++) {
        for (let c = 0; c < 4; c++) {
            if (layout[r][c] !== defaultTable[r][c]) return false;
        }
    }
    return true;
}

function draw() {
    const msg = document.getElementById("message");
    const buttons = document.querySelectorAll("#board button");

    buttons.forEach(btn => {
        const r = parseInt(btn.dataset.r);
        const c = parseInt(btn.dataset.c);

        const val = layout[r][c];

        if(val === 0)
            btn.textContent = "_";
        else 
            btn.textContent = val;
    });

    if (checkSolved())
        msg.textContent = "You solved it!";
    else 
        msg.textContent = "";
}

function checkMove(row, col) {
    const directions = [
        [0, 1], [0, -1],
        [1, 0], [-1, 0]
    ];

    for (const [direction_row, direction_col] of directions) {
        const new_row = row + direction_row;
        const new_col = col + direction_col;

        if (new_row < 0 || new_row > 3 || new_col < 0 || new_col > 3) continue;

        if (layout[new_row][new_col] === 0) {
            [layout[row][col], layout[new_row][new_col]] =
            [layout[new_row][new_col], layout[row][col]];
            break;
        }
    }

    draw();
}

function reset() {
    layout = shuffle(defaultTable);
    moves++;
    draw();
}

document.querySelectorAll("#board button").forEach(btn => {


    btn.onclick = () => {
        checkMove(parseInt(btn.dataset.r), parseInt(btn.dataset.c)
        );
    }
});

draw();
