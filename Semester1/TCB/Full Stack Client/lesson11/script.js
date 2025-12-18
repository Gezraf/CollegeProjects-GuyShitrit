let initial = ['1','1','1','\u00A0','2','2','2'];
let finish  = ['2','2','2','\u00A0','1','1','1'];
let layout = initial.slice();

function draw() {
    const msg = document.getElementById("message");
    const tiles = document.querySelectorAll("#board button");

    tiles.forEach((btn, i) => {
        btn.textContent = layout[i];
    });

    if (checkSolved()) {
	msg.style.color = "lime";
        msg.textContent = "You won! All frogs switched sides.";
        return;
    }

    if (noMovesLeft()) {
	msg.style.color = "red";
        msg.textContent = "You lose! No more moves left.";
        return;
    }

    msg.textContent = "";
}


function checkSolved() {
    for (let i = 0; i < layout.length; i++) {
        if (layout[i] !== finish[i]) return false;
    }
    return true;
}

function processMove(index) {
    const piece = layout[index];
    if (piece !== '1' && piece !== '2') return;

    if (piece === '1') {
        if (layout[index + 1] === '\u00A0')
		 flip(index, index + 1);
        else if (layout[index + 2] === '\u00A0') 
		flip(index, index + 2);
    } 
    else if (piece === '2') {
        if (layout[index - 1] === '\u00A0') 
		flip(index, index - 1);
        else if (layout[index - 2] === '\u00A0')
		 flip(index, index - 2);
    }

    draw();
}


function noMovesLeft() {
    for (let i = 0; i < layout.length; i++) {
        const p = layout[i];

        if (p === '1') {
            if (layout[i + 1] === '\u00A0') 
		return false;
            if (layout[i + 2] === '\u00A0')
		 return false;
        }

        if (p === '2') {
            if (layout[i - 1] === '\u00A0') 
		return false;
            if (layout[i - 2] === '\u00A0') 
		return false;
        }
    }
    return true;
}


function flip(a, b) {
    const tmp = layout[a];
    layout[a] = layout[b];
    layout[b] = tmp;
}

function restart() {
    layout = initial.slice();
    draw();
}

document.querySelectorAll("#board button").forEach(btn => {
    btn.addEventListener("click", () => {
        processMove(parseInt(btn.dataset.pos));
    });
});
