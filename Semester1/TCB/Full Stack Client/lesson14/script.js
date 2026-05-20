let gridSize = 10
let paintColor = '#ff6b6b'

function buildCanvas() {
    let area = document.getElementById('canvas')
    area.innerHTML = ''

    for (let r = 0; r < gridSize; r++) {
        let row = document.createElement('div')
        row.style.display = 'flex'

        for (let c = 0; c < gridSize; c++) {
            let cell = document.createElement('div')
            cell.className = 'cell'
            cell.onclick = function () {
                colorCell(this)
            }
            row.appendChild(cell)
        }

        area.appendChild(row)
    }
}

function colorCell(box) {
    box.style.backgroundColor = paintColor
}

function pickPaint(color) {
    paintColor = color
}

function clearCanvas() {
    let cells = document.querySelectorAll('.cell')
    for (let i = 0; i < cells.length; i++) {
        cells[i].style.backgroundColor = ''
    }
}

function resizeCanvas(value) {
    gridSize = value
    document.getElementById('sizeLabel').textContent = value
    buildCanvas()
}

buildCanvas()