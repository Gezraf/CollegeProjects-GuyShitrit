const images = [
    "images/france.png",
    "images/germany.png",
    "images/israel.png",
    "images/netherlands.png",
    "images/poland.png",
    "images/spain.png"
];

const frame = document.getElementById("imgFrame");
const image = document.getElementById("img");
const rangeInput = document.getElementById("rangeInput");
const colorPicker = document.getElementById("colorPicker");

function selectRandomImage() {
    const randomIndex = Math.floor(Math.random() * images.length);
    image.src = images[randomIndex];
}

function changeSize() {
    const size = rangeInput.value + "px";
    image.style.width = size;
    image.style.height = size;
}

rangeInput.oninput = changeSize;


function changeFrameColor() {
    frame.style.backgroundColor = colorPicker.value;
}

colorPicker.oninput = changeFrameColor;

image.style.width = `${rangeInput.value}px`;
image.style.height = `${rangeInput.value}px`;

window.selectRandomImage = selectRandomImage;