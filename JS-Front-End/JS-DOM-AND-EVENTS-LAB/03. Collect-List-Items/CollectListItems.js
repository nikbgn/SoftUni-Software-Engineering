function extractText() {
    let items = document.getElementById('items').innerText;
    let textarea = document.getElementById('result');
    textarea.textContent = items;
}