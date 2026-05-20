const slider = document.querySelector(".slider input");
const fill = document.querySelector(".fill");
const track = document.querySelector(".track");

const thumb = document.querySelector(".thumb");
const p = document.querySelector(".slider p");

const betBtn = document.querySelector(".betBtn");
const randomVal = document.querySelector(".generatedValue");

const feedback = document.querySelector(".feedback");

randomVal.style.left = track.style.left;

function updateSlider() {
  const percent = ((slider.value - slider.min) / (slider.max - slider.min)) * 100;
  fill.style.width = percent + "%";
  thumb.style.left = percent + "%";
  p.innerText = slider.value;
}

slider.addEventListener("input", updateSlider);


function placeBet() {
    randomVal.style.color = "black";

    const target = Number((Math.random() * 98 + 1).toFixed(2));

    let current = 0;
    const duration = 500;
    const fps = 60;
    const steps = duration / (1000 / fps);
    const increment = target / steps;

    const interval = setInterval(() => {
        current += increment;

        if (current >= target) {
            current = target;
            clearInterval(interval);
        }

        randomVal.innerText = current.toFixed(2);
    }, 1000 / fps);

    setTimeout(() => {
        if (target <= Number(slider.value)) {
            randomVal.style.color = "lime";
        } else {
            randomVal.style.color = "red";
        }
    }, duration);
}


