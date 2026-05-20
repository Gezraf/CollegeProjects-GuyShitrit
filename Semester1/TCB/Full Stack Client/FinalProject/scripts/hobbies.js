const button = document.querySelector(".codingBtn");
const originalText = button.innerText;

button.addEventListener('mouseenter', () => {
    button.innerText = "C0d1ng \n👨🏻‍💻";
});

button.addEventListener('mouseleave', () => {
    button.innerText = originalText;
});